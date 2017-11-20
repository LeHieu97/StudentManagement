namespace StudentManagement
{
    partial class Form_Menu
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
            BunifuAnimatorNS.Animation animation11 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            BunifuAnimatorNS.Animation animation12 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlName = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.sideMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHocSinh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.animatorLogo = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.animatorPnl = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.frmHs1 = new TESTING_PROJECT.frmHs();
            this.pnlName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.sideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlName
            // 
            this.pnlName.BackColor = System.Drawing.Color.Black;
            this.pnlName.Controls.Add(this.label1);
            this.pnlName.Controls.Add(this.pictureBox1);
            this.pnlName.Controls.Add(this.btnExit);
            this.animatorPnl.SetDecoration(this.pnlName, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogo.SetDecoration(this.pnlName, BunifuAnimatorNS.DecorationType.None);
            this.pnlName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlName.Location = new System.Drawing.Point(0, 0);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(1255, 32);
            this.pnlName.TabIndex = 0;
            this.pnlName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlName_MouseDown);
            this.pnlName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlName_MouseMove);
            this.pnlName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlName_MouseUp);
            // 
            // label1
            // 
            this.animatorLogo.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.animatorPnl.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "Student Management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.animatorLogo.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.animatorPnl.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.animatorPnl.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogo.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(1224, 5);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 22);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 37;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 20;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.Black;
            this.sideMenu.Controls.Add(this.label2);
            this.sideMenu.Controls.Add(this.btnHocSinh);
            this.sideMenu.Controls.Add(this.logo);
            this.sideMenu.Controls.Add(this.btnMenu);
            this.animatorPnl.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogo.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 32);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(252, 672);
            this.sideMenu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.animatorLogo.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.animatorPnl.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(3, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Menu Manager Student";
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.Activecolor = System.Drawing.Color.Purple;
            this.btnHocSinh.BackColor = System.Drawing.Color.Purple;
            this.btnHocSinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHocSinh.BorderRadius = 0;
            this.btnHocSinh.ButtonText = "          Student";
            this.btnHocSinh.Cursor = System.Windows.Forms.Cursors.Default;
            this.animatorPnl.SetDecoration(this.btnHocSinh, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogo.SetDecoration(this.btnHocSinh, BunifuAnimatorNS.DecorationType.None);
            this.btnHocSinh.DisabledColor = System.Drawing.Color.Gray;
            this.btnHocSinh.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHocSinh.ForeColor = System.Drawing.Color.White;
            this.btnHocSinh.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHocSinh.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHocSinh.Iconimage")));
            this.btnHocSinh.Iconimage_right = null;
            this.btnHocSinh.Iconimage_right_Selected = null;
            this.btnHocSinh.Iconimage_Selected = null;
            this.btnHocSinh.IconMarginLeft = 0;
            this.btnHocSinh.IconMarginRight = 0;
            this.btnHocSinh.IconRightVisible = true;
            this.btnHocSinh.IconRightZoom = 0D;
            this.btnHocSinh.IconVisible = true;
            this.btnHocSinh.IconZoom = 50D;
            this.btnHocSinh.IsTab = true;
            this.btnHocSinh.Location = new System.Drawing.Point(1, 228);
            this.btnHocSinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHocSinh.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnHocSinh.OnHoverTextColor = System.Drawing.Color.Lime;
            this.btnHocSinh.selected = true;
            this.btnHocSinh.Size = new System.Drawing.Size(251, 48);
            this.btnHocSinh.TabIndex = 27;
            this.btnHocSinh.Text = "          Student";
            this.btnHocSinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHocSinh.Textcolor = System.Drawing.Color.White;
            this.btnHocSinh.TextFont = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHocSinh.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.animatorLogo.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.animatorPnl.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(20, 51);
            this.logo.Margin = new System.Windows.Forms.Padding(2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(215, 96);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 26;
            this.logo.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.animatorPnl.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogo.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(213, 5);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(37, 30);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 22;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.frmHs1);
            this.animatorPnl.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogo.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(252, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1003, 672);
            this.panel3.TabIndex = 1;
            // 
            // animatorLogo
            // 
            this.animatorLogo.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.animatorLogo.Cursor = null;
            animation11.AnimateOnlyDifferences = true;
            animation11.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.BlindCoeff")));
            animation11.LeafCoeff = 0F;
            animation11.MaxTime = 1F;
            animation11.MinTime = 0F;
            animation11.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicCoeff")));
            animation11.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicShift")));
            animation11.MosaicSize = 20;
            animation11.Padding = new System.Windows.Forms.Padding(30);
            animation11.RotateCoeff = 0F;
            animation11.RotateLimit = 0F;
            animation11.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.ScaleCoeff")));
            animation11.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.SlideCoeff")));
            animation11.TimeCoeff = 0F;
            animation11.TransparencyCoeff = 0F;
            this.animatorLogo.DefaultAnimation = animation11;
            this.animatorLogo.TimeStep = 0.01F;
            // 
            // animatorPnl
            // 
            this.animatorPnl.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.animatorPnl.Cursor = null;
            animation12.AnimateOnlyDifferences = true;
            animation12.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.BlindCoeff")));
            animation12.LeafCoeff = 0F;
            animation12.MaxTime = 1F;
            animation12.MinTime = 0F;
            animation12.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicCoeff")));
            animation12.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicShift")));
            animation12.MosaicSize = 0;
            animation12.Padding = new System.Windows.Forms.Padding(0);
            animation12.RotateCoeff = 0F;
            animation12.RotateLimit = 0F;
            animation12.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.ScaleCoeff")));
            animation12.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.SlideCoeff")));
            animation12.TimeCoeff = 0F;
            animation12.TransparencyCoeff = 0F;
            this.animatorPnl.DefaultAnimation = animation12;
            this.animatorPnl.TimeStep = 0.015F;
            // 
            // frmHs1
            // 
            this.frmHs1.BackColor = System.Drawing.Color.White;
            this.animatorLogo.SetDecoration(this.frmHs1, BunifuAnimatorNS.DecorationType.None);
            this.animatorPnl.SetDecoration(this.frmHs1, BunifuAnimatorNS.DecorationType.None);
            this.frmHs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmHs1.Location = new System.Drawing.Point(0, 0);
            this.frmHs1.Name = "frmHs1";
            this.frmHs1.Size = new System.Drawing.Size(1003, 672);
            this.frmHs1.TabIndex = 0;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 704);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.pnlName);
            this.animatorLogo.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animatorPnl.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "```";
            this.pnlName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.sideMenu.ResumeLayout(false);
            this.sideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private BunifuAnimatorNS.BunifuTransition animatorLogo;
        private BunifuAnimatorNS.BunifuTransition animatorPnl;
        private System.Windows.Forms.Panel sideMenu;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuFlatButton btnHocSinh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private TESTING_PROJECT.frmHs frmHs1;
    }
}