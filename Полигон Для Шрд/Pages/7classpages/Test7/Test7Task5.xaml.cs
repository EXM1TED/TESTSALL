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
namespace Полигон_Для_Шрд.Pages._7classpages.Test7
{
    /// <summary>
    /// Логика взаимодействия для Test7Task5.xaml
    /// </summary>
    public partial class Test7Task5 : Page
    {
        public Test7Task5()
        {
            InitializeComponent();
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
                NavigationService.Navigate(new Test7Task6());
            }
            if (rdButtonCorrectAnswer.IsChecked == true)
            {
                SaveResult.resultOfTest.Result++;
            }
        }
    }
}
