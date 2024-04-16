using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Полигон_Для_Шрд.Classes
{
    [Table("Users")]
    public class User
    {
        [Column("Id")]
        [Key]
        public int UserId { get; set; }
        [Column("Login")]
        public string Login { get; set; }
        [Column("Password")]
        public string Password { get; set; }
        [Column("Class")]
        public int Class {  get; set; }
    }
}
