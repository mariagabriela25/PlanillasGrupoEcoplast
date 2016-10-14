using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjects
{
    public class TODepartment
    {
        public int Code { get; set; }
        public String Name { get; set; }
        public List<TOSchedule> ScheduleList { get; set; }
    }
}
