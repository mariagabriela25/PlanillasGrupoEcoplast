using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using TransferObjects;

namespace BusinessLogic
{
    public class WorkDayDetail
    {
        public int Code { get; set; }
        public double OrdinaryHours { get; set; }
        public double TotalHours { get; set; }
        public DateTime Date { get; set; }
        public int WeekCode { get; set; }
        public string Note { get; set; }
        public Boolean State { get; set; }

        public WorkDayDetail(int code, double ordinaryhours, double totalhours, DateTime date, int weekcode, string note, Boolean state)
        {
            this.Code = code;
            this.OrdinaryHours = ordinaryhours;
            this.TotalHours = totalhours;
            this.Date = date;
            this.WeekCode = weekcode;
            this.Note = note;
            this.State = state;
        }

        public WorkDayDetail() {}

        public Boolean AddWorkDay()
        {
            TOWorkDayDetail workday = new TOWorkDayDetail();
            workday.Code = this.Code;
            workday.OrdinaryHours = this.OrdinaryHours;
            workday.TotalHours = this.TotalHours;
            workday.Date = this.Date;
            workday.WeekCode = this.WeekCode;
            workday.Note = this.Note;
            workday.State = this.State;

            return new DAOWorkDay().AddWorkDayDetail(workday);
        }

    }
}
