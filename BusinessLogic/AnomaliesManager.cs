
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BusinessLogic
{
    /// <summary>
    /// Class AnomaliesManager, adds and removes anomalies from the XML Document
    /// </summary>
    public class AnomaliesManager
    {

        /// <summary>
        /// The xdoc: the XML document where the anomalies are stored.
        /// </summary>
        XmlDocument xdoc = new XmlDocument();

        /// <summary>
        /// Gets the values in the XML document
        /// </summary>
        /// <returns>
        /// a list of anomalies
        /// </returns>
        public List<Anomaly> GetValues()
        {
            xdoc.Load("AnomaliesFile.xml");
            XmlNodeList p = xdoc.GetElementsByTagName("Anomalies");
            XmlNodeList param = ((XmlElement)p[0]).GetElementsByTagName("Anomaly");

            List<Anomaly> list = new List<Anomaly>();
            foreach (XmlElement x in param)
            {
                //list.Add(new Anomaly(Convert.ToDateTime(x.InnerText), Int32.Parse(x.GetAttribute("Code")), true));
                String dateString = x.InnerText;
                String[] dateStringVector = dateString.Split(' ');

                String[] onlyDateStringVector = dateStringVector[0].Split('/');
                DateTime tdt = new DateTime(Int32.Parse(onlyDateStringVector[2]), Int32.Parse(onlyDateStringVector[1]), Int32.Parse(onlyDateStringVector[0]));

                list.Add(new Anomaly(tdt, Int32.Parse(x.GetAttribute("Code")), true));

            }
            return list;
        }

        /// <summary>
        /// Adds a new anomalies on the XML Document
        /// </summary>
        /// <param name="code">The code of the employee</param>
        /// <param name="value">The information of the anomalies</param>
        public void AddValue(int code, DateTime value)
        {
            xdoc.Load("AnomaliesFile.xml");


            XmlElement newAnomaly = xdoc.CreateElement("Anomaly");

            String stringValue = value.ToString().ToLower();
            String[] correctStringVector = stringValue.Split(' ');

            String correctString = correctStringVector[0] + " " + correctStringVector[1] + " a. m.";

            newAnomaly.InnerText = correctString;
            newAnomaly.SetAttribute("Code", code.ToString());

            XmlNode firstElement = xdoc.DocumentElement;
            firstElement.InsertAfter(newAnomaly, firstElement.LastChild);

            xdoc.Save("AnomaliesFile.xml");
        }

        /// <summary>
        /// Removes the anomalies of the XML document
        /// </summary>
        /// <param name="code">The code of the employee</param>
        /// <param name="value">The information of the anomalies</param>
        public void RemoveValue(int code, DateTime value)
        {
            xdoc.Load("AnomaliesFile.xml");
            XmlNodeList p = xdoc.GetElementsByTagName("Anomalies");
            XmlNodeList param = ((XmlElement)p[0]).GetElementsByTagName("Anomaly");

            List<Anomaly> list = new List<Anomaly>();
            foreach (XmlElement x in param)
            {
                if(x.GetAttribute("Code").Equals(code.ToString()))
                {

                    String dateString = x.InnerText;
                    String[] dateStringVector = dateString.Split(' ');

                    String[] onlyDateStringVector = dateStringVector[0].Split('/');
                    DateTime tdt = new DateTime(Int32.Parse(onlyDateStringVector[2]), Int32.Parse(onlyDateStringVector[1]), Int32.Parse(onlyDateStringVector[0]));

                    if (tdt.Date == value.Date)
                    {
                        XmlNode firstElement = xdoc.DocumentElement;
                        firstElement.RemoveChild(x);
                        break;
                    }
                }

            }
            xdoc.Save("AnomaliesFile.xml");
        }

        /// <summary>
        /// Specifies if the department received belongs to one of the anomalies  
        /// </summary>
        /// <param name="departmentCode">The department code</param>
        /// <returns> true if the department do belong to one of the anomalies, false if not</returns>
        public Boolean DepartmentInAnomaly(int departmentCode)
        {
            Boolean exists = false;

            List<Anomaly> anomaliesDocument = GetValues();
            List<Employee> employeesDep = new Employee().GetEmployeesDep(departmentCode);

            foreach (Employee employee in employeesDep)
            {
                foreach (Anomaly anomaly in anomaliesDocument)
                {
                    if (anomaly.code == employee.Code)
                    {
                        exists = true;
                        break;
                    }
                }
            }

            return exists;
        }
    }
}
