using e___Shift_System.Business.Interface;
using e___Shift_System.Models;
using e___Shift_System.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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
    }
}
