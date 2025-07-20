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
    public class ContainerRepository : IContainerRepository
    {
        private readonly string connectionString = "Server=DESKTOP-PCPS2U4;Database=EShiftDB;Integrated Security=SSPI;Trusted_Connection=True;TrustServerCertificate=True;";

        public int AddContainer(Container container)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Containers (ContainerNo, Type, Capacity, Status) 
                                 VALUES (@ContainerNo, @Type, @Capacity, @Status);
                                 SELECT CAST(scope_identity() AS int);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ContainerNo", container.ContainerNo);
                cmd.Parameters.AddWithValue("@Type", container.Type ?? "");
                cmd.Parameters.AddWithValue("@Capacity", container.Capacity);
                cmd.Parameters.AddWithValue("@Status", container.Status);
                conn.Open();
                int newId = (int)cmd.ExecuteScalar();
                return newId;
            }
        }

        public void DeleteContainer(int containerId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Containers SET Status = 'Inactive' WHERE ContainerID = @ContainerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ContainerID", containerId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Container> GetAllContainers()
        {
            var containers = new List<Container>();
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Containers";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        containers.Add(new Container
                        {
                            ContainerID = (int)reader["ContainerID"],
                            ContainerNo = reader["ContainerNo"].ToString(),
                            Type = reader["Type"].ToString(),
                            Capacity = (int)reader["Capacity"],
                            Status = reader["Status"].ToString()
                        });
                    }
                }
            }
            return containers;
        }

        public Container GetContainerById(int containerId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Containers WHERE ContainerID = @ContainerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ContainerID", containerId);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Container
                        {
                            ContainerID = (int)reader["ContainerID"],
                            ContainerNo = reader["ContainerNo"].ToString(),
                            Type = reader["Type"].ToString(),
                            Capacity = (int)reader["Capacity"],
                            Status = reader["Status"].ToString()
                        };
                    }
                }
            }
            return null;
        }

        public int GetNextContainerId()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ISNULL(MAX(ContainerID), 0) + 1 FROM Containers";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int nextId = (int)cmd.ExecuteScalar();
                return nextId;
            }
        }

        public bool IsContainerAssigned(int containerId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM TransportUnits WHERE ContainerID = @ContainerID AND Status = 'Available'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ContainerID", containerId);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public void UpdateContainer(Container container)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Containers SET ContainerNo=@ContainerNo, Type=@Type, Capacity=@Capacity, Status=@Status WHERE ContainerID=@ContainerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ContainerNo", container.ContainerNo);
                cmd.Parameters.AddWithValue("@Type", container.Type ?? "");
                cmd.Parameters.AddWithValue("@Capacity", container.Capacity);
                cmd.Parameters.AddWithValue("@Status", container.Status);
                cmd.Parameters.AddWithValue("@ContainerID", container.ContainerID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
