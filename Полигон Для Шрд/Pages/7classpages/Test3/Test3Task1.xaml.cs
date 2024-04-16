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
using Полигон_Для_Шрд.Pages._7classpages.Test3;

namespace Полигон_Для_Шрд.Pages._7classpages.Test3
{
    /// <summary>
    /// Логика взаимодействия для Test3Task1.xaml
    /// </summary>
    public partial class Test3Task1 : Page
    {
        public Test3Task1()
        {
            InitializeComponent();
            User user = new User();
            user = UserSave.userSave;
            ResultOfTest result = new ResultOfTest();
            result.Result = 0;
            result.UserId = user.UserId;
            result.TestName = "Наблюдения, опыты, измерения, гипотеза, эксперимент";
            result.TasksCount = 9;
            SaveResult.resultOfTest = result;
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoForward)
            {
                this.NavigationService.GoForward();
            }
            else
            {
                NavigationService.Navigate(new Test3Task2());
            }
            if (rdButtonCorrectAnswer.IsChecked == true)
            {
                SaveResult.resultOfTest.Result++;
            }
        }
    }
}
