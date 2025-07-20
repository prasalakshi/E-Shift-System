using e___Shift_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Business.Interface
{
    public interface ILorryService
    {
        List<Lorry> GetAllLorries();
        Lorry GetLorryById(int lorryId);
        int RegisterLorry(Lorry lorry, out string errorMessage);
        void EditLorry(Lorry lorry, out string errorMessage);
        void DeleteLorry(int lorryId, out string errorMessage);
        public int GetNextLorryId();
    }
}
