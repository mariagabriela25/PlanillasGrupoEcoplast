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
        public int Day { get; set; }
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

        public Boolean UpdateWorkDay(int dbCode)
        {
            TOWorkDayDetail workday = new TOWorkDayDetail();
            workday.CodeEmployee = this.CodeEmployee;
            workday.OrdinaryHours = this.OrdinaryHours;
            workday.TotalHours = this.TotalHours;
            workday.Date = this.Date;
            workday.WeekCode = this.WeekCode;
            workday.Note = this.Note;
            workday.State = this.State;

            return new DAOWorkDay().UpdateWorkDayDetail(workday, dbCode);
        }

        public void get_WorkDayUser(int code_Employee, int codeWeek)
        {
            TOWorkDayDetail toe = new TOWorkDayDetail();
            toe.CodeEmployee = code_Employee;
            toe.WeekCode = codeWeek;
            DAOWorkDay daow = new DAOWorkDay();
            this.TotalHours = daow.getWorkDay(toe).TotalHours;
            
        }

        public List<WorkDayDetail> getWeeks(int codEmpl, int codWeek)
        {
            List<WorkDayDetail> list = new List<WorkDayDetail>();
            DAOWorkDay dao = new DAOWorkDay();

            List<TOWorkDayDetail> tos = dao.getWorkedWeeks(codEmpl, codWeek);

            foreach(TOWorkDayDetail to in tos)
            {
                WorkDayDetail workDay = new WorkDayDetail();
                workDay.ID = to.ID;
                workDay.Date = to.Date;
                workDay.Day = to.Day;
                workDay.TotalHours = to.TotalHours;
                workDay.Note = to.Note;
                list.Add(workDay);
            }

            return list;
        }
    }
}
