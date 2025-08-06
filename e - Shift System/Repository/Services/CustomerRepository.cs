using e___Shift_System.Models;
using e___Shift_System.Repository.Interface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Repository.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly string connectionString = "Server=DESKTOP-PCPS2U4;Database=EShiftDB;Integrated Security=SSPI;Trusted_Connection=True;TrustServerCertificate=True;";

        /// <summary>Gets the customer by username and password.</summary>
        /// <param name="username">The username.</param>
        /// <param name="passwordHash">The password hash.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        /// <exception cref="System.Exception">An error occurred while retrieving customer data.</exception>
        public Customer GetCustomerByUsernameAndPassword(string username, string passwordHash)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT CustomerID, Username, Status FROM Customers WHERE Username = @username AND PasswordHash = @passwordHash;";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@passwordHash", passwordHash);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Customer
                            {
                                CustomerID = Convert.ToInt32(reader["CustomerID"]),
                                Username = reader["Username"].ToString(),
                                Status = reader["Status"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving customer data.", ex);
            }
            return null;


        }

        public void AddCustomer(Customer customer)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Customers (Name, Email, Username, PasswordHash, ContactNumber, RegistrationDate, Status) " +
                                   "VALUES (@name, @email, @username, @passwordHash, @contactNumber, GETDATE(), @Status)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", customer.Name);
                    cmd.Parameters.AddWithValue("@email", customer.Email);
                    cmd.Parameters.AddWithValue("@username", customer.Username);
                    cmd.Parameters.AddWithValue("@passwordHash", customer.PasswordHash);
                    cmd.Parameters.AddWithValue("@contactNumber", customer.ContactNumber);
                    cmd.Parameters.AddWithValue("@status", customer.Status);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving customer data.", ex);
            }
        }

        // Add this method to check for duplicates
        public bool IsUsernameOrEmailExists(string username, string email)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM Customers WHERE Username = @username OR Email = @email";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);

                    conn.Open();
                    int exists = (int)cmd.ExecuteScalar();
                    return exists > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving customer data.", ex);
            }
        }

        public Customer GetCustomerById(int customerId)
        {
            Customer? customer = null; // Use nullable type
            using SqlConnection conn = new SqlConnection(connectionString);
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Customers WHERE CustomerID=@CustomerID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customer = new Customer
                            {
                                CustomerID = Convert.ToInt32(reader["CustomerID"]),
                                Name = reader["Name"].ToString(),
                                Email = reader["Email"].ToString(),
                                ContactNumber = reader["ContactNumber"].ToString(),
                                Username = reader["Username"].ToString(),
                                PasswordHash = reader["PasswordHash"].ToString(),
                                RegistrationDate = Convert.ToDateTime(reader["RegistrationDate"])
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading the customer profile." + ex.Message, "Database Error");
                }
            }
            return customer;
        }


        public void UpdateCustomer(Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE Customers SET Email=@Email, ContactNumber=@ContactNumber WHERE CustomerID=@CustomerID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", customer.Email);
                    cmd.Parameters.AddWithValue("@ContactNumber", customer.ContactNumber);
                    cmd.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating profile: " + ex.Message, "Database Error");
                }
            }
        }

        public List<Customer> GetAllCustomers()
        {
            var customers = new List<Customer>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Customers"; 
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customers.Add(new Customer
                        {
                            CustomerID = Convert.ToInt32(reader["CustomerID"]),
                            Name = reader["Name"].ToString(),
                            Email = reader["Email"].ToString(),
                            Username = reader["Username"].ToString(),
                            PasswordHash = reader["PasswordHash"].ToString(),
                            ContactNumber = reader["ContactNumber"].ToString(),
                            RegistrationDate = Convert.ToDateTime(reader["RegistrationDate"]),
                            Status = reader["Status"].ToString() // 
                        });
                    }
                }
            }
            return customers;
        }

        public void DeleteCustomer(int customerId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        UPDATE Customers
        SET Status='Inactive',
            Username=CONCAT('deleted_', CustomerID, '_', Username),
            PasswordHash=NEWID()
        WHERE CustomerID=@CustomerID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCustomerContact(int customerId, string email, string contactnumber)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Customers SET Email=@Email, ContactNumber=@ContactNumber WHERE CustomerID=@CustomerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@ContactNumber", contactnumber);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
