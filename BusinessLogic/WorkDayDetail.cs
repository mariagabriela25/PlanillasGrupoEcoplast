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
        public Boolean State { get; set; }

        public WorkDayDetail(int code, int ordinaryhours, int totalhours, DateTime date, string note, Boolean state)
        {
            this.Code = code;
            this.OrdinaryHours = ordinaryhours;
            this.TotalHours = totalhours;
            this.Date = date;
            this.Note = note;
            this.State = state;
        }

    }
}
