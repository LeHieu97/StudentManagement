namespace StudentManagement
{
    partial class US_Student
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_Student));
            this.txtAddSoLuong = new System.Windows.Forms.TextBox();
            this.dataStockDelivering = new System.Windows.Forms.DataGridView();
            this.mahs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddStudent = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteStudent = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnSearchStudent = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataStockDelivering)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAddSoLuong
            // 
            this.txtAddSoLuong.Location = new System.Drawing.Point(740, 886);
            this.txtAddSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddSoLuong.Name = "txtAddSoLuong";
            this.txtAddSoLuong.Size = new System.Drawing.Size(141, 20);
            this.txtAddSoLuong.TabIndex = 41;
            // 
            // dataStockDelivering
            // 
            this.dataStockDelivering.AllowUserToAddRows = false;
            this.dataStockDelivering.AllowUserToDeleteRows = false;
            this.dataStockDelivering.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataStockDelivering.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStockDelivering.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahs,
            this.holot,
            this.ten,
            this.ngaysinh,
            this.lop});
            this.dataStockDelivering.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataStockDelivering.Location = new System.Drawing.Point(0, 417);
            this.dataStockDelivering.Margin = new System.Windows.Forms.Padding(2);
            this.dataStockDelivering.Name = "dataStockDelivering";
            this.dataStockDelivering.ReadOnly = true;
            this.dataStockDelivering.RowTemplate.Height = 24;
            this.dataStockDelivering.Size = new System.Drawing.Size(1003, 255);
            this.dataStockDelivering.TabIndex = 39;
            // 
            // mahs
            // 
            this.mahs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mahs.HeaderText = "Studen ID";
            this.mahs.Name = "mahs";
            this.mahs.ReadOnly = true;
            // 
            // holot
            // 
            this.holot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.holot.HeaderText = "Họ Lót";
            this.holot.Name = "holot";
            this.holot.ReadOnly = true;
            // 
            // ten
            // 
            this.ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten.HeaderText = "Tên";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            // 
            // lop
            // 
            this.lop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lop.HeaderText = "Lớp";
            this.lop.Name = "lop";
            this.lop.ReadOnly = true;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.ActiveBorderThickness = 1;
            this.btnAddStudent.ActiveCornerRadius = 20;
            this.btnAddStudent.ActiveFillColor = System.Drawing.Color.Black;
            this.btnAddStudent.ActiveForecolor = System.Drawing.Color.Magenta;
            this.btnAddStudent.ActiveLineColor = System.Drawing.Color.Magenta;
            this.btnAddStudent.BackColor = System.Drawing.Color.White;
            this.btnAddStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.BackgroundImage")));
            this.btnAddStudent.ButtonText = "Thêm";
            this.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudent.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddStudent.IdleBorderThickness = 1;
            this.btnAddStudent.IdleCornerRadius = 20;
            this.btnAddStudent.IdleFillColor = System.Drawing.Color.White;
            this.btnAddStudent.IdleForecolor = System.Drawing.Color.Black;
            this.btnAddStudent.IdleLineColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAddStudent.Location = new System.Drawing.Point(249, 249);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(107, 63);
            this.btnAddStudent.TabIndex = 5;
            this.btnAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1003, 67);
            this.label1.TabIndex = 36;
            this.label1.Text = "Quản Lý Học Sinh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.ActiveBorderThickness = 1;
            this.btnDeleteStudent.ActiveCornerRadius = 20;
            this.btnDeleteStudent.ActiveFillColor = System.Drawing.Color.Black;
            this.btnDeleteStudent.ActiveForecolor = System.Drawing.Color.Magenta;
            this.btnDeleteStudent.ActiveLineColor = System.Drawing.Color.Magenta;
            this.btnDeleteStudent.BackColor = System.Drawing.Color.White;
            this.btnDeleteStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteStudent.BackgroundImage")));
            this.btnDeleteStudent.ButtonText = "Xóa";
            this.btnDeleteStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeleteStudent.IdleBorderThickness = 1;
            this.btnDeleteStudent.IdleCornerRadius = 20;
            this.btnDeleteStudent.IdleFillColor = System.Drawing.Color.White;
            this.btnDeleteStudent.IdleForecolor = System.Drawing.Color.Black;
            this.btnDeleteStudent.IdleLineColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDeleteStudent.Location = new System.Drawing.Point(639, 249);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(107, 63);
            this.btnDeleteStudent.TabIndex = 7;
            this.btnDeleteStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveBorderThickness = 1;
            this.btnUpdate.ActiveCornerRadius = 20;
            this.btnUpdate.ActiveFillColor = System.Drawing.Color.Black;
            this.btnUpdate.ActiveForecolor = System.Drawing.Color.Magenta;
            this.btnUpdate.ActiveLineColor = System.Drawing.Color.Magenta;
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.ButtonText = "Sửa";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdate.IdleBorderThickness = 1;
            this.btnUpdate.IdleCornerRadius = 20;
            this.btnUpdate.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdate.IdleForecolor = System.Drawing.Color.Black;
            this.btnUpdate.IdleLineColor = System.Drawing.Color.DarkGoldenrod;
            this.btnUpdate.Location = new System.Drawing.Point(444, 249);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 63);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(350, 352);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 42);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.text = "Search Student";
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.ActiveBorderThickness = 1;
            this.btnSearchStudent.ActiveCornerRadius = 20;
            this.btnSearchStudent.ActiveFillColor = System.Drawing.Color.Black;
            this.btnSearchStudent.ActiveForecolor = System.Drawing.Color.Magenta;
            this.btnSearchStudent.ActiveLineColor = System.Drawing.Color.Magenta;
            this.btnSearchStudent.BackColor = System.Drawing.Color.White;
            this.btnSearchStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchStudent.BackgroundImage")));
            this.btnSearchStudent.ButtonText = "Search";
            this.btnSearchStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchStudent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudent.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearchStudent.IdleBorderThickness = 1;
            this.btnSearchStudent.IdleCornerRadius = 20;
            this.btnSearchStudent.IdleFillColor = System.Drawing.Color.White;
            this.btnSearchStudent.IdleForecolor = System.Drawing.Color.Black;
            this.btnSearchStudent.IdleLineColor = System.Drawing.Color.Black;
            this.btnSearchStudent.Location = new System.Drawing.Point(639, 352);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(76, 45);
            this.btnSearchStudent.TabIndex = 9;
            this.btnSearchStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtSize);
            this.groupBox1.Controls.Add(this.txtTenHang);
            this.groupBox1.Controls.Add(this.txtMaHS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1003, 166);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học sinh";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 110);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 22);
            this.textBox1.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(606, 88);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(140, 22);
            this.txtSoLuong.TabIndex = 4;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(606, 44);
            this.txtSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(140, 22);
            this.txtSize.TabIndex = 3;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(330, 71);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(141, 22);
            this.txtTenHang.TabIndex = 1;
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(330, 34);
            this.txtMaHS.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(141, 22);
            this.txtMaHS.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(243, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(544, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(533, 44);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Ngày Sinh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(533, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Lớp:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(243, 71);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Họ Lót:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(243, 34);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Mã Học Sinh:";
            // 
            // US_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.txtAddSoLuong);
            this.Controls.Add(this.dataStockDelivering);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.label1);
            this.Name = "US_Student";
            this.Size = new System.Drawing.Size(1003, 672);
            ((System.ComponentModel.ISupportInitialize)(this.dataStockDelivering)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAddSoLuong;
        private System.Windows.Forms.DataGridView dataStockDelivering;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahs;
        private System.Windows.Forms.DataGridViewTextBoxColumn holot;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeleteStudent;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearchStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}
