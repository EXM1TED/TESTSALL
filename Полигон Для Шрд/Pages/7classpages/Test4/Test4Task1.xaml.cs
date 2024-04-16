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
using Полигон_Для_Шрд.Classes;
namespace Полигон_Для_Шрд.Pages._7classpages.Test4
{
    /// <summary>
    /// Логика взаимодействия для Test4Task1.xaml
    /// </summary>
    public partial class Test4Task1 : Page
    {
        public Test4Task1()
        {
            InitializeComponent();
            User user = new User();
            user = UserSave.userSave;
            ResultOfTest result = new ResultOfTest();
            result.Result = 0;
            result.UserId = user.UserId;
            result.TestName = "Цена деления шкалы и точность погрешности измерения";
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
                NavigationService.Navigate(new Test4Task2());
            }
            if (rdButtonCorrectAnswer.IsChecked == true)
            {
                SaveResult.resultOfTest.Result++;
            }
        }
    }
}
