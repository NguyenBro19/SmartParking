
namespace Doanthu2
{
    partial class frmData
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnseach = new System.Windows.Forms.Button();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(686, 36);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(117, 41);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(519, 36);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(117, 41);
            this.btndel.TabIndex = 7;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(847, 36);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(117, 41);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnseach
            // 
            this.btnseach.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnseach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseach.Location = new System.Drawing.Point(343, 36);
            this.btnseach.Name = "btnseach";
            this.btnseach.Size = new System.Drawing.Size(117, 41);
            this.btnseach.TabIndex = 9;
            this.btnseach.Text = "Seach";
            this.btnseach.UseVisualStyleBackColor = false;
            this.btnseach.Click += new System.EventHandler(this.btnseach_Click);
            // 
            // txtLicense
            // 
            this.txtLicense.Location = new System.Drawing.Point(80, 31);
            this.txtLicense.Multiline = true;
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(195, 46);
            this.txtLicense.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 126);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(989, 486);
            this.dataGridView1.TabIndex = 4;
            // 
            // frmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1054, 643);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnseach);
            this.Controls.Add(this.txtLicense);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmData";
            this.Text = "Data";
            this.Load += new System.EventHandler(this.frmData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnseach;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}