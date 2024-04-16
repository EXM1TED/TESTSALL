using Microsoft.EntityFrameworkCore;
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
using Полигон_Для_Шрд.Windows;

namespace Полигон_Для_Шрд.Windows
{
    /// <summary>
    /// Логика взаимодействия для SignInWindow.xaml
    /// </summary>
    public partial class SignInWindow : Window
    {
        public SignInWindow()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            string login = loginInput.Text;
            string password = passwordInput.Password;
            ApplicationContext db = new ApplicationContext();
            db.Database.EnsureCreated();
            var checkUser = db.Users.FromSqlRaw($"SELECT Id, Login, Password, Class FROM Users WHERE Login = '{login}' and Password = '{password}'").ToList();
            if (checkUser.Count == 1)
            {
                User user = new User();
                user.Login = login;
                user.Password = password;
                var userId = db.Users.Where(u => u.Login == login && u.Password == password).ToList();
                foreach(var id in userId)
                {
                    user.UserId = id.UserId;
                }
                foreach (var className in checkUser)
                    user.Class = className.Class;
                UserSave.userSave = user;
                MessageBox.Show("Вы успешно вошли в систему", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void OpenRegistrationWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
