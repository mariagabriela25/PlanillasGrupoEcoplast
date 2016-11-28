using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BusinessLogic
{
    public class AnomaliesManager
    {

        XmlDocument xdoc = new XmlDocument();

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
