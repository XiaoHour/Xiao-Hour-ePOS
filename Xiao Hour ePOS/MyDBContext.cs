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
            string startupPath = System.IO.Directory.GetCurrentDirectory().Replace("bin", ",").Split(',')[0];
            string last_character = startupPath.Substring(startupPath.Length - 1, 1);
            
            if (last_character != "\\")
            {
                startupPath = startupPath + "\\";
            }
           

            optionsBuilder.UseSqlite($"Data Source={startupPath}XiaoHourEPOS.db;");
        }

        public DbSet<UserModel> Users{ get; set; }

    }
}
