using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactTracingApp
{
    public partial class submitBtn : Form
    { 


        public submitBtn()
        {
            InitializeComponent();
        }
        private void sbmtBtn_Click(object sender, EventArgs e)
        {

            SubInfo(nmBx.Text, timeBx.Text, addressBx.Text, emailBx.Text, long.Parse(numBx.Text), float.Parse(tempBx.Text),
                        sympBx.Text);

            

            if (privacyCB.Checked)
            {
                MessageBox.Show("Thank you for answering! Have a good day!");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Please go back and check the box. Have a good day!");
                
            }

        }

        private void SubInfo(string nmBx, string timeBx, string addressBx, string emailBx, long numBx, float tempBx,
                                string sympBx)
        {
            StreamWriter contactList;

            String dateCrtd = DateTime.Now.ToLongDateString();

            contactList = File.AppendText(dateCrtd);
            contactList.WriteLine(nmBx);
            contactList.WriteLine(timeBx);
            contactList.WriteLine(addressBx);
            contactList.WriteLine(emailBx);
            contactList.WriteLine(numBx.ToString());
            contactList.WriteLine(tempBx.ToString());
            contactList.WriteLine(sympBx);
            contactList.WriteLine("");
            contactList.Close();
        
        }
    }
}