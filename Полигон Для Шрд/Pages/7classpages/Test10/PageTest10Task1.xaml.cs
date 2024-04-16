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
using Полигон_Для_Шрд.Pages._7classpages.Test1;
using Полигон_Для_Шрд.Classes;


namespace Полигон_Для_Шрд.Pages._7classpages.Test10
{
    /// <summary>
    /// Логика взаимодействия для PageTest10Task1.xaml
    /// </summary>
    public partial class PageTest10Task1 : Page
    {
        public PageTest10Task1()
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
                NavigationService.Navigate(new PageTest10Task2());
            }
        }
    }
}
