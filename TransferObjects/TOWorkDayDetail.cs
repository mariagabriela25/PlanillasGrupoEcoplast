using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjects
{
    public class TOWorkDayDetail
    {
        public int Code { get; set; }
        public double OrdinaryHours { get; set; }
        public double TotalHours { get; set; }
        public DateTime Date { get; set; }
        public int WeekCode { get; set; }

        public string Note { get; set; }
        public Boolean State { get; set; }

    }
}
