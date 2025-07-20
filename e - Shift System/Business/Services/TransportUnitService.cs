
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
    public class TransportUnitService : ITransportUnitService
    {
        private readonly ITransportUnitRepository _repo;

        public TransportUnitService(ITransportUnitRepository repo)
        {
            _repo = repo;
        }
        public int AddTransportUnit(TransportUnit unit, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                // Optionally, add validation for unique/duplicate business logic here
                return _repo.AddTransportUnit(unit);
            }
            catch (Exception ex)
            {
                errorMessage = $"Failed to add transport unit: {ex.Message}";
                return 0;
            }
        }

        public void DeleteTransportUnit(int unitId, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                _repo.DeleteTransportUnit(unitId);
            }
            catch (Exception ex)
            {
                errorMessage = $"Failed to delete transport unit: {ex.Message}";
            }
        }

        public void EditTransportUnit(TransportUnit unit, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                _repo.UpdateTransportUnit(unit);
            }
            catch (Exception ex)
            {
                errorMessage = $"Failed to update transport unit: {ex.Message}";
            }
        }

        public List<TransportUnit> GetAllTransportUnits()
        {
            try
            {
                return _repo.GetAllTransportUnits();
            }
            catch
            {
                return new List<TransportUnit>();
            }
        }

        public List<Assistant> GetAvailableAssistants()
        {
            try
            {
                return _repo.GetAvailableAssistants();
            }
            catch
            {
                return new List<Assistant>();
            }
        }

        public List<Container> GetAvailableContainers()
        {
            try
            {
                return _repo.GetAvailableContainers();
            }
            catch
            {
                return new List<Container>();
            }
        }

        public List<Driver> GetAvailableDrivers()
        {
            try
            {
                return _repo.GetAvailableDrivers();
            }
            catch
            {
                return new List<Driver>();
            }
        }

        public List<Lorry> GetAvailableLorries()
        {
            try
            {
                return _repo.GetAvailableLorries();
            }
            catch
            {
                return new List<Lorry>();
            }

        }

        public TransportUnit GetTransportUnitById(int id)
        {
            try
            {
                return _repo.GetTransportUnitById(id);
            }
            catch
            {
                return null;
            }
        }
    }
}
