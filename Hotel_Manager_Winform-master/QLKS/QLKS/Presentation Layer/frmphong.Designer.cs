namespace QLKS
{
    partial class frmphong
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.dgvphong = new System.Windows.Forms.DataGridView();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.dgvloaiphong = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDel2 = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaloai = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphong)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaiphong)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(5, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(881, 497);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.btnSave1);
            this.tabPage1.Controls.Add(this.dgvphong);
            this.tabPage1.Controls.Add(this.cbLoaiPhong);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnAdd1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtMaphong);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(873, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý phòng";
            // 
            // btnSave1
            // 
            this.btnSave1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.btnSave1.Location = new System.Drawing.Point(236, 203);
            this.btnSave1.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(127, 37);
            this.btnSave1.TabIndex = 11;
            this.btnSave1.Text = "Save";
            this.btnSave1.UseVisualStyleBackColor = false;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // dgvphong
            // 
            this.dgvphong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvphong.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphong.Location = new System.Drawing.Point(452, 78);
            this.dgvphong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvphong.Name = "dgvphong";
            this.dgvphong.RowHeadersWidth = 51;
            this.dgvphong.Size = new System.Drawing.Size(399, 372);
            this.dgvphong.TabIndex = 10;
            this.dgvphong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphong_CellClick_1);
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(177, 133);
            this.cbLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(213, 30);
            this.cbLoaiPhong.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.label3.Location = new System.Drawing.Point(297, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "Danh sách phòng";
            // 
            // btnAdd1
            // 
            this.btnAdd1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.btnAdd1.Location = new System.Drawing.Point(75, 203);
            this.btnAdd1.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(127, 37);
            this.btnAdd1.TabIndex = 5;
            this.btnAdd1.Text = "Thêm";
            this.btnAdd1.UseVisualStyleBackColor = false;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(31, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(31, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã phòng";
            // 
            // txtMaphong
            // 
            this.txtMaphong.Location = new System.Drawing.Point(177, 78);
            this.txtMaphong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(213, 30);
            this.txtMaphong.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.btnSave2);
            this.tabPage2.Controls.Add(this.dgvloaiphong);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtgia);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnDel2);
            this.tabPage2.Controls.Add(this.btnAdd2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtMaloai);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(873, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý loại phòng";
            // 
            // btnSave2
            // 
            this.btnSave2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave2.Location = new System.Drawing.Point(248, 196);
            this.btnSave2.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(115, 36);
            this.btnSave2.TabIndex = 21;
            this.btnSave2.Text = "Save";
            this.btnSave2.UseVisualStyleBackColor = false;
            this.btnSave2.Click += new System.EventHandler(this.button6_Click);
            // 
            // dgvloaiphong
            // 
            this.dgvloaiphong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvloaiphong.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvloaiphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvloaiphong.Location = new System.Drawing.Point(411, 73);
            this.dgvloaiphong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvloaiphong.Name = "dgvloaiphong";
            this.dgvloaiphong.RowHeadersWidth = 51;
            this.dgvloaiphong.Size = new System.Drawing.Size(452, 377);
            this.dgvloaiphong.TabIndex = 20;
            this.dgvloaiphong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvloaiphong_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(19, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Giá";
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(165, 128);
            this.txtgia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(213, 30);
            this.txtgia.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.label4.Location = new System.Drawing.Point(359, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 38);
            this.label4.TabIndex = 17;
            this.label4.Text = "Loại phòng";
            // 
            // btnDel2
            // 
            this.btnDel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDel2.Location = new System.Drawing.Point(101, 259);
            this.btnDel2.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel2.Name = "btnDel2";
            this.btnDel2.Size = new System.Drawing.Size(213, 37);
            this.btnDel2.TabIndex = 16;
            this.btnDel2.Text = "Xóa";
            this.btnDel2.UseVisualStyleBackColor = false;
            this.btnDel2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd2.Location = new System.Drawing.Point(55, 194);
            this.btnAdd2.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(115, 37);
            this.btnAdd2.TabIndex = 14;
            this.btnAdd2.Text = "Thêm";
            this.btnAdd2.UseVisualStyleBackColor = false;
            this.btnAdd2.Click += new System.EventHandler(this.button5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(19, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã loại";
            // 
            // txtMaloai
            // 
            this.txtMaloai.Location = new System.Drawing.Point(165, 73);
            this.txtMaloai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaloai.Name = "txtMaloai";
            this.txtMaloai.Size = new System.Drawing.Size(213, 30);
            this.txtMaloai.TabIndex = 9;
            // 
            // frmphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(889, 530);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách sạn ";
            this.Load += new System.EventHandler(this.Frmphong_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphong)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaiphong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDel2;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaloai;
        private System.Windows.Forms.DataGridView dgvloaiphong;
        private System.Windows.Forms.DataGridView dgvphong;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Button btnSave1;
    }
}