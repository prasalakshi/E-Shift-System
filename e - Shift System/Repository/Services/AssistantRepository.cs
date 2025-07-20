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
    public class AssistantRepository : IAssistantRepository
    {
        private readonly string connectionString = "Server=DESKTOP-PCPS2U4;Database=EShiftDB;Integrated Security=SSPI;Trusted_Connection=True;TrustServerCertificate=True;";
        public int AddAssistant(Assistant assistant)
        {
           using (var conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Assistants (Name, Contact, Status) 
                                 VALUES (@Name, @Contact, @Status);
                                 SELECT CAST(scope_identity() AS int);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", assistant.Name);
                cmd.Parameters.AddWithValue("@Contact", assistant.Contact ?? "");
                cmd.Parameters.AddWithValue("@Status", assistant.Status);
                conn.Open();
                int newId = (int)cmd.ExecuteScalar();
                return newId;
            }
        }

        public void DeleteAssistant(int assistantId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Assistants SET Status = 'Inactive' WHERE AssistantID = @AssistantID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AssistantID", assistantId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Assistant> GetAllAssistants()
        {
            var assistants = new List<Assistant>();
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Assistants";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        assistants.Add(new Assistant
                        {
                            AssistantID = (int)reader["AssistantID"],
                            Name = reader["Name"].ToString(),
                            Contact = reader["Contact"].ToString(),
                            Status = reader["Status"].ToString()
                        });
                    }
                }
            }
            return assistants;
        }

        public Assistant GetAssistantById(int assistantId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Assistants WHERE AssistantID = @AssistantID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AssistantID", assistantId);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Assistant
                        {
                            AssistantID = (int)reader["AssistantID"],
                            Name = reader["Name"].ToString(),
                            Contact = reader["Contact"].ToString(),
                            Status = reader["Status"].ToString()
                        };
                    }
                }
            }
            return null;
        }

        public int GetNextAssistantId()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ISNULL(MAX(AssistantID), 0) + 1 FROM Assistants";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int nextId = (int)cmd.ExecuteScalar();
                return nextId;
            }
        }

        public bool IsAssistantAssigned(int assistantId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM TransportUnits WHERE AssistantID = @AssistantID AND Status = 'Available'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AssistantID", assistantId);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public void UpdateAssistant(Assistant assistant)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Assistants SET Name = @Name, Contact = @Contact, Status = @Status WHERE AssistantID = @AssistantID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", assistant.Name);
                cmd.Parameters.AddWithValue("@Contact", assistant.Contact ?? "");
                cmd.Parameters.AddWithValue("@Status", assistant.Status);
                cmd.Parameters.AddWithValue("@AssistantID", assistant.AssistantID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
