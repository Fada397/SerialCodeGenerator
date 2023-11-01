using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CertSerial
{
    internal class ClsTraining


    {

        public DataTable tbltraining = new DataTable();
        public void selecttraining()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("CertSerial.xml");
            if (ds.Tables.Count > 0) { tbltraining = ds.Tables[0]; }
        }





        //Insert register
        public void tbltraininginsert(string description, string code)
        {
            //count all trainings to set auto ID
            DataSet ds = new DataSet();
            ds.ReadXml("CertSerial.xml");

            string countid;
            if (ds.Tables.Count == 0) { countid = "0"; }
            else
            {
                DataTable dt = new DataTable();
                dt = ds.Tables[0];

                int ct = Convert.ToInt32(dt.Compute("max([ID])", string.Empty));
                countid = (ct + 1).ToString();
            }

            XmlDocument xmlregDoc = new XmlDocument();
            xmlregDoc.Load("CertSerial.xml");
            XmlElement ParentElement = xmlregDoc.CreateElement("train");

            XmlElement ID = xmlregDoc.CreateElement("ID");
            ID.InnerText = countid;

            XmlElement des = xmlregDoc.CreateElement("Description");
            des.InnerText = description;

            XmlElement Cod = xmlregDoc.CreateElement("Code");
            Cod.InnerText = code;


            ParentElement.AppendChild(ID);
            ParentElement.AppendChild(des);
            ParentElement.AppendChild(Cod);

            xmlregDoc.DocumentElement.AppendChild(ParentElement);
            xmlregDoc.Save("CertSerial.xml");
        }
    }
}
