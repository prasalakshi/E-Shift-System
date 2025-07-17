using e___Shift_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Repository.Interface
{
    public interface IAdminRepository
    {
        Admin GetAdminByUsernameAndPassword(string username, string passwordHash);
        bool IsUsernameOrEmailExists(string username, string email);
        void AddAdmin(Admin admin);

        List<Admin> GetAllAdmins();
        void UpdateAdminContact(int adminId, string email, string contactNumber);
        void DeleteAdmin(int adminId);
        Admin GetAdminById(int adminId);


    }
}
