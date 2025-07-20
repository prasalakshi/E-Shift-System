using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Models
{
    public class Load
    {
        public int LoadID { get; set; }
        public int JobID { get; set; }
        public string LoadDescription { get; set; }
        public int? AssignedTransportUnitID { get; set; }
        public string Status { get; set; }
        public DateTime? PickupDate { get; set; }
        public DateTime? DeliveredDate { get; set; }
    }
}
