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
    public partial class frmData : Form
    {
        private OleDbConnection Connection = new OleDbConnection();
        public frmData()
        {
            InitializeComponent();
            Connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CSDL.accdb";
        }

        private void frmData_Load(object sender, EventArgs e)
        {
            Connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = Connection;
            string query = " select * from Table1";
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Connection.Close();
        }

        private void btnseach_Click(object sender, EventArgs e)
        {
            int count = 0;
            Connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = Connection;
            command.CommandText = "select *from Table1 where LicenseNumber = '" + txtLicense.Text + "'";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;
            Connection.Close();
            if (count == 0)
            {
                MessageBox.Show("No found !!!");
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            Connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = Connection;
            command.CommandText = "delete from Table1 where LicenseNumber = '" + txtLicense.Text + "'";
            command.ExecuteNonQuery();

            MessageBox.Show("Deleted");
            Connection.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = Connection;
            string query = " select * from Table1";
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Connection.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            this.Hide();
            f.ShowDialog();
        }
    }
}
