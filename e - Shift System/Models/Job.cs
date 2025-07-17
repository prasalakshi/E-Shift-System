using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Models
{
    public class Job
    {
        public int JobID { get; set; }
        public int CustomerID { get; set; }
        public string StartLocation { get; set; }
        public string Destination { get; set; } = string.Empty; // Default value added
        public DateTime JobDate { get; set; }
        public string Status { get; set; } = string.Empty; // Default value added

        public string ShiftingItems { get; set; }
    }
}
