using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Media.Imaging;
using System.Windows.Controls;

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
        [Column("Count_of_tasks")]
        public int TasksCount { get; set; }

        /// <summary>
        /// This method determines the picture for the test result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="countofTasks"></param>
        /// <returns></returns>
        public Uri StatusOfResult(int result, int countofTasks)
        {
            Uri imageOfResult = new Uri("/Images/TestCompleteGood.png", UriKind.RelativeOrAbsolute);
            double ComputeResultStatus(int result, int countOfTasks)
            {
                return result / 1.0 / countOfTasks;
            }
            if (ComputeResultStatus(result, countofTasks) > 0.5 && ComputeResultStatus(result, countofTasks) <= 1)
            {
                 imageOfResult = new Uri("/Images/TestCompleteGood.png", UriKind.RelativeOrAbsolute);
                 return imageOfResult;
            }
            else if (ComputeResultStatus(result, countofTasks) >= 0.4 && ComputeResultStatus(result, countofTasks) <= 0.5)
            {
                imageOfResult = new Uri("/Images/TestCompleteNotBad.png", UriKind.RelativeOrAbsolute);
                 return imageOfResult;
            }
            else if (ComputeResultStatus(result, countofTasks) < 0.4)
            {
                imageOfResult = new Uri("/Images/TestCompleteBad.png", UriKind.RelativeOrAbsolute);
                return imageOfResult;
            }
            return imageOfResult;
        }

    }
}
