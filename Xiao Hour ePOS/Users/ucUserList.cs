using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xiao_Hour_ePOS.Models;

namespace Xiao_Hour_ePOS.Users
{
    public partial class ucUserList : UserControl
    {
        public ucUserList()
        {
            InitializeComponent();
        }

        private void ucUserList_Load(object sender, EventArgs e)
        {
            MyDBContext db = new MyDBContext();
            List<UserModel> user_list;
            user_list = db.Users.ToList();

            foreach (var u in user_list)
            {
                ListViewItem row = new ListViewItem(u.username);

                row.SubItems.Add(u.fullname);
                row.SubItems.Add(u.gender);
                row.SubItems.Add("10/Jul/2020");

                lstUserList.Items.Add(row);
            }




            db.Dispose();
        }
    }
}
