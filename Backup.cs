using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertSerial
{
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

      
        private void Lnlrestore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try {
              
            string path1 = Path.GetFullPath("CertSerial.xml");
            string path2 = Path.GetFullPath("CertSerial_main.xml");
                string path3 = Path.GetFullPath("CertSeriaLastNo.xml");
                //try
                //{
                string message = "Restore will overwrite current data";
            string title = "Restore";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                //restore
                File.Copy(tbxselcttfolder.Text + "\\CertSerial.xml", path1, true);
                File.Copy(tbxselcttfolder.Text + "\\CertSerial_main.xml", path2, true);
                    File.Copy(tbxselcttfolder.Text + "\\CertSeriaLastNo.xml", path3, true);

                    MessageBox.Show("Restore Successful");

            }
            }catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void Btnbackup_Click(object sender, EventArgs e)
        {
            try
            {

                File.Copy("CertSerial.xml", tbxselcttfolder.Text + "\\CertSerial.xml", true);
                File.Copy("CertSerial_main.xml", tbxselcttfolder.Text + "\\CertSerial_main.xml", true);
                File.Copy("CertSeriaLastNo.xml", tbxselcttfolder.Text + "\\CertSeriaLastNo.xml", true);


                MessageBox.Show("Backup Successful");

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

       
        
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fold = new FolderBrowserDialog();
            DialogResult result = fold.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fold.SelectedPath))
            {
                //string[] files = Directory.GetFiles(fold.SelectedPath);

                tbxselcttfolder.Text = fold.SelectedPath.ToString();
            }
        }
    }
}
