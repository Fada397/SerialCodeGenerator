using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;


namespace CertSerial
{
    public partial class Frmmain : Form
    {
        public Frmmain()
        {
            InitializeComponent();
            alltrain();
            allser();
        }





        DataTable dtallser;  //Get all serial
        public void allser()
        {
            ClsSerial slt = new ClsSerial();
            slt.selectserial();
            dtallser = slt.tblserial.Copy();
        }








        private void btnsearch_Click(object sender, EventArgs e)


        {
            filtersearch();

        }

        public void filtersearch()
        {
            //try
            //{

                if (cbxtraintype.SelectedIndex > 0) { filter_specificTraining(); }
                else { filter_AllTraining(); }

            //}
            //catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }








            DataTable filterdtble  = new DataTable();
        public void filter_specificTraining()
        {
            filterdtble.Rows.Clear();
            string date1 = Dtmfrom.Value.ToString("MMM. dd, yyyy");
            string date2 = DteTo.Value.ToString("MMM. dd, yyyy");
            string itm = this.cbxtraintype.GetItemText(cbxtraintype.SelectedItem);

            DataView filter = new DataView(dtallser);


            //check if filter has data
            if (filter.Count > 0)
            {
                filter.RowFilter = "Trainingdate >= #" + date1 + "# AND Trainingdate <= #" + date2 + "# AND TrainingType = '" + itm + "'";
                filterdtble = filter.ToTable();
            }

            GrdSerial.AutoGenerateColumns = false;
            GrdSerial.DataSource = filterdtble;

        }


        public void filter_AllTraining()
        {
            filterdtble.Rows.Clear();


            string date1 = Dtmfrom.Value.ToString("MMM. dd, yyyy");
            string date2 = DteTo.Value.ToString("MMM. dd, yyyy");
           
            DataView filter = new DataView(dtallser);

            //check if filter has data
          if (filter.Count > 0) { 
            filter.RowFilter = "Trainingdate >= #" + date1 + "# AND Trainingdate <= #" + date2 + "# ";
            filterdtble = filter.ToTable();
            }



            GrdSerial.AutoGenerateColumns = false;
            GrdSerial.DataSource = filterdtble;

        }


        DataTable dtlog;
        public void alltrain()
        {
            cbxtraintype.Items.Clear();

            ClsTraining slt = new ClsTraining();
            slt.selecttraining();
            dtlog = slt.tbltraining.Copy();

            cbxtraintype.Items.Add("All");
            if (dtlog.Rows.Count != 0)
            {
                //add row as range
                var rows = dtlog.Rows.Cast<DataRow>();                
                  cbxtraintype.Items.AddRange(rows.Select(x => x.Field<String>("Description")).ToArray()); 

            }
            cbxtraintype.SelectedIndex = 0;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Frmmain_Load(object sender, EventArgs e)
        {

        }

        private void lnkaddserial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frmaddserial f1 = new Frmaddserial();
            f1.Show();
        }

        private void lnkaddtraining_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmTraining f1 = new FrmTraining();
            f1.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {


                if (GrdSerial.CurrentCell != null)
                {


                    //Restore Stock Quantity or Not
                    string message1 = "Confirm To Delete";
                    string title1 = "Delete";
                    MessageBoxButtons buttons1 = MessageBoxButtons.YesNo;
                    DialogResult result1 = MessageBox.Show(message1, title1, buttons1, MessageBoxIcon.Question);
                    if (result1 == DialogResult.Yes)
                    {


                        int ind = Convert.ToInt32(GrdSerial.CurrentCell.RowIndex.ToString());

                        dtallser.Rows.RemoveAt(ind);





                        DataTable dats = new DataTable();
                        dats = dtallser.Copy();


                        dats.TableName = "serial";
                        dats.WriteXml("CertSerial_main.xml");

                        GrdSerial.AutoGenerateColumns = false;
                        GrdSerial.DataSource = dtallser;


                        allser();

                    }


                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }







        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Records";

                try
                {
                    for (int i = 0; i < GrdSerial.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = GrdSerial.Columns[i].HeaderText;
                    }

                    for (int i = 0; i < GrdSerial.Rows.Count; i++)
                    {
                        for (int j = 0; j < GrdSerial.Columns.Count; j++)
                        {
                            if (GrdSerial.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1] = GrdSerial.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                worksheet.Cells[i + 2, j + 1] = "";
                            }
                        }
                    }

                    //Getting the location and file name of the excel to save from user. 
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    saveDialog.FilterIndex = 2;

                    if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        workbook.SaveAs(saveDialog.FileName);
                       // MessageBox.Show("Export Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    app.Quit();
                    workbook = null;
                    worksheet = null;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void lnlbackup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Backup f1 = new Backup();
            f1.Show();
        }
    }
}
