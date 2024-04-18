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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Полигон_Для_Шрд.Classes;
using Полигон_Для_Шрд.Windows;

namespace Полигон_Для_Шрд
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRegestration_Click(object sender, RoutedEventArgs e)
        {
            ApplicationContext db = new ApplicationContext();
            db.Database.EnsureCreated();
            string login = loginInput.Text;
            string password = passwordInput.Password;
            string passwordCheck = passwordInputCheck.Password;
            if (loginInput.Text == "" || passwordInput.Password == "" || passwordInputCheck.Password == "")
            {
                MessageBox.Show("Заполните все поля ввода", "Ошибка регистрации", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (password != passwordCheck)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка регистрации", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (db.Users.Any(user => user.Login == login))
            {
                MessageBox.Show("Такой логин уже существует", "Ошибка регистрации", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (rdBtnSevenClass.IsChecked == false && rdBtnEightClass.IsChecked == false && rdBtnNineClass.IsChecked == false)
            {
                MessageBox.Show("Выбирите свой класс", "Ошибка регистрации", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (rdBtnSevenClass.IsChecked == true)
                {
                    User user = new User();
                    user.Login = login;
                    user.Password = password;
                    user.Class = 7;
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                if (rdBtnEightClass.IsChecked == true)
                {
                    User user = new User();
                    user.Login = login;
                    user.Password = password;
                    user.Class = 8;
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                if (rdBtnNineClass.IsChecked == true)
                {
                    User user = new User();
                    user.Login = login;
                    user.Password = password;
                    user.Class = 9;
                    db.Users.Add(user);
                    db.SaveChanges();
                }
            }
        }
        private void signIn_Click(object sender, RoutedEventArgs e)
        {
            SignInWindow signInWindow = new SignInWindow();
            signInWindow.Show();
            this.Close();
        }

        private void chkBoxShowPassword_Checked(object sender, RoutedEventArgs e)
        {
             passwordInputCheckVisible.Visibility = Visibility.Visible;
             passwordInput.Visibility = Visibility.Collapsed;
             passwordInputCheckVisible.Text = passwordInput.Password;
        }

        private void chkBoxShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            passwordInput.Password = passwordInputCheckVisible.Text;
            passwordInput.Visibility = Visibility.Visible;
            passwordInputCheckVisible.Visibility = Visibility.Collapsed;
            passwordInput.Focus();
        }
    }
}
