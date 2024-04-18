using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Полигон_Для_Шрд.Classes;
using Полигон_Для_Шрд.Windows;

namespace Полигон_Для_Шрд
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            this.ShutdownMode = ShutdownMode.OnLastWindowClose;
            ApplicationContext db = new ApplicationContext();
            bool checkUsers = db.Users.Any(u => u.UserId == 1);
            if (checkUsers)
            {
                SignInWindow signInWindow = new SignInWindow();
                signInWindow.Show();
            }
            else
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
        }
    }
}
