using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class LaboredDay
    {
        public List<Check> checkedChecks { get; set; }
        public int employee { get; set; }
        public int ordinaryhours { get; set; }

        public LaboredDay(int employee, int ordinaryhours)
        {
            checkedChecks = new List<Check>();
            this.employee = employee;
            this.ordinaryhours = ordinaryhours;
        }
        
        public void AddCheckedCheck(Check newC)
        {
            checkedChecks.Add(newC);
        }
        
    }
}
