namespace Xiao_Hour_ePOS
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tbsale = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbproduct = new System.Windows.Forms.TabPage();
            this.tbcustomer = new System.Windows.Forms.TabPage();
            this.ucUserList1 = new Xiao_Hour_ePOS.Users.ucUserList();
            this.tbreport = new System.Windows.Forms.TabPage();
            this.tblogout = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtsearch = new MaterialSkin.Controls.MaterialTextBox();
            this.lblUsername = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.tbDashboard = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
            this.tbsale.SuspendLayout();
            this.tbcustomer.SuspendLayout();
            this.tbDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tbDashboard);
            this.materialTabControl1.Controls.Add(this.tbsale);
            this.materialTabControl1.Controls.Add(this.tbproduct);
            this.materialTabControl1.Controls.Add(this.tbcustomer);
            this.materialTabControl1.Controls.Add(this.tbreport);
            this.materialTabControl1.Controls.Add(this.tblogout);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 88);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(986, 586);
            this.materialTabControl1.TabIndex = 2;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // tbsale
            // 
            this.tbsale.Controls.Add(this.tableLayoutPanel1);
            this.tbsale.ImageKey = "icons8-land-sales-24.png";
            this.tbsale.Location = new System.Drawing.Point(4, 24);
            this.tbsale.Name = "tbsale";
            this.tbsale.Padding = new System.Windows.Forms.Padding(3);
            this.tbsale.Size = new System.Drawing.Size(978, 558);
            this.tbsale.TabIndex = 1;
            this.tbsale.Text = "SALE";
            this.tbsale.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(972, 552);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbproduct
            // 
            this.tbproduct.ImageKey = "icons8-product-24.png";
            this.tbproduct.Location = new System.Drawing.Point(4, 24);
            this.tbproduct.Name = "tbproduct";
            this.tbproduct.Padding = new System.Windows.Forms.Padding(3);
            this.tbproduct.Size = new System.Drawing.Size(978, 558);
            this.tbproduct.TabIndex = 2;
            this.tbproduct.Text = "PRODUCT";
            this.tbproduct.UseVisualStyleBackColor = true;
            // 
            // tbcustomer
            // 
            this.tbcustomer.Controls.Add(this.ucUserList1);
            this.tbcustomer.ImageKey = "icons8-customer-24.png";
            this.tbcustomer.Location = new System.Drawing.Point(4, 24);
            this.tbcustomer.Name = "tbcustomer";
            this.tbcustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tbcustomer.Size = new System.Drawing.Size(978, 558);
            this.tbcustomer.TabIndex = 3;
            this.tbcustomer.Text = "CUSTOMER";
            this.tbcustomer.UseVisualStyleBackColor = true;
            // 
            // ucUserList1
            // 
            this.ucUserList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUserList1.Location = new System.Drawing.Point(3, 3);
            this.ucUserList1.Name = "ucUserList1";
            this.ucUserList1.Size = new System.Drawing.Size(972, 552);
            this.ucUserList1.TabIndex = 0;
            // 
            // tbreport
            // 
            this.tbreport.ImageKey = "icons8-bar-chart-24.png";
            this.tbreport.Location = new System.Drawing.Point(4, 24);
            this.tbreport.Name = "tbreport";
            this.tbreport.Padding = new System.Windows.Forms.Padding(3);
            this.tbreport.Size = new System.Drawing.Size(978, 558);
            this.tbreport.TabIndex = 4;
            this.tbreport.Text = "REPORT";
            this.tbreport.UseVisualStyleBackColor = true;
            // 
            // tblogout
            // 
            this.tblogout.ImageKey = "icons8-imac-exit-24.png";
            this.tblogout.Location = new System.Drawing.Point(4, 24);
            this.tblogout.Name = "tblogout";
            this.tblogout.Padding = new System.Windows.Forms.Padding(3);
            this.tblogout.Size = new System.Drawing.Size(978, 558);
            this.tblogout.TabIndex = 5;
            this.tblogout.Text = "LOGOUT";
            this.tblogout.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "username.png");
            this.imageList1.Images.SetKeyName(1, "download.png");
            this.imageList1.Images.SetKeyName(2, "icons8-bar-chart-24.png");
            this.imageList1.Images.SetKeyName(3, "icons8-customer-24.png");
            this.imageList1.Images.SetKeyName(4, "icons8-land-sales-24.png");
            this.imageList1.Images.SetKeyName(5, "icons8-product-24.png");
            this.imageList1.Images.SetKeyName(6, "icons8-sale-24.png");
            this.imageList1.Images.SetKeyName(7, "key-star.png");
            this.imageList1.Images.SetKeyName(8, "username.png");
            this.imageList1.Images.SetKeyName(9, "icons8-dashboard-layout-24.png");
            this.imageList1.Images.SetKeyName(10, "icons8-logout-24.png");
            this.imageList1.Images.SetKeyName(11, "icons8-shutdown-24.png");
            this.imageList1.Images.SetKeyName(12, "icons8-imac-exit-24.png");
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsearch.AnimateReadOnly = false;
            this.txtsearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsearch.Depth = 0;
            this.txtsearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtsearch.Hint = "Search";
            this.txtsearch.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtsearch.LeadingIcon")));
            this.txtsearch.Location = new System.Drawing.Point(382, 37);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtsearch.MaxLength = 50;
            this.txtsearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtsearch.Multiline = false;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(259, 36);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.Text = "";
            this.txtsearch.TrailingIcon = null;
            this.txtsearch.UseTallSize = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Depth = 0;
            this.lblUsername.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsername.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblUsername.Location = new System.Drawing.Point(3, 4);
            this.lblUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(283, 41);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Welcome back {0}!";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(70, 104);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "materialButton1";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // tbDashboard
            // 
            this.tbDashboard.BackColor = System.Drawing.Color.White;
            this.tbDashboard.Controls.Add(this.materialButton1);
            this.tbDashboard.Controls.Add(this.lblUsername);
            this.tbDashboard.ImageKey = "icons8-dashboard-layout-24.png";
            this.tbDashboard.Location = new System.Drawing.Point(4, 24);
            this.tbDashboard.Name = "tbDashboard";
            this.tbDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tbDashboard.Size = new System.Drawing.Size(978, 558);
            this.tbDashboard.TabIndex = 0;
            this.tbDashboard.Text = "DASHBOARD";
            this.tbDashboard.Click += new System.EventHandler(this.tbsale_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 677);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerAutoShow = true;
            this.DrawerBackgroundWithAccent = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerWidth = 250;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Name = "frmHome";
            this.Padding = new System.Windows.Forms.Padding(0, 88, 3, 3);
            this.Text = "Xiao Hour ePOS 2022";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmHome_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FormClosing);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tbsale.ResumeLayout(false);
            this.tbcustomer.ResumeLayout(false);
            this.tbDashboard.ResumeLayout(false);
            this.tbDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TabPage tabPage4;
        private MaterialSkin.Controls.MaterialTabControl tabcontrol;
        private TabPage tabsale;
        private TabPage tabproduct;
        private TabPage tabcustomer;
        private TabPage tabreport;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tbsale;
        private TabPage tbproduct;
        private TabPage tbcustomer;
        private ImageList imageList1;
        private TabPage tbreport;
        private TabPage tblogout;
        private MaterialSkin.Controls.MaterialTextBox txtsearch;
        private TableLayoutPanel tableLayoutPanel1;
        private Users.ucUserList ucUserList1;
        private TabPage tbDashboard;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel lblUsername;
    }
}