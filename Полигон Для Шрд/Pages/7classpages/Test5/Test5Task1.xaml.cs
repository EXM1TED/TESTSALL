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
using Полигон_Для_Шрд.Classes;
using Полигон_Для_Шрд.Pages._7classpages.Test4;

namespace Полигон_Для_Шрд.Pages._7classpages.Test5
{
    /// <summary>
    /// Логика взаимодействия для Test5Task1.xaml
    /// </summary>
    public partial class Test5Task1 : Page
    {
        public Test5Task1()
        {
            InitializeComponent();
            User user = new User();
            user = UserSave.userSave;
            ResultOfTest result = new ResultOfTest();
            result.Result = 0;
            result.UserId = user.UserId;
            result.TestName = "Строение вещества и Изменение объёма при нагревании";
            result.TasksCount = 9;
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
                NavigationService.Navigate(new Test5Task2());
            }
            if (checkBoxNep.IsChecked == true
                && checkBoxHao.IsChecked == true)
            {
                SaveResult.resultOfTest.Result++;
            }
        }
    }
}
