using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjects
{
    public class TOWorkWeekDetail
    {
        public int Code { get; set; }
        public double CCSSHours { get; set; }
        public double TotalHours { get; set; }
        public double ExtraHours { get; set; }
        public int EmployeeCode { get; set; }
        public int WeekNumber { get; set; }
        public int Year { get; set; }
    }
}
