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

namespace Полигон_Для_Шрд.Windows
{
    /// <summary>
    /// Логика взаимодействия для ProfileWindow.xaml
    /// </summary>
    public partial class ProfileWindow : Window
    {
        public ProfileWindow()
        {
            InitializeComponent();
            User user = new User();
            user = UserSave.userSave;
            this.DataContext = user;
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            ChangePasswordWindow changePasswordWindow = new ChangePasswordWindow();
            changePasswordWindow.Show();
        }

        private void btnChangeLogin_Click(object sender, RoutedEventArgs e)
        {
            ChangeLoginWindow changeLoginWindow = new ChangeLoginWindow();
            changeLoginWindow.Show();
        }

        private void btnChangeClass_Click(object sender, RoutedEventArgs e)
        {
            ChangeClassWindow changeClassWindow = new ChangeClassWindow();
            changeClassWindow.Show();
        }
    }
}
