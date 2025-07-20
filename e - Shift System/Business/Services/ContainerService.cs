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
    public class ContainerService : IContainerService
    {
        private readonly IContainerRepository _repo;

        public ContainerService(IContainerRepository repo)
        {
            _repo = repo;
        }

        public void DeleteContainer(int containerId, out string errorMessage)
        {
            errorMessage = "";
            var container = _repo.GetContainerById(containerId);
            if (container == null)
            {
                errorMessage = "Container not found.";
                return;
            }
            if (_repo.IsContainerAssigned(containerId))
            {
                errorMessage = "Cannot remove this container. It is currently assigned to a transport unit.";
                return;
            }
            _repo.DeleteContainer(containerId);
        }

        public void EditContainer(Container container, out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrWhiteSpace(container.ContainerNo))
            {
                errorMessage = "Container number is required.";
                return;
            }
            if (container.Capacity <= 0)
            {
                errorMessage = "Capacity must be a positive value.";
                return;
            }
            _repo.UpdateContainer(container);
        }

        public List<Container> GetAllContainers()
        {
            return _repo.GetAllContainers();
        }

        public Container GetContainerById(int containerId)
        {
            return _repo.GetContainerById(containerId);
        }

        public int GetNextContainerId()
        {
            return _repo.GetNextContainerId();
        }

        public int RegisterContainer(Container container, out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrWhiteSpace(container.ContainerNo))
            {
                errorMessage = "Container number is required.";
                return 0;
            }
            if (container.Capacity <= 0)
            {
                errorMessage = "Capacity must be a positive value.";
                return 0;
            }
            if (string.IsNullOrWhiteSpace(container.Status))
                container.Status = "Available";
            var all = _repo.GetAllContainers();
            if (all.Any(c => c.ContainerNo.Equals(container.ContainerNo, StringComparison.OrdinalIgnoreCase)))
            {
                errorMessage = "A container with this number already exists.";
                return 0;
            }
            try
            {
                int id = _repo.AddContainer(container);
                return id;
            }
            catch (Exception ex)
            {
                errorMessage = "Error adding container: " + ex.Message;
                return 0;
            }
        }
    }
}
