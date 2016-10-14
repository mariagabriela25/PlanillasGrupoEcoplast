using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Schedule
    {
        public string Code { get; set; }
        public DateTime InitialHour { get; set; }
        public DateTime finalHour { get; set; }
        public int OrdinaryHours { get; set; }
        public int ExtraHours { get; set; }
        public int TotalHours { get; set; }
        public List<Rest> RestList { get; set; }

        public Schedule (string Code, DateTime InitialHour, DateTime finalHour, int OrdinaryHours, int ExtraHours, int TotalHours)
        {
            this.Code = Code;
            this.InitialHour = InitialHour;
            this.finalHour = finalHour;
            this.OrdinaryHours = OrdinaryHours;
            this.ExtraHours = ExtraHours;
            this.TotalHours = TotalHours;
            this.RestList = new List<Rest>();
    }

        public Schedule ()
        {
        }

        public void AddRest(Rest newRest)
        {
            RestList.Add(newRest);
        }
    }
}
