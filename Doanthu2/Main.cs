using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SqlClient;


namespace Doanthu2
{
    public partial class Main : Form
    {
        Capture _camera;
        private OleDbConnection Connection = new OleDbConnection();
        string getid, getid1, id_in, id_out,idnumber;
        int dem, dem1;

        public Main()
        {
            InitializeComponent();
            Connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CSDL.accdb";
        }
        FolderBrowserDialog fd;

        private void Form1_Load(object sender, EventArgs e)
        {
            #region COMPORT
            try
            {
                serialPort2.Open();
                serialPort3.Open();
                serialPort1.Open();
                MessageBox.Show("All COM PORT is ready !!!", "Nottification", MessageBoxButtons.OK);
            }
            catch 
            {
                MessageBox.Show("Error to connect COM PORT !!!", "Nottification", MessageBoxButtons.OK);
            }
            #endregion

            #region CAMERA
            if (_camera == null)
            {
                _camera = new Capture(0);
                _camera.ImageGrabbed += _camera_ImageGrabbed;
                _camera.Start();
            }
            #endregion

            #region CSDL
            Connection.Open();
            const int NumberColumn = 7;
            OleDbCommand command = new OleDbCommand();
            command.Connection = Connection;
            string query = " select * from Table1";
            command.CommandText = query;
            int[] width_col = new int[NumberColumn] { 50, 150, 150, 120, 100, 100, 150 };
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Connection.Close();
            #endregion

            id_in = "";
            id_out = "";
                 
        }
        private void loadData()
        {
            DataTable my_data = new DataTable();
            my_data.Load(Program.Database.SelectSQL("SELECT * FROM Table1"));
            dataGridView1.DataSource = my_data;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (Exist(id_in) == false)
            {
                String sql = "insert into Table1 (ID, LicenseNumber, Name) values ('" + txtID.Text + "','" + txtLicense.Text + "','" + txtName.Text + "')";
                OleDbDataReader reader = Program.Database.SelectSQL(sql);
                loadData();
                txtName.Text = "";
                txtLicense.Text = "";
                txtID.Text = "";
            } else
            {
                MessageBox.Show("ID already exists", "Error", MessageBoxButtons.OK);
           }    
        }
                
        private void btnrst_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtLicense.Text = "";
            txtName.Text = "";
            loadData();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
            
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
                id_in = txtID.Text;
                txtName.Text = "";
                txtLicense.Text = "";
                if (Exist(id_in))
                
                {
                    serialPort1.Write("1");
                    
                    string filename = @"C:\Users\leeng\OneDrive\Documents\PBL4\Doanthu2\bin\Debug\Photo\" + id_in + ".png";
                    pic_in.Image.Save(filename, ImageFormat.Png);
                    pic_out.Image = new Bitmap(Application.StartupPath + "\\Photo\\" + id_in + ".png");

                    DataTable dtTable = new DataTable();
                    dtTable.Load(Program.Database.SelectSQL("SELECT * FROM Table1"));
                    string infCheck = "ID='" + id_in + "' ";  // Lấy index của hàng chứa
                    DataRow drow = dtTable.Select(infCheck)[0]; //  thông tin ID = id thẻ từ 
                    int tempIndex = dtTable.Rows.IndexOf(drow);
                    txtLicense.Text = dataGridView1.Rows[tempIndex].Cells["LicenseNumber"].Value.ToString();
                    txtName.Text = dataGridView1.Rows[tempIndex].Cells["Name"].Value.ToString();
                    idnumber = dataGridView1.Rows[tempIndex].Cells["STT"].Value.ToString();

                    string DayTime = DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"); // dd/MM/yyyy hh:mm:ss
                    String sql = "Update Table1 Set Timein = '" + DayTime + "', Timeout = '" + " " + "' where (STT = " + idnumber + " )";
                    Program.Database.UpdateSQL(sql);
                    loadData();
                }
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
                id_out = getid1.TrimStart('');
                txtIDout.Text = id_out;
                
