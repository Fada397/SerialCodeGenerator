using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CertSerial
{
    public partial class FrmTraining : Form
    {
        public FrmTraining()
        {
            InitializeComponent();

            alltrain();
        }

        private void btnaddtraining_Click(object sender, EventArgs e)
        {
            instrain();
           
            //Refresh Frmmain Cbxtraintype
            Frmmain form = Application.OpenForms.OfType<Frmmain>().FirstOrDefault();
            if (form != null)
            {
                
                form.alltrain();

            }

        }


       
        public void instrain()
        {
      //try
      //      { 

           
            //capitalize first letter of each word    
           string description = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(this.Tbxtraindescription.Text.Trim().ToLower());
            string cd =this.Tbxtraincode.Text.Trim().ToUpper();

            if ((description != "") && ( cd != ""))

            {

                int count =0;

               
                if(dtlog.Rows.Count > 0) { 
                    //filter datatable
                    DataRow[] row = dtlog.Select("Description ='" + description + "' or Code = '" + cd + "'");
                count = row.Count();
                }


                if (count == 0) 
                    {
                        ClsTraining train_insert = new ClsTraining();
                        train_insert.tbltraininginsert(description, cd);
                      
                        Tbxtraindescription.Clear();
                        Tbxtraincode.Clear();

                        alltrain();

                    }
                else
                { MessageBox.Show("Data already exist"); }

            }


            else
            { MessageBox.Show("Error, Check Data Entry"); }

        //    }
        //    catch (Exception e) { MessageBox.Show(e.ToString()); }

        }

       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try { 


            if (GrdTraining.CurrentCell != null)
            {
                

                //Restore Stock Quantity or Not
                string message1 = "Confirm To Delete";
                string title1 = "Delete";
                MessageBoxButtons buttons1 = MessageBoxButtons.YesNo;
                DialogResult result1 = MessageBox.Show(message1, title1, buttons1, MessageBoxIcon.Question);
                if (result1 == DialogResult.Yes)
                {


                    int ind = Convert.ToInt32(GrdTraining.CurrentCell.RowIndex.ToString());
                   
                    dtlog.Rows.RemoveAt(ind);
 
                    DataTable dats = new DataTable();
                    dats = dtlog.Copy();

                   
                    dats.TableName = "train";
                    dats.WriteXml("CertSerial.xml");

                        GrdTraining.AutoGenerateColumns = false;
                    GrdTraining.DataSource = dtlog;


                       alltrain();




                        //Refresh Frmmain Cbxtraintype
                        Frmmain form = Application.OpenForms.OfType<Frmmain>().FirstOrDefault();
                        if (form != null)
                        {

                            form.alltrain();

                        }

                    }


            }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }




        DataTable dtlog;
        public void alltrain()
        {
            ClsTraining slt = new ClsTraining();
            slt.selecttraining();
            dtlog = slt.tbltraining.Copy();


            GrdTraining.AutoGenerateColumns = false;
            GrdTraining.DataSource = dtlog;

        }

        private void GrdTraining_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
