using e___Shift_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Business.Interface
{
    public interface IAssistantService
    {
        List<Assistant> GetAllAssistants();
        Assistant GetAssistantById(int assistantId);
        int RegisterAssistant(Assistant assistant, out string errorMessage);
        void EditAssistant(Assistant assistant, out string errorMessage);
        void DeleteAssistant(int assistantId, out string errorMessage);
        int GetNextAssistantId();
    }
}
