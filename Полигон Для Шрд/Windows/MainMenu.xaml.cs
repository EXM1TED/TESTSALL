﻿using Microsoft.EntityFrameworkCore;
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
                TextBlock txtBlockResult = new TextBlock();
                if (test.Result < 5)
                {
                    txtBlockResult.Foreground = Brushes.Red;
                }
                else if(test.Result >= 5) 
                {
                    txtBlockResult.Foreground= Brushes.Green;
                }
                txtBlockResult.Text = $"{test.TestName}.\nРезультат: {test.Result} из {test.TasksCount}";
                txtBlockResult.TextWrapping = TextWrapping.Wrap;
                lstBoxOfCompleTest.Items.Add(txtBlockResult);
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
