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
    /// Логика взаимодействия для ChangeClassWindow.xaml
    /// </summary>
    public partial class ChangeClassWindow : Window
    {
        public ChangeClassWindow()
        {
            InitializeComponent();
        }

        private void btnConfirmChanges_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user = UserSave.userSave;
            ApplicationContext db = new ApplicationContext();
            try
            {
                int newClass = Convert.ToInt32(classInput.Text);
                if (newClass < 7 || newClass > 9)
                {
                    MessageBox.Show($"Недопустимый класс: {newClass}",
                        "Ошибка по смена класса",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
                else
                {
                    user.Class = newClass;
                    db.Users.Update(user);
                    db.SaveChanges();
                    var resultApplication = MessageBox.Show("Класс успешно изменен\nНеобходимо перезапустить приложение",
                        "Изменение клсаа",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                    if (resultApplication == MessageBoxResult.OK)
                    {
                        Application.Current.Shutdown();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Нужно указать только класс",
                    "Ошибка по смене пароля",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }
    }
}
