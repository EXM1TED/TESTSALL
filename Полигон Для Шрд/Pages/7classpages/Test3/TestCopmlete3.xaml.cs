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

namespace Полигон_Для_Шрд.Pages._7classpages.Test3
{
    /// <summary>
    /// Логика взаимодействия для TestCopmlete3.xaml
    /// </summary>
    public partial class TestCopmlete3 : Page
    {
        public TestCopmlete3()
        {
            InitializeComponent();
            User user = new User();
            user = UserSave.userSave;
            ApplicationContext db = new ApplicationContext();
            ResultOfTest result = new ResultOfTest();
            result = SaveResult.resultOfTest;
            db.ResultsOfTest.Add(result);
            db.SaveChanges();
            var results = db.ResultsOfTest.Where(r => r.UserId == user.UserId && r.TestName == "Наблюдения, опыты, измерения, гипотеза, эксперимент").ToList();
            foreach (var test in results)
            {
                ImageResult.Source = new BitmapImage(result.StatusOfResult(test.Result, test.TasksCount));
                txtBlcokTestCompleteLabel.Text = $"Вы завершили тест '{test.TestName}'!";
                txtBlockResult.Text = $"Ваш результат: {test.Result} из {test.TasksCount}";
            }
        }

        private void btnGoMainMenu_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Window taskWindow = Window.GetWindow(this);
            taskWindow.Close();
        }
    }
}
