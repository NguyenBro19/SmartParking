
namespace Doanthu2
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer2;
            System.Windows.Forms.Timer timer1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndel = new System.Windows.Forms.Button();
            this.btnseach = new System.Windows.Forms.Button();
            this.txtseach = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnfile = new System.Windows.Forms.Button();
            this.btncap = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnon_in = new System.Windows.Forms.Button();
            this.btnoff_in = new System.Windows.Forms.Button();
            this.btnoff_out = new System.Windows.Forms.Button();
            this.btnon_out = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtLicenseout = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.txtTimein = new System.Windows.Forms.TextBox();
            this.txtIDout = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName_out = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnrst = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pic_out = new System.Windows.Forms.PictureBox();
            this.pic_in = new System.Windows.Forms.PictureBox();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            timer2 = new System.Windows.Forms.Timer(this.components);
            timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_in)).BeginInit();
            this.SuspendLayout();
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 1000;
            timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(349, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(541, 71);
            this.label4.TabIndex = 20;
            this.label4.Text = "SMART PARKING";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(12, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(112, 93);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.btndel);
            this.groupBox1.Controls.Add(this.btnseach);
            this.groupBox1.Controls.Add(this.txtseach);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnexit);
            this.groupBox1.Controls.Add(this.btnfile);
            this.groupBox1.Controls.Add(this.btncap);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.pic_out);
            this.groupBox1.Controls.Add(this.pic_in);
            this.groupBox1.Location = new System.Drawing.Point(2, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1607, 755);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(1470, 518);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(120, 35);
            this.btndel.TabIndex = 18;
            this.btndel.Text = "DELETE";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnseach
            // 
            this.btnseach.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnseach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseach.Location = new System.Drawing.Point(1470, 468);
            this.btnseach.Name = "btnseach";
            this.btnseach.Size = new System.Drawing.Size(119, 38);
            this.btnseach.TabIndex = 17;
            this.btnseach.Text = "SEACH";
            this.btnseach.UseVisualStyleBackColor = false;
            this.btnseach.Click += new System.EventHandler(this.btnseach_Click);
            // 
            // txtseach
            // 
            this.txtseach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtseach.Location = new System.Drawing.Point(1470, 413);
            this.txtseach.Multiline = true;
            this.txtseach.Name = "txtseach";
            this.txtseach.Size = new System.Drawing.Size(120, 36);
            this.txtseach.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(868, 411);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(585, 319);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(1470, 680);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(120, 49);
            this.btnexit.TabIndex = 13;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnfile
            // 
            this.btnfile.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfile.Location = new System.Drawing.Point(1470, 623);
            this.btnfile.Name = "btnfile";
            this.btnfile.Size = new System.Drawing.Size(120, 49);
            this.btnfile.TabIndex = 11;
            this.btnfile.Text = "FILE";
            this.btnfile.UseVisualStyleBackColor = false;
            this.btnfile.Click += new System.EventHandler(this.btnfile_Click);
            // 
            // btncap
            // 
            this.btncap.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btncap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncap.Location = new System.Drawing.Point(1469, 564);
            this.btncap.Name = "btncap";
            this.btncap.Size = new System.Drawing.Size(120, 49);
            this.btncap.TabIndex = 12;
            this.btncap.Text = "CAPTURE";
            this.btncap.UseVisualStyleBackColor = false;
            this.btncap.Click += new System.EventHandler(this.btncap_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox5.Controls.Add(this.btnon_in);
            this.groupBox5.Controls.Add(this.btnoff_in);
            this.groupBox5.Controls.Add(this.btnoff_out);
            this.groupBox5.Controls.Add(this.btnon_out);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(24, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(162, 372);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CONTROL";
            // 
            // btnon_in
            // 
            this.btnon_in.BackColor = System.Drawing.SystemColors.Info;
            this.btnon_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnon_in.Location = new System.Drawing.Point(19, 33);
            this.btnon_in.Name = "btnon_in";
            this.btnon_in.Size = new System.Drawing.Size(120, 71);
            this.btnon_in.TabIndex = 0;
            this.btnon_in.Text = "ON IN";
            this.btnon_in.UseVisualStyleBackColor = false;
            this.btnon_in.Click += new System.EventHandler(this.btnon_in_Click);
            // 
            // btnoff_in
            // 
            this.btnoff_in.BackColor = System.Drawing.SystemColors.Info;
            this.btnoff_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoff_in.Location = new System.Drawing.Point(19, 116);
            this.btnoff_in.Name = "btnoff_in";
            this.btnoff_in.Size = new System.Drawing.Size(120, 71);
            this.btnoff_in.TabIndex = 0;
            this.btnoff_in.Text = "OFF IN";
            this.btnoff_in.UseVisualStyleBackColor = false;
            this.btnoff_in.Click += new System.EventHandler(this.btnoff_in_Click);
            // 
            // btnoff_out
            // 
            this.btnoff_out.BackColor = System.Drawing.SystemColors.Info;
            this.btnoff_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoff_out.Location = new System.Drawing.Point(19, 285);
            this.btnoff_out.Name = "btnoff_out";
            this.btnoff_out.Size = new System.Drawing.Size(120, 71);
            this.btnoff_out.TabIndex = 0;
            this.btnoff_out.Text = "OFF OUT";
            this.btnoff_out.UseVisualStyleBackColor = false;
            this.btnoff_out.Click += new System.EventHandler(this.btnoff_out_Click);
            // 
            // btnon_out
            // 
            this.btnon_out.BackColor = System.Drawing.SystemColors.Info;
            this.btnon_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnon_out.Location = new System.Drawing.Point(19, 201);
            this.btnon_out.Name = "btnon_out";
            this.btnon_out.Size = new System.Drawing.Size(120, 71);
            this.btnon_out.TabIndex = 0;
            this.btnon_out.Text = "ON OUT";
            this.btnon_out.UseVisualStyleBackColor = false;
            this.btnon_out.Click += new System.EventHandler(this.btnon_out_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox4.Controls.Add(this.txtLicenseout);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtTimeout);
            this.groupBox4.Controls.Add(this.txtTimein);
            this.groupBox4.Controls.Add(this.txtIDout);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtName_out);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(462, 411);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(389, 319);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CHECK OUT";
            // 
            // txtLicenseout
            // 
            this.txtLicenseout.Location = new System.Drawing.Point(124, 84);
            this.txtLicenseout.Multiline = true;
            this.txtLicenseout.Name = "txtLicenseout";
            this.txtLicenseout.Size = new System.Drawing.Size(228, 40);
            this.txtLicenseout.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "License";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 269);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "Time out";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 206);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "Time in";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(410, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Fee";
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(124, 261);
            this.txtTimeout.Multiline = true;
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(228, 40);
            this.txtTimeout.TabIndex = 1;
            // 
            // txtTimein
            // 
            this.txtTimein.Location = new System.Drawing.Point(124, 202);
            this.txtTimein.Multiline = true;
            this.txtTimein.Name = "txtTimein";
            this.txtTimein.Size = new System.Drawing.Size(228, 40);
            this.txtTimein.TabIndex = 1;
            // 
            // txtIDout
            // 
            this.txtIDout.Location = new System.Drawing.Point(124, 28);
            this.txtIDout.Multiline = true;
            this.txtIDout.Name = "txtIDout";
            this.txtIDout.Size = new System.Drawing.Size(228, 40);
            this.txtIDout.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name";
            // 
            // txtName_out
            // 
            this.txtName_out.Location = new System.Drawing.Point(124, 142);
            this.txtName_out.Multiline = true;
            this.txtName_out.Name = "txtName_out";
            this.txtName_out.Size = new System.Drawing.Size(228, 40);
            this.txtName_out.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox3.Controls.Add(this.btnupdate);
            this.groupBox3.Controls.Add(this.btnrst);
            this.groupBox3.Controls.Add(this.btnadd);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.txtLicense);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(24, 411);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 319);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "INFORMATION";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.Info;
            this.btnupdate.Location = new System.Drawing.Point(151, 238);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(121, 63);
            this.btnupdate.TabIndex = 19;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnrst
            // 
            this.btnrst.BackColor = System.Drawing.SystemColors.Info;
            this.btnrst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrst.Location = new System.Drawing.Point(285, 238);
            this.btnrst.Name = "btnrst";
            this.btnrst.Size = new System.Drawing.Size(121, 63);
            this.btnrst.TabIndex = 2;
            this.btnrst.Text = "Reset";
            this.btnrst.UseVisualStyleBackColor = false;
            this.btnrst.Click += new System.EventHandler(this.btnrst_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.Info;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(15, 238);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(121, 63);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add Data";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(173, 171);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 45);
            this.txtName.TabIndex = 1;
            // 
            // txtLicense
            // 
            this.txtLicense.Location = new System.Drawing.Point(173, 100);
            this.txtLicense.Multiline = true;
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(214, 45);
            this.txtLicense.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(572, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "License Number";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(173, 28);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(214, 45);
            this.txtID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "License Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID Number";
            // 
            // pic_out
            // 
            this.pic_out.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pic_out.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_out.Location = new System.Drawing.Point(883, 21);
            this.pic_out.Name = "pic_out";
            this.pic_out.Size = new System.Drawing.Size(658, 372);
            this.pic_out.TabIndex = 6;
            this.pic_out.TabStop = false;
            // 
            // pic_in
            // 
            this.pic_in.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pic_in.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_in.Location = new System.Drawing.Point(206, 21);
            this.pic_in.Name = "pic_in";
            this.pic_in.Size = new System.Drawing.Size(658, 372);
            this.pic_in.TabIndex = 7;
            this.pic_in.TabStop = false;
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM3";
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // serialPort3
            // 
            this.serialPort3.PortName = "COM4";
            this.serialPort3.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort3_DataReceived);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1609, 885);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Security Parking";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_in)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnfile;
        private System.Windows.Forms.Button btncap;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnon_in;
        private System.Windows.Forms.Button btnoff_in;
        private System.Windows.Forms.Button btnoff_out;
        private System.Windows.Forms.Button btnon_out;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.TextBox txtTimein;
        private System.Windows.Forms.TextBox txtIDout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName_out;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnrst;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pic_out;
        private System.Windows.Forms.PictureBox pic_in;
        private System.IO.Ports.SerialPort serialPort2;
        private System.IO.Ports.SerialPort serialPort3;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnseach;
        private System.Windows.Forms.TextBox txtseach;
        private System.Windows.Forms.TextBox txtLicenseout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnupdate;
    }
}

