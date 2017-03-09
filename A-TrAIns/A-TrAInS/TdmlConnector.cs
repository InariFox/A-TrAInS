using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using InariFox.TdmlLib;
using System.Data;

namespace A_TrAInS
{
    class TdmlConnector
    {
        XmlDocument tdml;
        TdmlParser tp;

        public TdmlConnector()
        {
            tdml = new XmlDocument();
            Tp = new TdmlParser();
        }

        public void load(string path)
        {
            tdml.Load(path);
        }

        public void load(XmlDocument xml)
        {
            tdml.LoadXml(xml.OuterXml);
        }

        public bool parse()
        {
            return tp.parse(tdml);
        }

        public TdmlParser Tp
        {
            private set { tp = value; }
            get { return tp; }
        }

        public void empty()
        {
            Tp.Dispose();
            Tp = new TdmlParser();

            tdml = null;
            tdml = new XmlDocument();
        }
    }
}
