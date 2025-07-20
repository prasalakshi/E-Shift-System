using e___Shift_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Repository.Interface
{
    public interface IDriverRepository
    {
        List<Driver> GetAllDrivers();
        Driver GetDriverById(int driverId);
        int AddDriver(Driver driver);
        void UpdateDriver(Driver driver);
        void DeleteDriver(int driverId);  // Soft delete
        bool IsDriverAssigned(int driverId);
        int GetNextDriverId();
    }
}
