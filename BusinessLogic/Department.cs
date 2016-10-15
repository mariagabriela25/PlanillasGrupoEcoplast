using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Department
    {
        public int Code { get; set; }
        public String Name { get; set; }
        public List<Schedule> ScheduleList { get; set; }

        public Department(int code, string name)
        {
            this.Code = code;
            this.Name = name;
        }
    }
}
