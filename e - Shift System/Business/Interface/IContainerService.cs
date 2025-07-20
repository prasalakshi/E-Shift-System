using e___Shift_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Business.Interface
{
    public interface IContainerService
    {
        List<Container> GetAllContainers();
        Container GetContainerById(int containerId);
        int RegisterContainer(Container container, out string errorMessage);
        void EditContainer(Container container, out string errorMessage);
        void DeleteContainer(int containerId, out string errorMessage);
        int GetNextContainerId();
    }
}
