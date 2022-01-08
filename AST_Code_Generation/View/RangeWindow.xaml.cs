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
    /// Interaction logic for RangeWindow.xaml
    /// </summary>
    public partial class RangeWindow : Window
    {
        private RangeNode n;
        public RangeWindow(RangeNode node)
        {
            InitializeComponent();
            this.n = node;
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            this.n.Title = this.Value.Text;
            //this.Visibility = Visibility.Hidden;
            this.Hide();
            this.Close();
        }
    }
}
