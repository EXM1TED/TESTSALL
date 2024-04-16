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
using System.Windows.Shapes;
using Полигон_Для_Шрд.Classes;
using Полигон_Для_Шрд.Pages;
using Полигон_Для_Шрд.Pages._8ClassPages;

namespace Полигон_Для_Шрд.Windows
{
    /// <summary>
    /// Логика взаимодействия для TaksWindow.xaml
    /// </summary>
    public partial class TaksWindow : Window
    {
        public TaksWindow()
        {
            InitializeComponent();
            User user = new User();
            user = UserSave.userSave;
            this.DataContext = user;

            if (user.Class == 7 )
            {
                PageOfTests.Navigate(new TestChoosePage());
            }
            if (user.Class == 8 ) 
            {
                PageOfTests.Navigate(new EightClassChooseTestPage());
            }
        }

        private void btnTest3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTest2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTest1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnReturnTaskWindowToMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Window taksWidnow = Window.GetWindow(this);
            taksWidnow.Close();
        }

        private void NavigateToProfile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnReturnTaskWindowToMainWindow_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
