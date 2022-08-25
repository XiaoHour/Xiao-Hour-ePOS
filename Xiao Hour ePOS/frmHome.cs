﻿using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xiao_Hour_ePOS
{
    public partial class frmHome : MaterialForm
    {
        public frmHome()
        {

            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.loginForm.Show();

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            lblUsername.Text = String.Format(lblUsername.Text, Program.currentLoginUsername);
        }

        private void tbsale_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = materialTabControl1.SelectedTab.Text;
        }
    }
}
