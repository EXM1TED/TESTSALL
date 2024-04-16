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
namespace Полигон_Для_Шрд.Pages._7classpages.Test5
{
    /// <summary>
    /// Логика взаимодействия для Test5Task9.xaml
    /// </summary>
    public partial class Test5Task9 : Page
    {
        public Test5Task9()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (rdButtonCorrectAnswer.IsChecked == true)
            {
                SaveResult.resultOfTest.Result++;
            }
            NavigationService.Navigate(new TestComplete5());
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
