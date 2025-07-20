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
    public class LorryRepository : ILorryRepository
    {
        private readonly string connectionString = "Server=DESKTOP-PCPS2U4;Database=EShiftDB;Integrated Security=SSPI;Trusted_Connection=True;TrustServerCertificate=True;";
        public int AddLorry(Lorry lorry)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Lorries (RegNo, Model, Capacity, Status) 
                         VALUES (@RegNo, @Model, @Capacity, @Status);
                         SELECT CAST(scope_identity() AS int);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RegNo", lorry.RegNo);
                cmd.Parameters.AddWithValue("@Model", lorry.Model);
                cmd.Parameters.AddWithValue("@Capacity", lorry.Capacity);
                cmd.Parameters.AddWithValue("@Status", lorry.Status);
                conn.Open();
                int newId = (int)cmd.ExecuteScalar();
                return newId;
            }
        }

        public void DeleteLorry(int lorryId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                // Soft delete by marking 'Inactive'
                string query = "UPDATE Lorries SET Status = 'Inactive' WHERE LorryID = @LorryID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LorryID", lorryId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Lorry> GetAllLorries()
        {
            var lorries = new List<Lorry>();
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Lorries";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lorries.Add(new Lorry
                        {
                            LorryID = (int)reader["LorryID"],
                            RegNo = reader["RegNo"].ToString(),
                            Model = reader["Model"].ToString(),
                            Capacity = (int)reader["Capacity"],
                            Status = reader["Status"].ToString()
                        });
                    }
                }
            }
            return lorries;
        }

        public Lorry GetLorryById(int lorryId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Lorries WHERE LorryID = @LorryID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LorryID", lorryId);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Lorry
                        {
                            LorryID = (int)reader["LorryID"],
                            RegNo = reader["RegNo"].ToString(),
                            Model = reader["Model"].ToString(),
                            Capacity = (int)reader["Capacity"],
                            Status = reader["Status"].ToString()
                        };
                    }
                }
            }
            return null;
        }

        public int GetNextLorryId()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ISNULL(MAX(LorryID), 0) + 1 FROM Lorries";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int nextId = (int)cmd.ExecuteScalar();
                return nextId;
            }
        }

        public bool IsLorryAssigned(int lorryId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM TransportUnits WHERE LorryID = @LorryID AND Status = 'Available'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LorryID", lorryId);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public void UpdateLorry(Lorry lorry)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Lorries SET RegNo = @RegNo, Model = @Model, Capacity = @Capacity, Status = @Status WHERE LorryID = @LorryID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RegNo", lorry.RegNo);
                cmd.Parameters.AddWithValue("@Model", lorry.Model);
                cmd.Parameters.AddWithValue("@Capacity", lorry.Capacity);
                cmd.Parameters.AddWithValue("@Status", lorry.Status);
                cmd.Parameters.AddWithValue("@LorryID", lorry.LorryID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
