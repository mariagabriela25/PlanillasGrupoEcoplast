using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjects
{
    public class TOSchedule
    {
        public string Code { get; set; }
        public DateTime InitialHour { get; set; }
        public DateTime finalHour { get; set; }
        public int OrdinaryHours { get; set; }
        public int ExtraHours { get; set; }
        public int TotalHours { get; set; }
        public List<TORest> RestList { get; set; }

        public TOSchedule(string Code, DateTime InitialHour, DateTime finalHour, int OrdinaryHours, int ExtraHours, int TotalHours, List<TORest> RestList)
        {
            this.Code = Code;
            this.InitialHour = InitialHour;
            this.finalHour = finalHour;
            this.OrdinaryHours = OrdinaryHours;
            this.ExtraHours = ExtraHours;
            this.TotalHours = TotalHours;
            this.RestList = RestList;
        }

        public TOSchedule()
        {
            this.RestList = new List<TORest>();
        }
    }

}
