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

    public class DriverRepository : IDriverRepository
    {
        private readonly string connectionString = "Server=DESKTOP-PCPS2U4;Database=EShiftDB;Integrated Security=SSPI;Trusted_Connection=True;TrustServerCertificate=True;";
        public int AddDriver(Driver driver)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Drivers (Name, LicenseNo, Contact, Status) 
                                 VALUES (@Name, @LicenseNo, @Contact, @Status);
                                 SELECT CAST(scope_identity() AS int);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", driver.Name);
                cmd.Parameters.AddWithValue("@LicenseNo", driver.LicenseNo);
                cmd.Parameters.AddWithValue("@Contact", driver.Contact ?? "");
                cmd.Parameters.AddWithValue("@Status", driver.Status);
                conn.Open();
                int newId = (int)cmd.ExecuteScalar();
                return newId;
            }
        }

        public void DeleteDriver(int driverId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Drivers SET Status = 'Inactive' WHERE DriverID = @DriverID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DriverID", driverId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Driver> GetAllDrivers()
        {
            var drivers = new List<Driver>();
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Drivers";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        drivers.Add(new Driver
                        {
                            DriverID = (int)reader["DriverID"],
                            Name = reader["Name"].ToString(),
                            LicenseNo = reader["LicenseNo"].ToString(),
                            Contact = reader["Contact"].ToString(),
                            Status = reader["Status"].ToString()
                        });
                    }
                }
            }
            return drivers;
        }

        public Driver GetDriverById(int driverId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Drivers WHERE DriverID = @DriverID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DriverID", driverId);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Driver
                        {
                            DriverID = (int)reader["DriverID"],
                            Name = reader["Name"].ToString(),
                            LicenseNo = reader["LicenseNo"].ToString(),
                            Contact = reader["Contact"].ToString(),
                            Status = reader["Status"].ToString()
                        };
                    }
                }
            }
            return null;
        }

        public int GetNextDriverId()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ISNULL(MAX(DriverID), 0) + 1 FROM Drivers";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int nextId = (int)cmd.ExecuteScalar();
                return nextId;
            }
        }

        public bool IsDriverAssigned(int driverId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM TransportUnits WHERE DriverID = @DriverID AND Status = 'Available'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DriverID", driverId);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public void UpdateDriver(Driver driver)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Drivers SET Name = @Name, LicenseNo = @LicenseNo, Contact = @Contact, Status = @Status WHERE DriverID = @DriverID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", driver.Name);
                cmd.Parameters.AddWithValue("@LicenseNo", driver.LicenseNo);
                cmd.Parameters.AddWithValue("@Contact", driver.Contact ?? "");
                cmd.Parameters.AddWithValue("@Status", driver.Status);
                cmd.Parameters.AddWithValue("@DriverID", driver.DriverID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
