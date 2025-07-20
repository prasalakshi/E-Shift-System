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
    public class JobRepository : IJobRepository
    {
        private readonly string connectionString = "Server=DESKTOP-PCPS2U4;Database=EShiftDB;Integrated Security=SSPI;Trusted_Connection=True;TrustServerCertificate=True;";
        public void AddJob(Job job)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            {
                string query = "INSERT INTO Jobs (CustomerID, StartLocation, Destination, JobDate, Status, ShiftingItems) " +
                               "VALUES (@CustomerID, @StartLocation, @Destination, @JobDate, @Status, @ShiftingItems)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", job.CustomerID);
                cmd.Parameters.AddWithValue("@StartLocation", job.StartLocation);
                cmd.Parameters.AddWithValue("@Destination", job.Destination);
                cmd.Parameters.AddWithValue("@JobDate", job.JobDate);
                cmd.Parameters.AddWithValue("@Status", job.Status);
                cmd.Parameters.AddWithValue("@ShiftingItems", job.ShiftingItems);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        

        public List<Job> GetAllJobs()
        {
            var jobs = new List<Job>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Jobs";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        jobs.Add(new Job
                        {
                            JobID = Convert.ToInt32(reader["JobID"]),
                            CustomerID = Convert.ToInt32(reader["CustomerID"]),
                            StartLocation = reader["StartLocation"].ToString(),
                            Destination = reader["Destination"].ToString(),
                            JobDate = Convert.ToDateTime(reader["JobDate"]),
                            Status = reader["Status"].ToString(),
                            ShiftingItems = reader["ShiftingItems"].ToString()
                        });
                    }
                }
            }
            return jobs;
        }

        public Job GetJobById(int jobId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Jobs WHERE JobID=@JobID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobID", jobId);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Job
                        {
                            JobID = (int)reader["JobID"],
                            CustomerID = (int)reader["CustomerID"],
                            StartLocation = reader["StartLocation"].ToString(),
                            Destination = reader["Destination"].ToString(),
                            JobDate = (DateTime)reader["JobDate"],
                            Status = reader["Status"].ToString(),
                            ShiftingItems = reader["ShiftingItems"].ToString()
                        };
                    }
                    return null;
                }
            }
        }

        public List<Job> GetJobsByCustomerId(int customerId)
        {
            List<Job> jobs = new List<Job>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Jobs WHERE CustomerID=@CustomerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        jobs.Add(new Job
                        {
                            JobID = (int)reader["JobID"],
                            CustomerID = (int)reader["CustomerID"],
                            StartLocation = reader["StartLocation"].ToString(),
                            Destination = reader["Destination"].ToString(),
                            JobDate = (DateTime)reader["JobDate"],
                            Status = reader["Status"].ToString(),
                            ShiftingItems = reader["ShiftingItems"].ToString()
                        });
                    }
                }
            }
            return jobs;
        }

        public List<Job> GetJobsByDate(DateTime jobDate)
        {
            var jobs = new List<Job>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Jobs WHERE CAST(JobDate AS DATE) = @JobDate";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobDate", jobDate.Date);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        jobs.Add(new Job
                        {
                            JobID = (int)reader["JobID"],
                            CustomerID = (int)reader["CustomerID"],
                            StartLocation = reader["StartLocation"].ToString(),
                            Destination = reader["Destination"].ToString(),
                            JobDate = (DateTime)reader["JobDate"],
                            Status = reader["Status"].ToString(),
                            ShiftingItems = reader["ShiftingItems"].ToString()
                        });
                    }
                }
            }
            return jobs;
        }

        public void SoftDeleteJob(int jobId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Jobs SET Status='Cancelled' WHERE JobID=@JobID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobID", jobId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateJob(Job job)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE Jobs 
                             SET StartLocation = @StartLocation, 
                                 Destination = @Destination, 
                                 JobDate = @JobDate,
                                 ShiftingItems = @ShiftingItems
                             WHERE JobID = @JobID AND Status = 'Pending'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StartLocation", job.StartLocation);
                    cmd.Parameters.AddWithValue("@Destination", job.Destination);
                    cmd.Parameters.AddWithValue("@JobDate", job.JobDate);
                    cmd.Parameters.AddWithValue("@ShiftingItems", job.ShiftingItems);
                    cmd.Parameters.AddWithValue("@JobID", job.JobID);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating job: " + ex.Message, "Database Error");
                }
            }
        }

        public void UpdateJobStatus(int jobId, string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Jobs SET Status=@Status WHERE JobID=@JobID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@JobID", jobId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
