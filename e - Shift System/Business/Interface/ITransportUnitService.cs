using e___Shift_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Business.Interface
{
    public interface ITransportUnitService
    {

        int AddTransportUnit(TransportUnit unit, out string errorMessage);
        void EditTransportUnit(TransportUnit unit, out string errorMessage);
        void DeleteTransportUnit(int unitId, out string errorMessage);
        List<TransportUnit> GetAllTransportUnits();
        TransportUnit GetTransportUnitById(int id);
        List<Lorry> GetAvailableLorries();
        List<Driver> GetAvailableDrivers();
        List<Assistant> GetAvailableAssistants();
        List<Container> GetAvailableContainers();

    }
}
