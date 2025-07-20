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
    internal class LorryService : ILorryService
    {
        private readonly ILorryRepository _repo;
        public LorryService(ILorryRepository repo) 
        { 
            _repo = repo; 
        }

        public void DeleteLorry(int lorryId, out string errorMessage)
        {
            errorMessage = "";

            var lorry = _repo.GetLorryById(lorryId);
            if (lorry == null)
            {
                errorMessage = "Lorry not found.";
                return;
            }

            // Check if lorry is assigned to any (active) TransportUnit
            if (_repo.IsLorryAssigned(lorryId))
            {
                errorMessage = "Cannot remove this lorry. It is currently assigned to a transport unit.";
                return;
            }

            _repo.DeleteLorry(lorryId); // Soft delete (mark as 'Inactive')
        }

        public void EditLorry(Lorry lorry, out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrWhiteSpace(lorry.RegNo) || string.IsNullOrWhiteSpace(lorry.Model))
            {
                errorMessage = "Registration Number and Model are required.";
                return;
            }
            if (lorry.Capacity <= 0)
            {
                errorMessage = "Capacity must be a positive number.";
                return;
            }
            _repo.UpdateLorry(lorry);
        }

        public List<Lorry> GetAllLorries()
        {
            return _repo.GetAllLorries();
        }

        public Lorry GetLorryById(int lorryId)
        {
            return _repo.GetLorryById(lorryId);
        }

        public int GetNextLorryId()
        {
            return _repo.GetNextLorryId();
        }

        public int RegisterLorry(Lorry lorry, out string errorMessage)
        {
            errorMessage = "";

            // Validate required fields
            if (string.IsNullOrWhiteSpace(lorry.RegNo))
            {
                errorMessage = "Registration number is required.";
                return 0;
            }
            if (string.IsNullOrWhiteSpace(lorry.Model))
            {
                errorMessage = "Model is required.";
                return 0;
            }
            if (lorry.Capacity <= 0)
            {
                errorMessage = "Capacity must be a positive value.";
                return 0;
            }

            // Set default status if not provided
            if (string.IsNullOrWhiteSpace(lorry.Status))
            {
                lorry.Status = "Available";
            }

            // Check for duplicates (by RegNo)
            var allLorries = _repo.GetAllLorries();
            if (allLorries.Any(l => l.RegNo.Equals(lorry.RegNo, StringComparison.OrdinalIgnoreCase)))
            {
                errorMessage = "A lorry with this registration number already exists.";
                return 0;
            }

            try
            {
                int lorryId = _repo.AddLorry(lorry); // This must return the new ID (see below)
                return lorryId;
            }
            catch (Exception ex)
            {
                errorMessage = "Error adding lorry: " + ex.Message;
                return 0;
            }
        }
    }
}
