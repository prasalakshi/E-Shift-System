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
    public class LoadRepository : ILoadRepository
    {
        private readonly string connectionString = "Server=DESKTOP-PCPS2U4;Database=EShiftDB;Integrated Security=SSPI;Trusted_Connection=True;TrustServerCertificate=True;";
        public int AddLoad(Load load)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Loads (JobID, LoadDescription, Status, AssignedTransportUnitID, PickupDate, DeliveredDate) 
                                VALUES (@JobID, @LoadDescription, @Status, @AssignedTransportUnitID, @PickupDate, @DeliveredDate);
                                SELECT CAST(scope_identity() AS int);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobID", load.JobID);
                cmd.Parameters.AddWithValue("@LoadDescription", load.LoadDescription);
                cmd.Parameters.AddWithValue("@Status", load.Status ?? "Pending");
                cmd.Parameters.AddWithValue("@AssignedTransportUnitID", (object)load.AssignedTransportUnitID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PickupDate", (object)load.PickupDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DeliveredDate", (object)load.DeliveredDate ?? DBNull.Value);
                conn.Open();
                int newId = (int)cmd.ExecuteScalar();
                return newId;
            }
        }

        

        public void DeleteLoad(int loadId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Loads SET Status = 'Cancelled' WHERE LoadID = @LoadID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LoadID", loadId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Load GetLoadById(int loadId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Loads WHERE LoadID = @LoadID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LoadID", loadId);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Load
                        {
                            LoadID = (int)reader["LoadID"],
                            JobID = (int)reader["JobID"],
                            LoadDescription = reader["LoadDescription"].ToString(),
                            AssignedTransportUnitID = reader["AssignedTransportUnitID"] != DBNull.Value ? (int?)reader["AssignedTransportUnitID"] : null,
                            Status = reader["Status"].ToString(),
                            PickupDate = reader["PickupDate"] != DBNull.Value ? (DateTime?)reader["PickupDate"] : null,
                            DeliveredDate = reader["DeliveredDate"] != DBNull.Value ? (DateTime?)reader["DeliveredDate"] : null,
                        };
                    }
                }
            }
            return null;
        }

        public List<Load> GetLoadsByJobId(int jobId)
        {
            var loads = new List<Load>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Loads WHERE JobID = @JobID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobID", jobId);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        loads.Add(new Load
                        {
                            LoadID = (int)reader["LoadID"],
                            JobID = (int)reader["JobID"],
                            LoadDescription = reader["LoadDescription"].ToString(),
                            AssignedTransportUnitID = reader["AssignedTransportUnitID"] != DBNull.Value ? (int?)reader["AssignedTransportUnitID"] : null,
                            Status = reader["Status"].ToString(),
                            PickupDate = reader["PickupDate"] != DBNull.Value ? (DateTime?)reader["PickupDate"] : null,
                            DeliveredDate = reader["DeliveredDate"] != DBNull.Value ? (DateTime?)reader["DeliveredDate"] : null,
                        });
                    }
                }
            }
            return loads;
        }

        public int GetNextLoadId()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ISNULL(MAX(LoadID), 0) + 1 FROM Loads";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int nextId = (int)cmd.ExecuteScalar();
                return nextId;
            }
        }

        public void SetAssignedTransportUnit(int loadId, int transportUnitId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Loads SET AssignedTransportUnitID = @UnitID, Status = 'Assigned' WHERE LoadID = @LoadID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LoadID", loadId);
                cmd.Parameters.AddWithValue("@UnitID", transportUnitId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateLoad(Load load)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Loads SET LoadDescription = @LoadDescription, PickupDate = @PickupDate, DeliveredDate = @DeliveredDate
                                 WHERE LoadID = @LoadID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LoadDescription", load.LoadDescription);
                cmd.Parameters.AddWithValue("@PickupDate", (object)load.PickupDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DeliveredDate", (object)load.DeliveredDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@LoadID", load.LoadID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        

        public void UpdateStatus(int loadId, string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Loads SET Status = @Status WHERE LoadID = @LoadID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@LoadID", loadId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
