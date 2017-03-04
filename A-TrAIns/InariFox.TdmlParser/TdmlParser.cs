using System;
using System.Collections.Generic;
using System.Data;
using System.Xml;

namespace InariFox.TdmlParser
{
    public class TdmlParser
    {
        string linename;
        XmlDocument tdml;
        Dictionary<string, string> properties;
        DataTable stations;
        DataTable trintypes;

        string message;

        public TdmlParser()
        {
            linename = "";
            tdml = new XmlDocument();
            properties = new Dictionary<string, string>();
            stations = new DataTable();
            trintypes = new DataTable();

            message = "";
        }

        public bool parse(XmlDocument tdml)
        {
            bool result = false;

            try {
                XmlNode root = tdml.SelectSingleNode("line");

                // 路線名
                XmlElement ln = (XmlElement)root;
                linename = ln.GetAttribute("name");

                // 駅リスト
                //XmlNodeList st = tdml.SelectNodes("");

                result = true;
            }
            catch(Exception ex)
            {
                setMessage(ex.Message);
            }

            return result;
        }

        private void setMessage(string mes)
        {
            this.message = mes;
        }

        public string getMessage()
        {
            return message;
        }
    }
}
