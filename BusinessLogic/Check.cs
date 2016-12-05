
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using TransferObjects;

namespace BusinessLogic
{
    /// <summary>
    /// Class Check. Represents a check in the system.
    /// </summary>
    public class Check
    {
        /// <summary>
        /// Identifier of the check
        /// </summary>
        /// <value> int identifier </value>
        public int ID { get; set; }
        /// <summary>
        /// Gets or sets the check time.
        /// </summary>
        /// <value>The check time.</value>
        public DateTime CheckTime { get; set; }
        /// <summary>
        /// Gets or sets the type of the check.
        /// </summary>
        /// <value>The type of the check.</value>
        public string CheckType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Check"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="checktime">The checktime.</param>
        /// <param name="checktype">The checktype.</param>
        public Check(int id, DateTime checktime, string checktype)
        {
            this.ID = id;
            this.CheckTime = checktime;
            this.CheckType = checktype;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Check" /> class.
        /// </summary>
        public Check(){}

        /// <summary>
        /// Gets the checks in a determined set of time
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Inicio">The begin of the interval.</param>
        /// <param name="Fin">The end of the interval.</param>
        /// <returns> List<Check> a list of checks</returns>
        public List<Check> GetChecks(int ID, DateTime Inicio, DateTime Fin)
        {
            List<TOCheck> list = new DAOAnviz().GetChecks(ID, Inicio, Fin);
            List<Check> checks = new List<Check>();

            if (list != null)
            {
                foreach (TOCheck c in list)
                {
                    checks.Add(new Check(c.ID, c.CheckTime, c.CheckType));
                }
                return checks;
            } else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the checks with rests.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Inicio">The begin of the interval.</param>
        /// <param name="Fin">The end of the interval.</param>
        /// <returns>List<Check> a list of checks with their rests</returns>
        public List<Check> GetChecksWithRests(int ID, DateTime Inicio, DateTime Fin)
        {
            List<TOCheck> list = new DAOAnviz().GetChecksWithRests(ID, Inicio, Fin);
            List<Check> checks = new List<Check>();

            if (list != null)
            {
                foreach (TOCheck c in list)
                {
                    String cType = c.CheckType;
                    switch (cType)
                    {
                        case "I":
                            cType = "Entrada";
                            break;
                        case "O":
                            cType = "Salida";
                            break;
                        case "2":
                            cType = "DS";
                            break;
                    }
                    checks.Add(new Check(c.ID, c.CheckTime, cType));
                }
                return checks;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// gets Checks by the date.
        /// </summary>
        /// <param name="date">The date of the check</param>
        /// <param name="type">The type of the check</param>
        /// <returns>System.Decimal an DAOAnviz object</returns>
        public decimal checksbyDate(DateTime date, string type)
        {
            return new DAOAnviz().checksbyDate(date, type);

        }
    }
}
