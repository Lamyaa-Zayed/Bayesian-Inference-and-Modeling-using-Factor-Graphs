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

namespace AST_Code_Generation.View
{
    /// <summary>
    /// Interaction logic for ObservedGaussianWindow.xaml
    /// </summary>
    public partial class ObservedGaussianWindow : Window
    {
        private ObservedGaussianNode n;
        public ObservedGaussianWindow(ObservedGaussianNode node)
        {
            InitializeComponent();
            this.n = node;
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            //this.n.Title = this.Value.Text;
            this.n.Title = this.Value1.Text;
            this.n.ObservedValue = this.Value2.Text;
            //this.Visibility = Visibility.Hidden;
            this.Hide();
            this.Close();
        }
    }
}
