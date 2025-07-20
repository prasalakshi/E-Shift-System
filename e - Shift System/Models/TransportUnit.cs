using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e___Shift_System.Models
{
    public class TransportUnit
    {
        public int TransportUnitID { get; set; }
        public int LorryID { get; set; }
        public int DriverID { get; set; }
        public int? AssistantID { get; set; }
        public int ContainerID { get; set; }
        public string Status { get; set; }
    }
}
