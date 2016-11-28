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
        public double OrdinaryHours { get; set; }
        public TODepartment depart { get; set; }

        public TOSchedule()
        {
        }
    }

}
