using e___Shift_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Repository.Interface
{
    public interface IContainerRepository
    {
        List<Container> GetAllContainers();
        Container GetContainerById(int containerId);
        int AddContainer(Container container);
        void UpdateContainer(Container container);
        void DeleteContainer(int containerId); // Soft delete
        bool IsContainerAssigned(int containerId);
        int GetNextContainerId();
    }
}
