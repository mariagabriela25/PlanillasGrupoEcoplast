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
        public int CodeEmployee { get; set; }
        public double OrdinaryHours { get; set; }
        public double TotalHours { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public Boolean State { get; set; }
        public int WeekCode { get; set; }
        public int ID { get; set; }

        public WorkDayDetail(int code, double ordinaryhours, double totalhours, DateTime date, string note, Boolean state, int weekcode, int id)
        {
            this.CodeEmployee = code;
            this.OrdinaryHours = ordinaryhours;
            this.TotalHours = totalhours;
            this.Date = date;
            this.WeekCode = weekcode;
            this.Note = note;
            this.State = state;
            this.ID = id;
        }

        public WorkDayDetail() {}

        public Boolean AddWorkDay()
        {
            TOWorkDayDetail workday = new TOWorkDayDetail();
            workday.CodeEmployee = this.CodeEmployee;
            workday.OrdinaryHours = this.OrdinaryHours;
            workday.TotalHours = this.TotalHours;
            workday.Date = this.Date;
            workday.WeekCode = this.WeekCode;
            workday.Note = this.Note;
            workday.State = this.State;

            return new DAOWorkDay().AddWorkDayDetail(workday);
        }

        public void get_WorkDayUser(int code_Employee, DateTime firstDate, DateTime lastDate)
        {
            TOWorkDayDetail toe = new TOWorkDayDetail(code_Employee, firstDate, lastDate);
            DAOWorkDay daow = new DAOWorkDay();
            this.TotalHours = daow.getWorkDay(toe).TotalHours;
            
        }

    }
}
