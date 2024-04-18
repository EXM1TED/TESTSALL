using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
            User user = new User();
            user = UserSave.userSave;
            this.DataContext = user;
            ApplicationContext db = new ApplicationContext();
            db.Database.EnsureCreated();
            var result = db.ResultsOfTest.Where(u => u.UserId == user.UserId && u.TasksCount > 0).ToList();
            foreach (var test in result)
            {
                double StatusOfResult(int result, int countOfTasks)
                {
                    return result / 1.0 / countOfTasks;
                }
                TextBlock txtBlockResult = new TextBlock();
                if (test.Result == test.TasksCount)
                {
                    txtBlockResult.Foreground = Brushes.Green;
                }
                else if (StatusOfResult(test.Result, test.TasksCount) > 0.5 && StatusOfResult(test.Result, test.TasksCount) <= 0.9)
                {
                    txtBlockResult.Foreground = Brushes.Green;
                }
                else if (StatusOfResult(test.Result, test.TasksCount) >= 0.4 && StatusOfResult(test.Result, test.TasksCount) <= 0.5)
                {
                    txtBlockResult.Foreground = Brushes.Orange;
                }
                else if (StatusOfResult(test.Result, test.TasksCount) < 0.4)
                {
                    txtBlockResult.Foreground = Brushes.Red;
                }
                txtBlockResult.Text = $"{test.TestName}.\nРезультат: {test.Result} из {test.TasksCount}";
                txtBlockResult.TextWrapping = TextWrapping.Wrap;
                txtBlockResult.Margin = new Thickness(5);
                StackPanelForCompletedTests.Children.Add(txtBlockResult);
                ScrollViewerOfCompletedTests.Content = StackPanelForCompletedTests;
            }
        }

        private void MainMenu_Loaded(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user = UserSave.userSave;
            
        }

        private void btnMainWindowToTaskWindow_Click(object sender, RoutedEventArgs e)
        {
            TaksWindow taksWindow = new TaksWindow();
            taksWindow.Show();
            this.Close();
        }

        private void NavigateToProfile_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
