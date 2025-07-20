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
    public class AssistantService : IAssistantService
    {
        private readonly IAssistantRepository _repo;
        public AssistantService(IAssistantRepository repo)
        {
            _repo = repo;
        }
        public void DeleteAssistant(int assistantId, out string errorMessage)
        {
            errorMessage = "";
            var assistant = _repo.GetAssistantById(assistantId);
            if (assistant == null)
            {
                errorMessage = "Assistant not found.";
                return;
            }
            if (_repo.IsAssistantAssigned(assistantId))
            {
                errorMessage = "Cannot remove this assistant. They are currently assigned to a transport unit.";
                return;
            }
            _repo.DeleteAssistant(assistantId);
        }

        public void EditAssistant(Assistant assistant, out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrWhiteSpace(assistant.Name))
            {
                errorMessage = "Assistant name is required.";
                return;
            }
            _repo.UpdateAssistant(assistant);
        }

        public List<Assistant> GetAllAssistants()
        {
            return _repo.GetAllAssistants();
        }

        public Assistant GetAssistantById(int assistantId)
        {
            return _repo.GetAssistantById(assistantId);
        }

        public int GetNextAssistantId()
        {
            return _repo.GetNextAssistantId();
        }

        public int RegisterAssistant(Assistant assistant, out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrWhiteSpace(assistant.Name))
            {
                errorMessage = "Assistant name is required.";
                return 0;
            }
            if (string.IsNullOrWhiteSpace(assistant.Status))
                assistant.Status = "Available";

            try
            {
                int assistantId = _repo.AddAssistant(assistant);
                return assistantId;
            }
            catch (Exception ex)
            {
                errorMessage = "Error adding assistant: " + ex.Message;
                return 0;
            }
        }
    }
}
