using System.Collections.Generic;
using System.Data;
using System.Xml;

namespace InariFox.TdmlLib
{
    public class TdmlLib
    {
        private XmlDocument tdml;
        private string linename;
        private Dictionary<string, string> properties;
        private DataTable station;
        private Dictionary<string, string> traintype;

        public XmlDocument Tdml
        {
            protected set { this.tdml = value; }
            get { return tdml; }
        }
        public string Linename
        {
            protected set { this.linename = value; }
            get { return linename; }
        }
        public Dictionary<string, string> Properties
        {
            protected set { this.properties = value; }
            get { return properties; }
        }
        public DataTable Station
        {
            protected set { this.station = value; }
            get { return station; }
        }
        public Dictionary<string, string> Traintype
        {
            protected set { this.traintype = value; }
            get { return traintype; }
        }
    }
}
