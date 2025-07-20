using e___Shift_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Repository.Interface
{
    public interface ILorryRepository
    {
        List<Lorry> GetAllLorries();
        Lorry GetLorryById(int lorryId);
        int AddLorry(Lorry lorry);
        void UpdateLorry(Lorry lorry);
        void DeleteLorry(int lorryId);  // Optional: could mark as 'Inactive'
        public bool IsLorryAssigned(int lorryId);
        public int GetNextLorryId();
    }
}
