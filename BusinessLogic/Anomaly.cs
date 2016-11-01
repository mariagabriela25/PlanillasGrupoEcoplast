using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Anomaly
    {
        public DateTime currentDay;
        public int code;
        public Employee emp;
        public bool type;

        public Anomaly(DateTime currentday, int code, bool type)
        {
            this.currentDay = currentday;
            this.code = code;
            this.type = type;
            Employee emp = new Employee();
            emp.Code = this.code;
            emp = emp.GetEmployee();
            this.emp = emp;
        }

    }

}
