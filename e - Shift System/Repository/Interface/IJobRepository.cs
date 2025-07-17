using e___Shift_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Repository.Interface
{
    public interface IJobRepository
    {
        List<Job> GetJobsByCustomerId(int customerId);
        void AddJob(Job job);
        void UpdateJob(Job job);
        void UpdateJobStatus(int jobId, string status);
        Job GetJobById(int jobId);
    }
}
