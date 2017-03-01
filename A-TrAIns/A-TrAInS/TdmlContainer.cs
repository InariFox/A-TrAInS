using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using InariFox.TdmlParser;

namespace A_TrAInS
{
    class TdmlContainer
    {
        XmlDocument data;
        TdmlParser tp;

        public TdmlContainer()
        {
            data = new XmlDocument();
        }

        public void load(string path)
        {
            data.Load(path);
            tp.parse(data);
        }

        public void load(XmlDocument xml)
        {
            data.LoadXml(xml.OuterXml);
            tp.parse(data);
        }

        public string getTdmlToString()
        {
            return data.OuterXml;
        }
    }
}
