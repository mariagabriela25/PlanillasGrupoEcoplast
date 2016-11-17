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
                list.Add(new Anomaly(Convert.ToDateTime(x.InnerText), Int32.Parse(x.GetAttribute("Code")), true));

            }
            return list;
        }

        public void AddValue(int code, DateTime value)
        {
            xdoc.Load("AnomaliesFile.xml");


            XmlElement newAnomaly = xdoc.CreateElement("Anomaly");

            newAnomaly.InnerText = value.ToString();
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
                if(x.GetAttribute("Code").Equals(code.ToString()) && x.InnerText.Equals(value.ToString()))
                {
                    XmlNode firstElement = xdoc.DocumentElement;
                    firstElement.RemoveChild(x);
                    break;
                }

            }
            xdoc.Save("AnomaliesFile.xml");
        }
    }
}
