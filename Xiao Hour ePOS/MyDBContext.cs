using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xiao_Hour_ePOS.Models;

namespace Xiao_Hour_ePOS
{
    public class MyDBContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            optionsBuilder.UseSqlite($"Data Source={path}\\XiaoHourEPOS.db;");



        }

     

        public DbSet<UserModel> Users{ get; set; }

    }
}
