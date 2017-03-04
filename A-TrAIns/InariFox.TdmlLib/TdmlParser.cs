using System;
using System.Collections.Generic;
using System.Data;
using System.Xml;

namespace InariFox.TdmlLib
{
    public class TdmlParser : TdmlLib
    {
        string message;
        public string Message
        {
            private set { message = value; }
            get { return message; }
        }

        public TdmlParser()
        {
            Linename = "";
            Tdml = new XmlDocument();
            Properties = new Dictionary<string, string>();
            Station = new DataTable();
            Traintype = new Dictionary<string, string>();
            Message = "";
        }

        public bool parse(XmlDocument tdml)
        {
            bool result = false;

            try {
                XmlNode root = tdml.SelectSingleNode("//line");

                // 路線名
                XmlElement ln = (XmlElement)root;
                Linename = ln.GetAttribute("name");

                // 駅リスト
                //XmlNodeList st = tdml.SelectNodes("");

                result = true;
            }
            catch(Exception ex)
            {
                Message = ex.Message;
            }

            return result;
        }
    }
}
