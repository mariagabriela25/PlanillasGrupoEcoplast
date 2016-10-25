using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjects
{
    public class TOWorkDayDetail
    {
        public int CodeEmployee { get; set; }
        public double OrdinaryHours { get; set; }
        public double TotalHours { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateL { get; set; }
        public string Note { get; set; }
        public Boolean State { get; set; }
        public int WeekCode { get; set; }
        public int ID { get; set;}

        public TOWorkDayDetail()
        {

        }

        public TOWorkDayDetail (int code, DateTime firstDate, DateTime lastDate)
        {
            CodeEmployee = code;
            Date = firstDate;
            DateL = lastDate;
        }

    }
}
