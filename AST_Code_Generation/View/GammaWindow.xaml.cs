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

namespace AST_Code_Generation
{
    /// <summary>
    /// Interaction logic for GammaWindow.xaml
    /// </summary>
    public partial class GammaWindow : Window
    {
        private GammaNode n;
        public GammaWindow(GammaNode node)
        {
            InitializeComponent();
            this.n = node;
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            this.n.Title = this.Value.Text;
            //this.n.Alpha = this.Value.Text;
            //this.n.Beta = this.Value2.Text;
            //this.Visibility = Visibility.Hidden;
            this.Hide();
            this.Close();
        }

    }
}
