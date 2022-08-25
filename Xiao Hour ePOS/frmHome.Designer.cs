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
            this.tbdashboard = new System.Windows.Forms.TabPage();
            this.lblUsername = new MaterialSkin.Controls.MaterialLabel();
            this.tbsale = new System.Windows.Forms.TabPage();
            this.tbproduct = new System.Windows.Forms.TabPage();
            this.tbcustomer = new System.Windows.Forms.TabPage();
            this.tbreport = new System.Windows.Forms.TabPage();
            this.tblogout = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtsearch = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTabControl1.SuspendLayout();
            this.tbdashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tbdashboard);
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
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // tbdashboard
            // 
            this.tbdashboard.BackColor = System.Drawing.Color.White;
            this.tbdashboard.Controls.Add(this.lblUsername);
            this.tbdashboard.ImageKey = "icons8-dashboard-layout-24.png";
            this.tbdashboard.Location = new System.Drawing.Point(4, 24);
            this.tbdashboard.Name = "tbdashboard";
            this.tbdashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tbdashboard.Size = new System.Drawing.Size(978, 558);
            this.tbdashboard.TabIndex = 0;
            this.tbdashboard.Text = "DASHBOARD";
            this.tbdashboard.Click += new System.EventHandler(this.tbsale_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Depth = 0;
            this.lblUsername.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsername.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblUsername.Location = new System.Drawing.Point(24, 18);
            this.lblUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(283, 41);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Welcome back {0}!";
            // 
            // tbsale
            // 
            this.tbsale.ImageKey = "icons8-land-sales-24.png";
            this.tbsale.Location = new System.Drawing.Point(4, 24);
            this.tbsale.Name = "tbsale";
            this.tbsale.Padding = new System.Windows.Forms.Padding(3);
            this.tbsale.Size = new System.Drawing.Size(978, 558);
            this.tbsale.TabIndex = 1;
            this.tbsale.Text = "SALE";
            this.tbsale.UseVisualStyleBackColor = true;
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
            this.tbcustomer.ImageKey = "icons8-customer-24.png";
            this.tbcustomer.Location = new System.Drawing.Point(4, 24);
            this.tbcustomer.Name = "tbcustomer";
            this.tbcustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tbcustomer.Size = new System.Drawing.Size(978, 558);
            this.tbcustomer.TabIndex = 3;
            this.tbcustomer.Text = "CUSTOMER";
            this.tbcustomer.UseVisualStyleBackColor = true;
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
            this.txtsearch.TabIndex = 3;
            this.txtsearch.Text = "";
            this.txtsearch.TrailingIcon = null;
            this.txtsearch.UseTallSize = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 677);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Name = "frmHome";
            this.Padding = new System.Windows.Forms.Padding(0, 88, 3, 3);
            this.Text = "Xiao Hour ePOS 2022";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tbdashboard.ResumeLayout(false);
            this.tbdashboard.PerformLayout();
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
        private TabPage tbdashboard;
        private TabPage tbsale;
        private TabPage tbproduct;
        private TabPage tbcustomer;
        private ImageList imageList1;
        private TabPage tbreport;
        private TabPage tblogout;
        private MaterialSkin.Controls.MaterialTextBox txtsearch;
        private MaterialSkin.Controls.MaterialLabel lblUsername;
    }
}