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
    public class LoadService : ILoadService
    {
        private readonly ILoadRepository _repo;
        public LoadService(ILoadRepository repo)
        {
            _repo = repo;
        }
        public void AssignTransportUnit(int loadId, int transportUnitId, out string errorMessage)
        {
            errorMessage = "";
            // Real logic would verify unit availability!
            _repo.SetAssignedTransportUnit(loadId, transportUnitId); throw new NotImplementedException();
        }

        public void DeleteLoad(int loadId, out string errorMessage)
        {
            errorMessage = "";
            _repo.DeleteLoad(loadId);
        }

        public void EditLoad(Load load, out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrWhiteSpace(load.LoadDescription))
            {
                errorMessage = "Description required.";
                return;
            }
            _repo.UpdateLoad(load);
        }

        public Load GetLoadById(int loadId)
        {
            return _repo.GetLoadById(loadId);
        }

        public List<Load> GetLoadsByJobId(int jobId)
        {
            return _repo.GetLoadsByJobId(jobId);
        }

        public int GetNextLoadId()
        {
            return _repo.GetNextLoadId();
        }

        public int RegisterLoad(Load load, out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrWhiteSpace(load.LoadDescription))
            {
                errorMessage = "Description required.";
                return 0;
            }
            load.Status = "Pending";
            return _repo.AddLoad(load);
        }

        public void UpdateStatus(int loadId, string status, out string errorMessage)
        {
            errorMessage = "";
            _repo.UpdateStatus(loadId, status);
        }
    }
}
