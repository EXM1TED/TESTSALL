﻿using System;
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
using Полигон_Для_Шрд.Pages._7classpages.Test1;

namespace Полигон_Для_Шрд.Pages.Test8
{
    /// <summary>
    /// Логика взаимодействия для Test8Task1.xaml
    /// </summary>
    public partial class Test8Task1 : Page
    {
        public Test8Task1()
        {
            InitializeComponent();
            User user = new User();
            user = UserSave.userSave;
            ResultOfTest result = new ResultOfTest();
            result.Result = 0;
            result.UserId = user.UserId;
            result.TestName = "Притяжение и отталкивание молекул";
            result.TasksCount = 6;
            SaveResult.resultOfTest = result;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoForward)
            {
                this.NavigationService.GoForward();
            }
            else
            {
                NavigationService.Navigate(new Test8Task1());
            }
        }
    }
}
