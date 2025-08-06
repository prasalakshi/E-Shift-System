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
    public class AdminRepository : IAdminRepository
    {
        private readonly string connectionString = "Server=DESKTOP-PCPS2U4;Database=EShiftDB;Integrated Security=SSPI;Trusted_Connection=True;TrustServerCertificate=True;";


        /// <summary>Determines whether [is username or email exists] [the specified username].</summary>
        /// <param name="username">The username.</param>
        /// <param name="email">The email.</param>
        /// <returns>
        ///   <c>true</c> if [is username or email exists] [the specified username]; otherwise, <c>false</c>.</returns>
        /// <exception cref="System.Exception">An error occurred while checking for existing admin.</exception>
        public bool IsUsernameOrEmailExists(string username, string email)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM Admin WHERE Username = @username OR Email = @email";
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
                throw new Exception("An error occurred while checking for existing admin.", ex);
            }
            
        }

        public void AddAdmin(Admin admin)
        {
            if (admin == null)
                throw new ArgumentNullException(nameof(admin));
            if (string.IsNullOrWhiteSpace(admin.Name) ||
                string.IsNullOrWhiteSpace(admin.Email) ||
                string.IsNullOrWhiteSpace(admin.ContactNumber) ||
                string.IsNullOrWhiteSpace(admin.Username) ||
                string.IsNullOrWhiteSpace(admin.PasswordHash))
            {
                throw new ArgumentException("All admin fields must be provided and non-empty.");
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Admin (Name, Email, ContactNumber, Username, PasswordHash, RegistrationDate, Status) " +
                                   "VALUES (@name, @email, @contactnumber, @username, @passwordHash, GETDATE(), @status)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", admin.Name);
                    cmd.Parameters.AddWithValue("@email", admin.Email);
                    cmd.Parameters.AddWithValue("@contactnumber", admin.ContactNumber);
                    cmd.Parameters.AddWithValue("@username", admin.Username);
                    cmd.Parameters.AddWithValue("@passwordHash", admin.PasswordHash);
                    cmd.Parameters.AddWithValue("@status", admin.Status);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"SQL error while adding the admin: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding the admin.", ex);
            }
        }
        

        /// <summary>Gets the admin by username and password.</summary>
        /// <param name="username">The username.</param>
        /// <param name="passwordHash">The password hash.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        /// <exception cref="System.Exception">An error occurred while retrieving admin data.</exception>
        public Admin GetAdminByUsernameAndPassword(string username, string passwordHash)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT AdminID, Username FROM Admin WHERE Username = @username AND PasswordHash = @passwordHash AND Status = 'Active';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@passwordHash", passwordHash);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Admin
                            {
                                AdminID = Convert.ToInt32(reader["AdminID"]),
                                Username = reader["Username"].ToString()
                            };
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occurred while retrieving admin data.", ex);
            }
            return null;
        }

        public List<Admin> GetAllAdmins()
        {
            var admins = new List<Admin>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT AdminID, Name, Email, ContactNumber, Username, PasswordHash, Status FROM Admin";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        admins.Add(new Admin
                        {
                            AdminID = Convert.ToInt32(reader["AdminID"]),
                            Name = reader["Name"].ToString(),
                            Email = reader["Email"].ToString(),
                            ContactNumber = reader["ContactNumber"].ToString(),
                            Username = reader["Username"].ToString(),
                            PasswordHash = reader["PasswordHash"].ToString(),
                            Status = reader["Status"].ToString()
                        });
                    }
                }
            }
            return admins;
        }

        public void UpdateAdminContact(int adminId, string email, string contactNumber)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Admin SET Email=@Email, ContactNumber=@ContactNumber WHERE AdminID=@AdminID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                cmd.Parameters.AddWithValue("@AdminID", adminId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }   
        }

        /// <summary>Deletes the admin.</summary>
        /// <param name="adminId">The admin identifier.</param>
        public void DeleteAdmin(int adminId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Soft delete by setting Status to 'Inactive', and also clear/scramble username and password.
                string query = "UPDATE Admin SET Status='Inactive', Username=CONCAT('deleted_', AdminID, '_', Username), PasswordHash=NEWID() WHERE AdminID=@AdminID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AdminID", adminId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Admin GetAdminById(int adminId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT AdminID, Name, Email, ContactNumber, Username, PasswordHash, Status FROM Admin WHERE AdminID=@AdminID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AdminID", adminId);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Admin
                        {
                            AdminID = Convert.ToInt32(reader["AdminID"]),
                            Name = reader["Name"].ToString(),
                            Email = reader["Email"].ToString(),
                            ContactNumber = reader["ContactNumber"].ToString(),
                            Username = reader["Username"].ToString(),
                            PasswordHash = reader["PasswordHash"].ToString(),
                            Status = reader["Status"].ToString()
                        };
                    }
                }
            }
            return null;
        }
    }


}


