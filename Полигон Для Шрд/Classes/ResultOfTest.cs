using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Полигон_Для_Шрд.Classes
{
    [Table("Results")]
    public class ResultOfTest
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }
        [Column("User_Id")]
        public int UserId { get; set; }
        [Column("Name_of_test")]
        public string TestName { get; set; }    
        [Column("Result")]
        public int Result { get; set; }
    }
}
