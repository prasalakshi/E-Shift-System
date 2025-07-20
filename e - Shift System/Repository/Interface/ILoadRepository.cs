using e___Shift_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Repository.Interface
{
    public interface ILoadRepository
    {
        List<Load> GetLoadsByJobId(int jobId);
        Load GetLoadById(int loadId);
        int AddLoad(Load load);
        void UpdateLoad(Load load);
        void SetAssignedTransportUnit(int loadId, int transportUnitId);
        void UpdateStatus(int loadId, string status);
        void DeleteLoad(int loadId); // Soft-delete ("Cancelled")
        public int GetNextLoadId();
    }
}
