namespace Xiao_Hour_ePOS.Users
{
    partial class ucUserList
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
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.lstUserList = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(605, 6);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(126, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Add New User";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // lstUserList
            // 
            this.lstUserList.AutoSizeTable = false;
            this.lstUserList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader4});
            this.lstUserList.Depth = 0;
            this.lstUserList.FullRowSelect = true;
            this.lstUserList.Location = new System.Drawing.Point(0, 68);
            this.lstUserList.MinimumSize = new System.Drawing.Size(200, 100);
            this.lstUserList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstUserList.MouseState = MaterialSkin.MouseState.OUT;
            this.lstUserList.Name = "lstUserList";
            this.lstUserList.OwnerDraw = true;
            this.lstUserList.Size = new System.Drawing.Size(732, 468);
            this.lstUserList.TabIndex = 1;
            this.lstUserList.UseCompatibleStateImageBehavior = false;
            this.lstUserList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Username";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Full Name";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Gender";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date of Birth";
            this.columnHeader4.Width = 150;
            // 
            // ucUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstUserList);
            this.Controls.Add(this.materialButton1);
            this.Name = "ucUserList";
            this.Size = new System.Drawing.Size(735, 559);
            this.Load += new System.EventHandler(this.ucUserList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialListView lstUserList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
    }
}
