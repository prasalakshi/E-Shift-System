using e___Shift_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Business.Interface
{
    public interface IJobService
    {
        bool AddJob(Job job, out string errorMessage);
        bool UpdateJob(Job job, out string errorMessage);
        bool CancelJob(int jobId, out string errorMessage);
        List<Job> GetJobsByCustomerId(int customerId);
        Job GetJobById(int jobId);
        List<Job> GetAllJobs();
        void RegisterJob(Job job, out string errorMessage);
        void EditJob(Job job, out string errorMessage);
        List<Job> GetJobsByDate(DateTime jobDate);



    }
}
