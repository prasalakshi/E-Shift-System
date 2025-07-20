using e___Shift_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Repository.Interface
{
    public interface IAssistantRepository
    {
        List<Assistant> GetAllAssistants();
        Assistant GetAssistantById(int assistantId);
        int AddAssistant(Assistant assistant);
        void UpdateAssistant(Assistant assistant);
        void DeleteAssistant(int assistantId);  // Soft delete
        bool IsAssistantAssigned(int assistantId);
        int GetNextAssistantId();
    }
}
