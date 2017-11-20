namespace StudentManagement
{
    partial class US_NienKhoa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_NienKhoa));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataterm = new System.Windows.Forms.DataGridView();
            this.namhocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nienkhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._D__studentmanagement_quanlyhocsinh_mdfDataSet = new StudentManagement._D__studentmanagement_quanlyhocsinh_mdfDataSet();
            this.btnAddStudent = new Bunifu.Framework.UI.BunifuThinButton2();
            this.UpDownNienKhoa = new System.Windows.Forms.DomainUpDown();
            this.nienkhoaTableAdapter = new StudentManagement._D__studentmanagement_quanlyhocsinh_mdfDataSetTableAdapters.nienkhoaTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataterm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nienkhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._D__studentmanagement_quanlyhocsinh_mdfDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1003, 91);
            this.label1.TabIndex = 37;
            this.label1.Text = "Term Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataterm);
            this.groupBox1.Controls.Add(this.btnAddStudent);
            this.groupBox1.Controls.Add(this.UpDownNienKhoa);
            this.groupBox1.Location = new System.Drawing.Point(77, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 530);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Term";
            // 
            // dataterm
            // 
            this.dataterm.AllowUserToAddRows = false;
            this.dataterm.AllowUserToDeleteRows = false;
            this.dataterm.AutoGenerateColumns = false;
            this.dataterm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataterm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namhocDataGridViewTextBoxColumn});
            this.dataterm.DataSource = this.nienkhoaBindingSource;
            this.dataterm.Location = new System.Drawing.Point(158, 111);
            this.dataterm.Name = "dataterm";
            this.dataterm.ReadOnly = true;
            this.dataterm.Size = new System.Drawing.Size(240, 280);
            this.dataterm.TabIndex = 7;
            // 
            // namhocDataGridViewTextBoxColumn
            // 
            this.namhocDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namhocDataGridViewTextBoxColumn.DataPropertyName = "namhoc";
            this.namhocDataGridViewTextBoxColumn.HeaderText = "namhoc";
            this.namhocDataGridViewTextBoxColumn.Name = "namhocDataGridViewTextBoxColumn";
            this.namhocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nienkhoaBindingSource
            // 
            this.nienkhoaBindingSource.DataMember = "nienkhoa";
            this.nienkhoaBindingSource.DataSource = this._D__studentmanagement_quanlyhocsinh_mdfDataSet;
            // 
            // _D__studentmanagement_quanlyhocsinh_mdfDataSet
            // 
            this._D__studentmanagement_quanlyhocsinh_mdfDataSet.DataSetName = "_D__studentmanagement_quanlyhocsinh_mdfDataSet";
            this._D__studentmanagement_quanlyhocsinh_mdfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnAddStudent.Location = new System.Drawing.Point(579, 237);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(107, 63);
            this.btnAddStudent.TabIndex = 6;
            this.btnAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpDownNienKhoa
            // 
            this.UpDownNienKhoa.Location = new System.Drawing.Point(579, 179);
            this.UpDownNienKhoa.Name = "UpDownNienKhoa";
            this.UpDownNienKhoa.Size = new System.Drawing.Size(120, 20);
            this.UpDownNienKhoa.TabIndex = 0;
            this.UpDownNienKhoa.Text = "domainUpDown1";
            this.UpDownNienKhoa.SelectedItemChanged += new System.EventHandler(this.UpDownNienKhoa_SelectedItemChanged);
            // 
            // nienkhoaTableAdapter
            // 
            this.nienkhoaTableAdapter.ClearBeforeFill = true;
            // 
            // US_NienKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "US_NienKhoa";
            this.Size = new System.Drawing.Size(1003, 672);
            this.Load += new System.EventHandler(this.US_NienKhoa_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataterm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nienkhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._D__studentmanagement_quanlyhocsinh_mdfDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DomainUpDown UpDownNienKhoa;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddStudent;
        private System.Windows.Forms.DataGridView dataterm;
        private System.Windows.Forms.DataGridViewTextBoxColumn namhocDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nienkhoaBindingSource;
        private _D__studentmanagement_quanlyhocsinh_mdfDataSet _D__studentmanagement_quanlyhocsinh_mdfDataSet;
        private _D__studentmanagement_quanlyhocsinh_mdfDataSetTableAdapters.nienkhoaTableAdapter nienkhoaTableAdapter;
    }
}
