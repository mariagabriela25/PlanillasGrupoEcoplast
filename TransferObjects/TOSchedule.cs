using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjects
{
    public class TOSchedule
    {
        public string Code { get; set; }
        public DateTime InitialHour { get; set; }
        public DateTime finalHour { get; set; }
        public int OrdinaryHours { get; set; }
        public int ExtraHours { get; set; }
        public int TotalHours { get; set; }
        public List<TORest> RestList { get; set; }
    }
}
