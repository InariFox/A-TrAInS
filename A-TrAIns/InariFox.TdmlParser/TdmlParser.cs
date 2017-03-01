using System.Collections.Generic;
using System.Data;
using System.Xml;

namespace InariFox.TdmlParser
{
    public class TdmlParser
    {
        XmlDocument xml;
        Dictionary<string, string> properties;
        DataTable stations;
        DataTable trintypes;

        public TdmlParser()
        {
            xml = new XmlDocument();
            properties = new Dictionary<string, string>();
            stations = new DataTable();
            trintypes = new DataTable();
        }

        public bool parse(XmlDocument tdml)
        {
            bool result = false;

            return result;
        }
    }
}
