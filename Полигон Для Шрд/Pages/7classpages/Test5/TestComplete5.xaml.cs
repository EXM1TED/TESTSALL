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
using Полигон_Для_Шрд.Windows;
using Полигон_Для_Шрд.Classes;
namespace Полигон_Для_Шрд.Pages._7classpages.Test5
{
    /// <summary>
    /// Логика взаимодействия для TestComplete5.xaml
    /// </summary>
    public partial class TestComplete5 : Page
    {
        public TestComplete5()
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
            var results = db.ResultsOfTest.Where(r => r.UserId == user.UserId && r.TestName == "Строение вещества и Изменение объёма при нагревании").ToList();
            foreach (var test in results)
            {
                txtBlockResult.Text = $"Ваш результат: {test.Result} из 9";
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
