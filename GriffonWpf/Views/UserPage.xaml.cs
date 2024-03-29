﻿using GriffonWpf.ViewModels;
using GriffonWpf.Views.Base;
using GriffonWpfClassLibrary.Entities;
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

namespace GriffonWpf.Views
{
    /// <summary>
    /// Logique d'interaction pour UserPage.xaml
    /// </summary>
    public partial class UserPage : BasePage
    {
        private UserPageViewModel vm;

        public UserPage()
        {
            InitializeComponent();
            vm = new UserPageViewModel(this);
            this.DataContext = vm;
            this.BindElements();
        }

        private void BindElements()
        {
            this.Loaded += UserPage_Loaded;
        }

        private void UserPage_Loaded(object sender, RoutedEventArgs e)
        {
            //TextBlock txtB = new TextBlock();
            //txtB.Text = "Welcome from code";
            //Grid.SetRow(txtB, this.mainContainer.RowDefinitions.Count / 2);
            //Grid.SetColumn(txtB, this.mainContainer.ColumnDefinitions.Count / 2);
            //this.mainContainer.Children.Add(txtB);
        }
    }
}
