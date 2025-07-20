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
    public class DriverService : IDriverService
    {
        private readonly IDriverRepository _repo;
        public DriverService(IDriverRepository repo)
        {
            _repo = repo;
        }

        public void DeleteDriver(int driverId, out string errorMessage)
        {
            errorMessage = "";
            var driver = _repo.GetDriverById(driverId);
            if (driver == null)
            {
                errorMessage = "Driver not found.";
                return;
            }
            if (_repo.IsDriverAssigned(driverId))
            {
                errorMessage = "Cannot remove this driver. It is currently assigned to a transport unit.";
                return;
            }
            _repo.DeleteDriver(driverId);
        }

        public void EditDriver(Driver driver, out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrWhiteSpace(driver.Name))
            {
                errorMessage = "Driver name is required.";
                return;
            }
            if (string.IsNullOrWhiteSpace(driver.LicenseNo))
            {
                errorMessage = "License number is required.";
                return;
            }
            _repo.UpdateDriver(driver);
        }

        public List<Driver> GetAllDrivers()
        {
            return _repo.GetAllDrivers();
        }

        public Driver GetDriverById(int driverId)
        {
            return _repo.GetDriverById(driverId);
        }

        public int GetNextDriverId()
        {
            return _repo.GetNextDriverId();
        }

        public int RegisterDriver(Driver driver, out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(driver.Name))
            {
                errorMessage = "Driver name is required.";
                return 0;
            }
            if (string.IsNullOrWhiteSpace(driver.LicenseNo))
            {
                errorMessage = "License number is required.";
                return 0;
            }
            // Status default
            if (string.IsNullOrWhiteSpace(driver.Status))
                driver.Status = "Available";

            // Uniqueness for license
            var allDrivers = _repo.GetAllDrivers();
            if (allDrivers.Any(d => d.LicenseNo.Equals(driver.LicenseNo, StringComparison.OrdinalIgnoreCase)))
            {
                errorMessage = "A driver with this license number already exists.";
                return 0;
            }

            try
            {
                int driverId = _repo.AddDriver(driver);
                return driverId;
            }
            catch (Exception ex)
            {
                errorMessage = "Error adding driver: " + ex.Message;
                return 0;
            }
        }
    }
}
