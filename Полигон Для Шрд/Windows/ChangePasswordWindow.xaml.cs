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
    /// Логика взаимодействия для ChangePasswordWindow.xaml
    /// </summary>
    public partial class ChangePasswordWindow : Window
    {
        public ChangePasswordWindow()
        {
            InitializeComponent();
        }

        private void btnConfirmChanges_Click(object sender, RoutedEventArgs e)
        {
            string login = loginInput.Text;
            string password = passwordInput.Password;
            string passwordCheck = passwordInputCheck.Password;
            ApplicationContext db = new ApplicationContext();
            var users = db.Users.Where(u => u.Login == login).ToList();
            if (login == string.Empty)
            {
                    MessageBox.Show("Заполните поле: Логни", "Ошибка смена пароля", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (users.Count == 1) 
                {
                    if (password == string.Empty || passwordCheck == string.Empty)
                    {
                        MessageBox.Show("Заполните поля ввода пароля", "Ошибка смена пароля", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        if (password == passwordCheck)
                        { 
                            foreach (var user in users)
                            {
                                user.Password = password;
                                db.Users.Update(user);
                                db.SaveChanges();
                            }
                            MessageBox.Show("Пароль успешно изменён", "Смена пароля", MessageBoxButton.OK, MessageBoxImage.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Пароли не совпадают", "Ошибка смена пароля", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Такого логина не существует", "Ошибка смена пароля", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void chkBoxShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            passwordInputVisible.Visibility = Visibility.Visible;
            passwordInput.Visibility = Visibility.Collapsed;
            passwordInputCheck.Visibility = Visibility.Collapsed;
            passwordInputCheckVisible.Visibility = Visibility.Visible;
            passwordInputVisible.Text = passwordInput.Password;
            passwordInputCheckVisible.Text = passwordInputCheck.Password;
        }

        private void chkBoxShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            passwordInput.Password = passwordInputVisible.Text;
            passwordInputCheck.Password = passwordInputCheckVisible.Text;
            passwordInput.Visibility = Visibility.Visible;
            passwordInputVisible.Visibility = Visibility.Collapsed;
            passwordInputCheck.Visibility = Visibility.Visible;
            passwordInputCheckVisible.Visibility = Visibility.Collapsed;
            passwordInput.Focus();
        }
    }
}
