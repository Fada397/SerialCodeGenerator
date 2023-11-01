using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CertSerial
{
    internal class ClsSerial
    {

        public DataTable tblserial = new DataTable();
        public void selectserial()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("CertSerial_main.xml");
            if (ds.Tables.Count > 0) { tblserial = ds.Tables[0]; }
        }





        //Insert register
        public void serialinsert(string TraineeName, string TrainingType, string serialNo, string Trainingdate, string yr, string number)
        {
            //count all trainings to set auto ID
            DataSet ds = new DataSet();
            ds.ReadXml("CertSerial_main.xml");

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
            xmlregDoc.Load("CertSerial_main.xml");
            XmlElement ParentElement = xmlregDoc.CreateElement("serial");

            XmlElement ID = xmlregDoc.CreateElement("ID");
            ID.InnerText = countid;


            XmlElement traintype = xmlregDoc.CreateElement("TrainingType");
            traintype.InnerText = TrainingType;


            XmlElement trainNam = xmlregDoc.CreateElement("TraineeName");
            trainNam.InnerText = TraineeName;

           


            XmlElement serNo = xmlregDoc.CreateElement("serialNo");
            serNo.InnerText = serialNo;

            XmlElement Traindate = xmlregDoc.CreateElement("Trainingdate");
            Traindate.InnerText = Trainingdate;

            XmlElement trainyr = xmlregDoc.CreateElement("TrainYear");
            trainyr.InnerText = yr;

            XmlElement trainnumber  = xmlregDoc.CreateElement("Trainnumber");
            trainnumber.InnerText = number;


            ParentElement.AppendChild(ID);
            ParentElement.AppendChild(trainNam);
            ParentElement.AppendChild(traintype);
            ParentElement.AppendChild(serNo);
            ParentElement.AppendChild(Traindate);
            ParentElement.AppendChild(trainyr);
            ParentElement.AppendChild(trainnumber);


            xmlregDoc.DocumentElement.AppendChild(ParentElement);
            xmlregDoc.Save("CertSerial_main.xml");
        }










    }
}
