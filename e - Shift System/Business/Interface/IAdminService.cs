using e___Shift_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Business.Interface
{
    public interface IAdminService
    {
        Admin AuthonticateAdmin(string username, string passwordHash);

        bool RegisterAdmin(Admin admin, string confirmPassword, out string errorMessage);
        List<Admin> GetAllAdmins();
        void EditAdmin(int adminId, string email, string contact, out string errorMessage);
        void DeleteAdmin(int adminId, out string errorMessage);
        Admin GetAdminById(int adminId);
    }
}
