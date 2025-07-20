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
    public class TransportUnitRepository : ITransportUnitRepository
    {
        private readonly string connectionString = "Server=DESKTOP-PCPS2U4;Database=EShiftDB;Integrated Security=SSPI;Trusted_Connection=True;TrustServerCertificate=True;";
        public int AddTransportUnit(TransportUnit unit)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO TransportUnits (LorryID,DriverID,AssistantID,ContainerID,Status)
                                VALUES (@LorryID,@DriverID,@AssistantID,@ContainerID,@Status);
                                SELECT CAST(scope_identity() AS int);";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LorryID", unit.LorryID);
                cmd.Parameters.AddWithValue("@DriverID", unit.DriverID);
                cmd.Parameters.AddWithValue("@AssistantID", (object)unit.AssistantID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ContainerID", unit.ContainerID);
                cmd.Parameters.AddWithValue("@Status", unit.Status ?? "Assigned");
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public void DeleteTransportUnit(int unitId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE TransportUnits SET Status='Inactive' WHERE TransportUnitID=@id";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", unitId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<TransportUnit> GetAllTransportUnits()
        {
            var list = new List<TransportUnit>();
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TransportUnits";
                var cmd = new SqlCommand(query, conn);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new TransportUnit
                        {
                            TransportUnitID = (int)reader["TransportUnitID"],
                            LorryID = (int)reader["LorryID"],
                            DriverID = (int)reader["DriverID"],
                            AssistantID = reader["AssistantID"] != DBNull.Value ? (int?)reader["AssistantID"] : null,
                            ContainerID = (int)reader["ContainerID"],
                            Status = reader["Status"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public List<Assistant> GetAvailableAssistants()
        {
            var list = new List<Assistant>();
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT AssistantID, Name FROM Assistants WHERE Status = 'Available'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Assistant
                        {
                            AssistantID = (int)reader["AssistantID"],
                            Name = reader["Name"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public List<Container> GetAvailableContainers()
        {
            var list = new List<Container>();
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ContainerID, ContainerNo FROM Containers WHERE Status = 'Available'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Container
                        {
                            ContainerID = (int)reader["ContainerID"],
                            ContainerNo = reader["ContainerNo"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public List<Driver> GetAvailableDrivers()
        {
            var list = new List<Driver>();
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DriverID, Name FROM Drivers WHERE Status = 'Available'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Driver
                        {
                            DriverID = (int)reader["DriverID"],
                            Name = reader["Name"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public List<Lorry> GetAvailableLorries()
        {
            var list = new List<Lorry>();
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT LorryID, RegNo FROM Lorries WHERE Status = 'Available'";
                var cmd = new SqlCommand(query, conn);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                        list.Add(new Lorry { LorryID = (int)reader["LorryID"], RegNo = reader["RegNo"].ToString() });
            }
            return list;
        }

        public TransportUnit GetTransportUnitById(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TransportUnits WHERE TransportUnitID=@id";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new TransportUnit
                        {
                            TransportUnitID = (int)reader["TransportUnitID"],
                            LorryID = (int)reader["LorryID"],
                            DriverID = (int)reader["DriverID"],
                            AssistantID = reader["AssistantID"] != DBNull.Value ? (int?)reader["AssistantID"] : null,
                            ContainerID = (int)reader["ContainerID"],
                            Status = reader["Status"].ToString()
                        };
                    }
                }
            }
            return null;
        }

        public void UpdateTransportUnit(TransportUnit unit)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE TransportUnits
                                 SET LorryID=@LorryID,DriverID=@DriverID,AssistantID=@AssistantID,ContainerID=@ContainerID,Status=@Status
                                 WHERE TransportUnitID=@TransportUnitID";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LorryID", unit.LorryID);
                cmd.Parameters.AddWithValue("@DriverID", unit.DriverID);
                cmd.Parameters.AddWithValue("@AssistantID", (object)unit.AssistantID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ContainerID", unit.ContainerID);
                cmd.Parameters.AddWithValue("@Status", unit.Status);
                cmd.Parameters.AddWithValue("@TransportUnitID", unit.TransportUnitID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
