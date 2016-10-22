using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using TransferObjects;

namespace BusinessLogic
{
    public class Check
    {
        public int ID { get; set; }
        public DateTime CheckTime { get; set; }
        public string CheckType { get; set; }

        public Check(int id, DateTime checktime, string checktype)
        {
            this.ID = id;
            this.CheckTime = checktime;
            this.CheckType = checktype;
        }

        public Check(){}

        public List<Check> GetChecks(int ID, DateTime Inicio, DateTime Fin)
        {
            List<TOCheck> list = new DAOAnviz().GetChecks(ID, Inicio, Fin);
            List<Check> checks = new List<Check>();

            foreach(TOCheck c in  list)
            {
                checks.Add(new Check(c.ID, c.CheckTime, c.CheckType));
            }
            return checks;   
        }
    }
}
