using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;
using DataAccess;

namespace BusinessLogic
{
    public class WorkWeekDetail
    {
        public int Code { get; set; }
        public double CCSSHours { get; set; }
        public double TotalHours { get; set; }
        public double ExtraHours { get; set; }
        public int EmployeeCode { get; set; }
        public int WeekNumber { get; set; }
        public int Year { get; set; }

        public WorkWeekDetail(int Code, double CCSSHours, double TotalHours, double ExtraHours, int EmployeeCode, int WeekNumber, int Year)
        {
            this.Code = Code;
            this.CCSSHours = CCSSHours;
            this.TotalHours = TotalHours;
            this.ExtraHours = ExtraHours;
            this.EmployeeCode = EmployeeCode;
            this.WeekNumber = WeekNumber;
            this.Year = Year;
        }

        public WorkWeekDetail()
        {
        }

        public Boolean SaveWeekReport()
        {
            TOWorkWeekDetail twd = new TOWorkWeekDetail();
            twd.Code = Code;
            twd.CCSSHours = CCSSHours;
            twd.TotalHours = TotalHours;
            twd.ExtraHours = ExtraHours;
            twd.EmployeeCode = EmployeeCode;
            twd.WeekNumber = WeekNumber;
            twd.Year = Year;

            DAOWeekDetail dwd = new DAOWeekDetail();
            return dwd.SaveWeekDetail(twd);
        }
    }

    

}
