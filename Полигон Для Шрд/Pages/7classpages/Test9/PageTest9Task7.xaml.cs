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
using Полигон_Для_Шрд.Pages._7classpages.Test10;
using Полигон_Для_Шрд.Classes;
namespace Полигон_Для_Шрд.Pages._7classpages.Test9
{
    /// <summary>
    /// Логика взаимодействия для PageTest9Task7.xaml
    /// </summary>
    public partial class PageTest9Task7 : Page
    {
        public PageTest9Task7()
        {
            InitializeComponent();
        }
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoForward)
            {
                this.NavigationService.GoForward();
            }
            else
            {
                NavigationService.Navigate(new PageTest9Task8());
            }
            if (rdButtonCorrectAnswer.IsChecked == true)
            {
                SaveResult.resultOfTest.Result++;
            }
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
