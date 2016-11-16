using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class ConfigManager
    {
        XmlDocument xdoc = new XmlDocument();

        public int GetValue(string name)
        {
            xdoc.Load("ConfigFile.xml");
            XmlNodeList p = xdoc.GetElementsByTagName("Parameters");
            XmlNodeList param = ((XmlElement)p[0]).GetElementsByTagName("Parameter");

            foreach(XmlElement x in param)
            {
                if (x.GetAttribute("Name").Equals(name))
                {
                    return Int32.Parse(x.InnerText);
                }
         
            }
            return 0;
        }

        public void SetValue(string name, int value)
        {
            xdoc.Load("ConfigFile.xml");
            XmlNodeList p = xdoc.GetElementsByTagName("Parameters");
            XmlNodeList param = ((XmlElement)p[0]).GetElementsByTagName("Parameter");

            foreach (XmlElement x in param)
            {
                if (x.GetAttribute("Name").Equals(name))
                {
                    x.InnerText = value.ToString();
                }

            }

            xdoc.Save("ConfigFile.xml");
        }
    }
}
