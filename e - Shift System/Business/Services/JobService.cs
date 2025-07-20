using e___Shift_System.Business.Interface;
using e___Shift_System.Models;
using e___Shift_System.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Business.Services
{
    internal class JobService : IJobService
    {
        private readonly IJobRepository _repo;

        public JobService(IJobRepository repo)
        {
            _repo = repo;
        }
        public bool AddJob(Job job, out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrWhiteSpace(job.StartLocation) || string.IsNullOrWhiteSpace(job.Destination) )
            {
                errorMessage = "Start Location and Destination are required.";
                return false;
            }
            if (job.JobDate < DateTime.Today)
            {
                errorMessage = "Job date cannot be in the past.";
                return false;
            }
            job.Status = "Pending";
            try
            {
                _repo.AddJob(job);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = "Error adding job: " + ex.Message;
                return false;
            }
        }

        public bool CancelJob(int jobId, out string errorMessage)
        {
            errorMessage = "";
            var dbJob = _repo.GetJobById(jobId);

            if (dbJob == null)
            {
                errorMessage = "Job not found.";
                return false;
            }
            if (dbJob.Status != "Pending")
            {
                errorMessage = "Cannot cancel: job is not pending.";
                return false;
            }
            try
            {
                _repo.UpdateJobStatus(jobId, "Cancelled");
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = "Error cancelling job: " + ex.Message;
                return false;
            }
        }

        public void EditJob(Job job, out string errorMessage)
        {
            bool success = UpdateJob(job, out errorMessage);
        }

        public List<Job> GetAllJobs()
        {
            return _repo.GetAllJobs();
        }

        public Job GetJobById(int jobId)
        {
            return _repo.GetJobById(jobId);
        }

        public List<Job> GetJobsByCustomerId(int customerId)
        {
            return _repo.GetJobsByCustomerId(customerId);
        }

        public List<Job> GetJobsByDate(DateTime jobDate)
        {
            return _repo.GetJobsByDate(jobDate);
        }

        public void RegisterJob(Job job, out string errorMessage)
        {
            bool success = AddJob(job, out errorMessage);
        }

        public bool UpdateJob(Job job, out string errorMessage)
        {
            errorMessage = "";
            var dbJob = _repo.GetJobById(job.JobID);
            if (dbJob == null)
            {
                errorMessage = "Job not found.";
                return false;
            }
            if (dbJob.Status != "Pending")
            {
                errorMessage = "Only jobs in 'Pending' status can be edited.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(job.StartLocation) || string.IsNullOrWhiteSpace(job.Destination))
            {
                errorMessage = "Start Location and Destination are required.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(job.ShiftingItems))
            {
                errorMessage = "Shifting Items cannot be blank.";
                return false;
            }
            if (job.JobDate < DateTime.Today)
            {
                errorMessage = "Job date cannot be in the past.";
                return false;
            }
            _repo.UpdateJob(job);
            return true;
        }
    }
}
