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
            Message = "";
        }

        public bool parse(XmlDocument tdml)
        {
            bool result = false;

            try {
                // root取得
                // 路線名
                XmlNode line = tdml.GetElementsByTagName("line")[0];
                XmlElement linename = (XmlElement)line;
                Linename = linename.GetAttribute("name");

                // 駅リスト
                XmlNodeList stations = tdml.GetElementsByTagName("station");
                foreach (XmlNode st in stations)
                {
                    string st_name = st.InnerText;
                    XmlElement type = (XmlElement)st;
                    int st_type;
                    bool parse = int.TryParse(type.GetAttribute("type"), out st_type);
                    if (!parse){ st_type = -1; }

                    DataRow dr = Station.NewRow();
                    dr["name"] = st_name;
                    dr["type"] = (st_type == 0) ? "主要駅" : "一般駅";
                    dr["visible"] = "読み上げる";

                    Station.Rows.Add(dr);
                }
                

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
