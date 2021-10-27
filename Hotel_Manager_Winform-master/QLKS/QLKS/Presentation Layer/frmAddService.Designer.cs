namespace QLKS.Presentation_Layer
{
    partial class frmAddService
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txttong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxmadv = new System.Windows.Forms.ComboBox();
            this.cbxmapd = new System.Windows.Forms.ComboBox();
            this.dgvdvthem = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdvthem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.label1.Location = new System.Drawing.Point(200, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã PĐ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã DV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "SL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng";
            // 
            // txtsl
            // 
            this.txtsl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsl.Location = new System.Drawing.Point(397, 39);
            this.txtsl.Margin = new System.Windows.Forms.Padding(4);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(132, 30);
            this.txtsl.TabIndex = 7;
            this.txtsl.TextChanged += new System.EventHandler(this.txtsl_TextChanged);
            // 
            // txttong
            // 
            this.txttong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttong.Location = new System.Drawing.Point(397, 86);
            this.txttong.Margin = new System.Windows.Forms.Padding(4);
            this.txttong.Name = "txttong";
            this.txttong.Size = new System.Drawing.Size(132, 30);
            this.txttong.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxmadv);
            this.groupBox1.Controls.Add(this.cbxmapd);
            this.groupBox1.Controls.Add(this.txttong);
            this.groupBox1.Controls.Add(this.txtsl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox1.Location = new System.Drawing.Point(16, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(557, 142);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm dịch vụ";
            // 
            // cbxmadv
            // 
            this.cbxmadv.FormattingEnabled = true;
            this.cbxmadv.Location = new System.Drawing.Point(101, 86);
            this.cbxmadv.Margin = new System.Windows.Forms.Padding(4);
            this.cbxmadv.Name = "cbxmadv";
            this.cbxmadv.Size = new System.Drawing.Size(137, 30);
            this.cbxmadv.TabIndex = 10;
            // 
            // cbxmapd
            // 
            this.cbxmapd.FormattingEnabled = true;
            this.cbxmapd.Location = new System.Drawing.Point(101, 39);
            this.cbxmapd.Margin = new System.Windows.Forms.Padding(4);
            this.cbxmapd.Name = "cbxmapd";
            this.cbxmapd.Size = new System.Drawing.Size(137, 30);
            this.cbxmapd.TabIndex = 9;
            // 
            // dgvdvthem
            // 
            this.dgvdvthem.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvdvthem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdvthem.Location = new System.Drawing.Point(16, 257);
            this.dgvdvthem.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdvthem.Name = "dgvdvthem";
            this.dgvdvthem.RowHeadersWidth = 51;
            this.dgvdvthem.Size = new System.Drawing.Size(557, 151);
            this.dgvdvthem.TabIndex = 10;
            this.dgvdvthem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdvthem_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.button1.Location = new System.Drawing.Point(229, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(589, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvdvthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách sạn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdvthem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvdvthem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxmadv;
        private System.Windows.Forms.ComboBox cbxmapd;
    }
}