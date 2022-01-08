﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AST_Code_Generation
{
    /// <summary>
    /// Interaction logic for GaussianArrayWindow.xaml
    /// </summary>
    public partial class GaussianArrayWindow : Window
    {
        private GaussianArrayNode n;
        public GaussianArrayWindow(GaussianArrayNode node)
        {
            InitializeComponent();
            this.n = node;
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            this.n.Title = this.Value.Text;
            //this.n.Variance = this.Value2.Text;
            //this.Visibility = Visibility.Hidden;
            this.Hide();
            this.Close();
        }

    }
}
