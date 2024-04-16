using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Полигон_Для_Шрд.Pages._7classpages.Test5;
using Полигон_Для_Шрд.Classes;
namespace Полигон_Для_Шрд.Pages._7classpages.Test6
{
    /// <summary>
    /// Логика взаимодействия для Test6Task1.xaml
    /// </summary>
    public partial class Test6Task1 : Page
    {
        public Test6Task1()
        {
            InitializeComponent();
            User user = new User();
            user = UserSave.userSave;
            ResultOfTest result = new ResultOfTest();
            result.Result = 0;
            result.UserId = user.UserId;
            result.TestName = "Броуновское движение";
            SaveResult.resultOfTest = result;
        }
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoForward)
            {
                this.NavigationService.GoForward();
            }
            else
            {
                NavigationService.Navigate(new Test6Task2());
            }
            if (rdButtonCorrectAnswer.IsChecked == true)
            {
                SaveResult.resultOfTest.Result++;
            }
        }
    }
}
