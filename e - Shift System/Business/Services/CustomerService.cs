using e___Shift_System.Business.Interface;
using e___Shift_System.Models;
using e___Shift_System.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Mail;

namespace e___Shift_System.Business.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repo;

        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public Customer AuthenticateCustomer(string username, string password)
        {
            string passwordHash = ComputeSha256Hash(password);
            return _repo.GetCustomerByUsernameAndPassword(username, passwordHash);
        }

        /// <summary>Registers the customer.</summary>
        /// <param name="customer">The customer.</param>
        /// <param name="confirmPassword">The confirm password.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public bool RegisterCustomer(Customer customer, string confirmPassword, out string errorMessage)
        {
            errorMessage = "";

            // Field validation
            if (string.IsNullOrEmpty(customer.Name) || string.IsNullOrEmpty(customer.Email) ||
                string.IsNullOrEmpty(customer.Username) || string.IsNullOrEmpty(customer.PasswordHash) ||
                string.IsNullOrEmpty(customer.ContactNumber) || string.IsNullOrEmpty(confirmPassword))
            {
                errorMessage = "Please fill in all fields.";
                return false;
            }

            if (customer.ContactNumber.Length != 10 || !customer.ContactNumber.All(char.IsDigit))
            {
                errorMessage = "Invalid Contact Number.";
                return false;
            }

            if (customer.PasswordHash != ComputeSha256Hash(confirmPassword))
            {
                errorMessage = "Passwords do not match.";
                return false;
            }

            if (_repo.IsUsernameOrEmailExists(customer.Username, customer.Email))
            {
                errorMessage = "Username or Email already exists.";
                return false;
            }

            // Set status before inserting
            customer.Status = "Active";

            _repo.AddCustomer(customer);
            return true;
        }

        /// <summary>Computes the sha256 hash.</summary>
        /// <param name="rawData">The raw data.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        private static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        public Customer GetCustomerById(int customerId)
        {
            return _repo.GetCustomerById(customerId);
        }

        public void UpdateCustomerProfile(Customer customer, out string errorMessage)
        {
            errorMessage = "";
            if (!ValidateCustomerProfile(customer.Email, customer.ContactNumber, out errorMessage))
                return; // Abandon on failed validation

            errorMessage = "";
            if (string.IsNullOrWhiteSpace(customer.Email) || string.IsNullOrWhiteSpace(customer.ContactNumber))
            {
                errorMessage = "Email and Contact Number must not be blank!";
                return;
            }
            _repo.UpdateCustomer(customer);
        }

        public Customer? GetCustomerById(object customerID)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            return _repo.GetAllCustomers();
        }

        public void DeleteCustomer(int CustomerId, out string errorMessage)
        {
            errorMessage = "";
            var customer = _repo.GetCustomerById(CustomerId);
            if (customer == null)
            {
                errorMessage = "Customer not found.";
                return;
            }
            if (customer.Status == "Inactive")
            {
                errorMessage = "Customer already deleted.";
                return;
            }
            _repo.DeleteCustomer(CustomerId);
        }

        public void EditCustomer(int CustomerId, string email, string contact, out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(contact))
            {
                errorMessage = "Email and Contact Number cannot be blank.";
                return;
            }
            _repo.UpdateCustomerContact(CustomerId, email, contact);
        }

        public bool ValidateCustomerProfile(string contact, string email, out string errorMessage)
        {
            if (!ValidateContactNumber(contact))
            {
                errorMessage = "Contact Number must contain only numbers.";
                return false;
            }

            try
            {
                var mail = new MailAddress(email);
            }
            catch
            {
                errorMessage = "Invalid email format.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        public bool ValidateContactNumber(string contact)
        {
            // Remove leading/trailing spaces
            contact = contact.Trim();

            // Only check: not empty and all digits
            if (string.IsNullOrWhiteSpace(contact) || !contact.All(char.IsDigit))
                return false;
            return true;

        }

        public bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            try
            {
                var addr = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    }

