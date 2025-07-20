using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; } = string.Empty; // Default value added
        public string Name { get; set; } = string.Empty; // Default value added
        public string Email { get; set; } = string.Empty; // Default value added
        public string ContactNumber { get; set; } = string.Empty; // Default value added
        public DateTime RegistrationDate { get; set; }
        public string Status { get; set; } = string.Empty; // Default value added
    }
}
