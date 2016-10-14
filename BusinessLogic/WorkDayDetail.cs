using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class WorkDayDetail
    {
        public int Code { get; set; }
        public int OrdinaryHours { get; set; }
        public int ExtraHours { get; set; }
        public int TotalHours { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }

    }
}
