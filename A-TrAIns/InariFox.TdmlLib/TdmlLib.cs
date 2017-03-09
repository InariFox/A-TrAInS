using System;
using System.Collections.Generic;
using System.Data;
using System.Xml;

namespace InariFox.TdmlLib
{
    public class TdmlLib : IDisposable
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

        public TdmlLib()
        {
            Linename = "";
            Tdml = new XmlDocument();
            Properties = new Dictionary<string, string>();
            Station = new DataTable();
            Traintype = new Dictionary<string, string>();

            Station.Columns.Add("name");
            Station.Columns.Add("type");
            Station.Columns.Add("visible");
        }

        ~TdmlLib()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // 管理（managed）リソースの破棄処理をここに記述します。 
                Linename = null;

                //Tdml.InnerXml = null;
                Tdml = null;

                Properties.Clear();
                Properties = null;

                Station.Clear();
                Station = null;

                Traintype.Clear();
                Traintype = null;

            }

            // 非管理（unmanaged）リソースの破棄処理をここに記述します。
        }
    }
}
