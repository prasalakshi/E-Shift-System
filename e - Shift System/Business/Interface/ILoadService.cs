using e___Shift_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Business.Interface
{
    public interface ILoadService
    {
        List<Load> GetLoadsByJobId(int jobId);
        Load GetLoadById(int loadId);
        int RegisterLoad(Load load, out string errorMessage);
        void EditLoad(Load load, out string errorMessage);
        void AssignTransportUnit(int loadId, int transportUnitId, out string errorMessage);
        void UpdateStatus(int loadId, string status, out string errorMessage);
        void DeleteLoad(int loadId, out string errorMessage);

        public int GetNextLoadId();
    }
}
