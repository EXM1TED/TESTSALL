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
    /// Логика взаимодействия для ChangeLoginWindow.xaml
    /// </summary>
    public partial class ChangeLoginWindow : Window
    {
        public ChangeLoginWindow()
        {
            InitializeComponent();
        }

        private void btnConfirmChanges_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user = UserSave.userSave;
            ApplicationContext db = new ApplicationContext();
            string newLogin = loginInput.Text;
            user.Login = newLogin;
            var checkNewLogin = db.Users.Where(u => u.Login == newLogin).ToList();
            if (checkNewLogin.Count == 1)
            {
                MessageBox.Show("Такой логин уже существует", 
                    "Ошибка по смене логина", 
                    MessageBoxButton.OK, 
                    MessageBoxImage.Error);
            }
            else
            {
                user.Login = newLogin;
                db.Users.Update(user);
                db.SaveChanges();
                var restartApplication = MessageBox.Show("Логин успешно изменен\nНеобходимо перезапустить приложение",
                    "Смена логина",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                if (restartApplication == MessageBoxResult.OK)
                {
                    Application.Current.Shutdown();
                }
            }
        }
    }
}
