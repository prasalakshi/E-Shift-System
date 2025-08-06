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
        /// <summary>Gets the admin by username and password.</summary>
        /// <param name="username">The username.</param>
        /// <param name="passwordHash">The password hash.</param>       
        Admin GetAdminByUsernameAndPassword(string username, string passwordHash);


        /// <summary>Determines whether [is username or email exists] [the specified username].</summary>
        /// <param name="username">The username.</param>
        /// <param name="email">The email.</param>
        /// <returns>
        ///   <c>true</c> if [is username or email exists] [the specified username]; otherwise, <c>false</c>.</returns>
        bool IsUsernameOrEmailExists(string username, string email);


        /// <summary>Adds the admin.</summary>
        /// <param name="admin">The admin.</param>
        void AddAdmin(Admin admin);


        /// <summary>Gets all admins.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        List<Admin> GetAllAdmins();


        /// <summary>Updates the admin contact.</summary>
        /// <param name="adminId">The admin identifier.</param>
        /// <param name="email">The email.</param>
        /// <param name="contactNumber">The contact number.</param>
        void UpdateAdminContact(int adminId, string email, string contactNumber);


        /// <summary>Deletes the admin.</summary>
        /// <param name="adminId">The admin identifier.</param>
        void DeleteAdmin(int adminId);


        /// <summary>Gets the admin by identifier.</summary>
        /// <param name="adminId">The admin identifier.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        Admin GetAdminById(int adminId);


    }
}
