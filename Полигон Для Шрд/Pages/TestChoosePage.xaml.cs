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
using Полигон_Для_Шрд.Pages._7classpages.Test1;
using Полигон_Для_Шрд.Pages._7classpages.Test3;
using Полигон_Для_Шрд.Pages._7classpages.Test4;
using Полигон_Для_Шрд.Pages._7classpages.Test5;
using Полигон_Для_Шрд.Pages._7classpages.Test6;
using Полигон_Для_Шрд.Pages._7classpages.Test7;
using Полигон_Для_Шрд.Pages._7classpages.Test9;
using Полигон_Для_Шрд.Pages._7classpages.Test10;
using Полигон_Для_Шрд.Pages.Test8;

namespace Полигон_Для_Шрд.Pages
{
    /// <summary>
    /// Логика взаимодействия для TestChoosePage.xaml
    /// </summary>
    public partial class TestChoosePage : Page
    {
        public TestChoosePage()
        {
            InitializeComponent();
        }
        private void btnTestAboutPhysic_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageTestTask1());
        }

        private void btnTest3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Test3Task1());
        }
        private void btnTest2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTest4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Test4Task1());
        }

        private void btnTest5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Test5Task1());
        }

        private void btnTest7_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Test7Task1());
        }

        private void btnTest8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTest9_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageTest9Task1());
        }

        private void btnTest6_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Test6Task1());
        }
    }
}
