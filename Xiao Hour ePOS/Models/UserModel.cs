using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xiao_Hour_ePOS.Models
{

    [Table("tbl_user")]
    public class UserModel
    {
        [Key]
        public int id { get; set; }

        public string username { get; set; } = "";
        public string password { get; set; } = "";
        public string gender{ get; set; } = "Male";
        public string fullname{ get; set; } = "";
 
 
    }
}
