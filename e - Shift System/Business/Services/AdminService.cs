using e___Shift_System.Business.Interface;
using e___Shift_System.Models;
using e___Shift_System.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Business.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _repo;

        public AdminService(IAdminRepository repo)
        {
            _repo = repo;
        }
                
        public Admin AuthonticateAdmin(string username, string password)
        {
            string passwordHash = ComputeSha256Hash(password);
            return _repo.GetAdminByUsernameAndPassword(username, passwordHash);
        }

        public void DeleteAdmin(int adminId, out string errorMessage)
        {
            errorMessage = "";
            var admin = _repo.GetAdminById(adminId);
            if (admin == null) { errorMessage = "Admin not found."; return; }
            if (admin.Status == "Inactive") { errorMessage = "Admin already deleted."; return; }
            _repo.DeleteAdmin(adminId);
        }

        public void EditAdmin(int adminId, string email, string contact, out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(contact))
            {
                errorMessage = "Email and Contact Number cannot be blank.";
                return;
            }
            _repo.UpdateAdminContact(adminId, email, contact);
        }
        

        public Admin GetAdminById(int adminId)
        {
            return _repo.GetAdminById(adminId);
        }

        public List<Admin> GetAllAdmins()
        {
            return _repo.GetAllAdmins();
        }

        public bool RegisterAdmin(Admin admin, string confirmPassword, out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrEmpty(admin.Name) || string.IsNullOrEmpty(admin.Email) || string.IsNullOrEmpty(admin.ContactNumber) ||
                string.IsNullOrEmpty(admin.Username) || string.IsNullOrEmpty(admin.PasswordHash) ||
                string.IsNullOrEmpty(confirmPassword))
            {
                errorMessage = "Please fill in all fields.";
                return false;
            }

            if (admin.ContactNumber.Length != 10 || !admin.ContactNumber.All(char.IsDigit))
            {
                errorMessage = "Invalid Contact Number.";
                return false;
            }

            if (admin.PasswordHash != ComputeSha256Hash(confirmPassword))
            {
                errorMessage = "Passwords do not match.";
                return false;
            }

            if (_repo.IsUsernameOrEmailExists(admin.Username, admin.Email))
            {
                errorMessage = "Username or Email already exists.";
                return false;
            }

            _repo.AddAdmin(admin);
            return true;
        }

        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
    }
}
