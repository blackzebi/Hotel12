namespace QLKS
{
    partial class frmAccManager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxManv = new System.Windows.Forms.ComboBox();
            this.cbxPermission = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAcc = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.label1.Location = new System.Drawing.Point(221, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lí tài khoản";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxManv);
            this.groupBox1.Controls.Add(this.cbxPermission);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox1.Location = new System.Drawing.Point(17, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(681, 153);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbxManv
            // 
            this.cbxManv.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbxManv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxManv.FormattingEnabled = true;
            this.cbxManv.Location = new System.Drawing.Point(159, 94);
            this.cbxManv.Margin = new System.Windows.Forms.Padding(4);
            this.cbxManv.Name = "cbxManv";
            this.cbxManv.Size = new System.Drawing.Size(155, 30);
            this.cbxManv.TabIndex = 70;
            // 
            // cbxPermission
            // 
            this.cbxPermission.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbxPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPermission.FormattingEnabled = true;
            this.cbxPermission.Location = new System.Drawing.Point(495, 94);
            this.cbxPermission.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPermission.Name = "cbxPermission";
            this.cbxPermission.Size = new System.Drawing.Size(155, 30);
            this.cbxPermission.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(364, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 68;
            this.label5.Text = "Quyền";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPass.Location = new System.Drawing.Point(495, 41);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(155, 29);
            this.txtPass.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(364, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 66;
            this.label4.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(28, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 64;
            this.label2.Text = "Mã NV :";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUserName.Location = new System.Drawing.Point(159, 41);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(155, 29);
            this.txtUserName.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(28, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 62;
            this.label3.Text = "User Name :";
            // 
            // dgvAcc
            // 
            this.dgvAcc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcc.Location = new System.Drawing.Point(17, 250);
            this.dgvAcc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAcc.Name = "dgvAcc";
            this.dgvAcc.RowHeadersWidth = 51;
            this.dgvAcc.Size = new System.Drawing.Size(681, 185);
            this.dgvAcc.TabIndex = 3;
            this.dgvAcc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAcc_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.btnThem.Location = new System.Drawing.Point(256, 206);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 37);
            this.btnThem.TabIndex = 77;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.btnXoa.Location = new System.Drawing.Point(585, 206);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 37);
            this.btnXoa.TabIndex = 76;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.btnSua.Location = new System.Drawing.Point(367, 206);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 37);
            this.btnSua.TabIndex = 75;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.btnSave.Location = new System.Drawing.Point(476, 206);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 37);
            this.btnSave.TabIndex = 78;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAccManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(715, 446);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvAcc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAccManager";
            this.Text = "Quản lý khách sạn";
            this.Load += new System.EventHandler(this.frmAccManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxPermission;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAcc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbxManv;
    }
}