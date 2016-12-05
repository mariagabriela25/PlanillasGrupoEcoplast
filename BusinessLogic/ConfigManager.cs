
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace BusinessLogic
{
    /// <summary>
    /// Class ConfigManager. Represents the configurations settings in the system.
    /// </summary>
    public class ConfigManager
    {
        /// <summary>
        /// The xdoc XML documents that stores the configuration settings
        /// </summary>
        XmlDocument xdoc = new XmlDocument();

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Int32.</returns>
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

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
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
