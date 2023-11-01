using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertSerial
{
    public partial class Frmaddserial : Form
    {
        public Frmaddserial()
        {
            InitializeComponent();
            alltrain();
        }


       



        DataTable dtlog;
        public void alltrain()
        {
           
            ClsTraining slt = new ClsTraining();
            slt.selecttraining();
            dtlog = slt.tbltraining.Copy();

            if (dtlog.Rows.Count != 0)
            {
                this.Cbxtraintype.DataSource = dtlog;
                this.Cbxtraintype.DisplayMember = "Description";
                this.Cbxtraintype.ValueMember = "Code";
            }

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            instrain();




            //referesh orderss in all oreders
            Frmmain form = Application.OpenForms.OfType<Frmmain>().FirstOrDefault();
            if (form != null)
            {
                form.allser();
                form.filtersearch();

            }

        }









        DataTable dtallser;  //Get all serial
        public void allser()
        {
            ClsSerial slt = new ClsSerial();
            slt.selectserial();
            dtallser = slt.tblserial.Copy();
        }


        public void instrain()
        {
            try
            {




                //capitalize first letter of each word    
                string traineenam = (CultureInfo.CurrentCulture.TextInfo.ToTitleCase(this.TbxtraineeName.Text.Trim().ToLower())).ToString();
           
            string traindcode = this.Cbxtraintype.SelectedValue.ToString();
            string traintyp = this.Cbxtraintype.Text.ToString();
            string trainDate = DtmTraindate.Value.ToString("MMM.dd, yyyy");

            string trainyr = DtmTraindate.Value.ToString("yyyy");



            allser(); //Get max number for the year
            DataTable dts = new DataTable();
            int maxnumyr;
            if (dtallser.Rows.Count > 0)
            {

                DataView filterallser = new DataView(dtallser);
                filterallser.RowFilter = "TrainYear = '" + trainyr + "'";
                dts = filterallser.ToTable();



                    //DataView filterallsersss = new DataView(dtallser);
                    //DataTable dtsdstnct = new DataTable();
                    //dtsdstnct = filterallsersss.ToTable("DistinctTable", true, "TrainYear");

                    //MessageBox.Show(dtsdstnct.Rows.Count.ToString());



                    if (dts.Rows.Count > 0) { 
                maxnumyr = Convert.ToInt32(dts.Compute("max([Trainnumber])", string.Empty)); ;
                maxnumyr += 1;
                }
                else { maxnumyr = 1; }


            }
            else { maxnumyr = 1;}




                string snyr = (DateTime.Parse(trainDate).ToString("yy"));
            string mnt = (DateTime.Parse(trainDate).Month).ToString("D2");


            string numb = maxnumyr.ToString("D4");

            string sn = tbxinitial.Text.Trim() + traindcode + snyr + mnt + numb;


          
            if (traineenam != "" )

            {

             
                ClsSerial ser_insert = new ClsSerial();
                ser_insert.serialinsert(traineenam, traintyp, sn, trainDate,trainyr,numb);


               
                MessageBox.Show("Saved");
                TbxtraineeName.Clear();
            }
            else
            { MessageBox.Show("Error, Check Data Entry"); }







            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }

        }

        private void Frmaddserial_Load(object sender, EventArgs e)
        {

        }
    }
}
