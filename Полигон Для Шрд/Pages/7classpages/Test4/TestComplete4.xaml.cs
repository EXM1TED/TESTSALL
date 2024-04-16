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
namespace Полигон_Для_Шрд.Pages._7classpages.Test4
{
    /// <summary>
    /// Логика взаимодействия для TestComplete4.xaml
    /// </summary>
    public partial class TestComplete4 : Page
    {
        public TestComplete4()
        {
            InitializeComponent();
            User user = new User();
            user = UserSave.userSave;
            ApplicationContext db = new ApplicationContext();
            ResultOfTest result = new ResultOfTest();
            result = SaveResult.resultOfTest;
            db.ResultsOfTest.Add(result);
            db.SaveChanges();
            int saveResultForImage = 0;
            var results = db.ResultsOfTest.Where(r => r.UserId == user.UserId && r.TestName == "Цена деления шкалы и точность погрешности измерения").ToList();
            foreach (var test in results)
            {
                txtBlockResult.Text = $"Ваш результат: {test.Result} из 7";
                saveResultForImage = test.Result;
            }
            if (saveResultForImage < 5)
            {
                Uri uriImgaeBad = new Uri("/Images/ImagesTestCompleteBad.png", UriKind.RelativeOrAbsolute);
                ImageResult.Source = new BitmapImage(uriImgaeBad);
            }
            else
            {
                Uri uriImgaeGood = new Uri("/Images/TestCompleteGood.png", UriKind.RelativeOrAbsolute);
                ImageResult.Source = new BitmapImage(uriImgaeGood);
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
