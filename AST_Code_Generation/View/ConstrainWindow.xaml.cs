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
    /// Interaction logic for ConstrainWindow.xaml
    /// </summary>
    public partial class ConstrainWindow : Window
    {
        private ConstrainNode n;

        public ConstrainWindow(ConstrainNode node)
        {
            InitializeComponent();
            this.n = node;
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            n.Title = this.Value.Text;
            this.Hide();
            this.Close();
        }
    }
}
