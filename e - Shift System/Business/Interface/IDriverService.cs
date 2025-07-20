using e___Shift_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Business.Interface
{
    public interface IDriverService
    {
        List<Driver> GetAllDrivers();
        Driver GetDriverById(int driverId);
        int RegisterDriver(Driver driver, out string errorMessage);
        void EditDriver(Driver driver, out string errorMessage);
        void DeleteDriver(int driverId, out string errorMessage);
        int GetNextDriverId();
    }
}