                if (Exist(id_out))
                {
                    serialPort1.Write("2");
                    
                    pic_out.Image = new Bitmap(Application.StartupPath + "\\Photo\\" + id_out + ".png");
                    

                    DataTable dtTable = new DataTable();
                    dtTable.Load(Program.Database.SelectSQL("SELECT * FROM Table1"));
                    string infCheck = "ID='" + id_out + "' ";  // Lấy index của hàng chứa
                    DataRow drow = dtTable.Select(infCheck)[0]; //  thông tin ID = id thẻ từ 
                    int tempIndex = dtTable.Rows.IndexOf(drow);
                    txtLicenseout.Text = dataGridView1.Rows[tempIndex].Cells["LicenseNumber"].Value.ToString();
                    txtName_out.Text = dataGridView1.Rows[tempIndex].Cells["Name"].Value.ToString();
                    
                    txtTimein.Text = dataGridView1.Rows[tempIndex].Cells["Timein"].Value.ToString();
                    string number = dataGridView1.Rows[tempIndex].Cells["STT"].Value.ToString();

                    string DayTime = DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"); // dd/MM/yyyy hh:mm:ss
                    String sql = "Update Table1 Set Timeout = '" + DayTime + "' where (STT = " + number + " )";
                    Program.Database.UpdateSQL(sql);
                    loadData();

                    txtTimeout.Text = dataGridView1.Rows[tempIndex].Cells["Timeout"].Value.ToString();

                }
                else
                {
                    MessageBox.Show("Input card ID", "Error", MessageBoxButtons.OK);
                }    
            }
            
            
        }
        #endregion

        #region CONTROL
        private void btnon_in_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
        }

        private void btnoff_in_Click(object sender, EventArgs e)
        {
            serialPort1.Write("3");
        }
                
        private void btnon_out_Click(object sender, EventArgs e)
        {
            serialPort1.Write("2");
        }

        private void btnoff_out_Click(object sender, EventArgs e)
        {
            serialPort1.Write("4");
        }
        #endregion

        #region CONTROL DATA
        private void btnfile_Click(object sender, EventArgs e)
        {
            fd = new FolderBrowserDialog();
            fd.ShowDialog();
        }

        private void btnseach_Click(object sender, EventArgs e)
        {
            int count = 0;
            Connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = Connection;
            command.CommandText = "select *from Table1 where LicenseNumber = '" + txtseach.Text + "'";
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
            command.CommandText = "delete from Table1 where LicenseNumber = '" + txtseach.Text + "'";
            command.ExecuteNonQuery();
            MessageBox.Show("Deleted");
            Connection.Close();
            loadData();
        }

        
        private void btnupdate_Click(object sender, EventArgs e)
        {
            String sql = "Update Table1 Set LicenseNumber = '" + txtLicense.Text + "', Name = '" + txtName.Text + "',ID = '" +txtID.Text+ "' where (STT = " + idnumber + " )";
            Program.Database.UpdateSQL(sql);
            loadData();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            txtID.Text = dataGridView1.Rows[row].Cells["ID"].FormattedValue.ToString();
            txtLicense.Text = dataGridView1.Rows[row].Cells["LicenseNumber"].FormattedValue.ToString();
            txtName.Text = dataGridView1.Rows[row].Cells["Name"].FormattedValue.ToString();
            idnumber = dataGridView1.Rows[row].Cells["STT"].FormattedValue.ToString();
        }

        #endregion

        #region CAMERA
        void _camera_ImageGrabbed(object sender, EventArgs e)
        {
            Mat frame = new Mat();
            _camera.Retrieve(frame);
            pic_in.Image = frame.ToImage<Bgr, byte>().Bitmap;
        }
        private void btncap_Click(object sender, EventArgs e)
        {
            //string DayTime = DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss"); // dd/MM/yyyy hh:mm:ss
            string filename = @"C:\Users\leeng\OneDrive\Documents\PBL4\Doanthu2\bin\Debug\Photo\" + id_in + ".png";
            pic_in.Image.Save(filename, ImageFormat.Png);
            
        }
        #endregion

        #region CHECK ID
        private bool Exist(string strUid)
        {
            string sql = "SELECT COUNT(*) from Table1 where (ID = '" + strUid + "' )";
            if (Program.Database.CheckExist(sql) != 0)
            {
                return true;
                
            }
            else return false;
        }
        #endregion

        
    }
}
