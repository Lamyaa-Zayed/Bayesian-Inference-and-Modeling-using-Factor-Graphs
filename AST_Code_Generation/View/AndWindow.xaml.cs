using System;
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
    /// Interaction logic for AndWindow.xaml
    /// </summary>
    public partial class AndWindow : Window
    {
        private AndNode n;
        public AndWindow(AndNode node)
        {
            InitializeComponent();
            this.n = node;
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            this.n.Title = this.Value1.Text;
            //this.Visibility = Visibility.Hidden;
            this.Hide();
            this.Close();
        }
    }
}

