using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doanthu2
{
    public partial class Main : Form
    {
        string getid, getid1;
        int dem, dem1;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                serialPort2.Open();
                serialPort3.Open();
            }
            catch { }

        }
        private void btncnt_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            String sql = "insert into Table1 (ID, LicenseNumber, Name) values ('" + txtID.Text + "','" + txtLicense.Text + "','" + txtName.Text + "')";
            OleDbDataReader reader = Program.Database.SelectSQL(sql);
        }

        private void btndata_Click(object sender, EventArgs e)
        {
            frmData f = new frmData();
            this.Hide();
            f.ShowDialog();
        }

        private void btnrst_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtLicense.Text = "";
            txtName.Text = "";
        }

        #region RFID IN
        private void serialPort2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            getid = serialPort2.ReadTo("");
            dem = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dem == 1)
            {
                dem = 0;
                txtID.Text = getid.TrimStart('');
            }
        }
                
        #endregion

        #region RFID OUT
        private void serialPort3_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            getid1 = serialPort3.ReadTo("");
            dem1 = 1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (dem1 == 1)
            {
                dem1 = 0;
                txtName_out.Text = getid1.TrimStart('');
            }
        }
        #endregion

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
