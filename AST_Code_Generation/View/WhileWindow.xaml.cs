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
    /// Interaction logic for WhileWindow.xaml
    /// </summary>
    public partial class WhileWindow : Window
    {
        private WhileNode n;
        public WhileWindow(WhileNode node)
        {
            InitializeComponent();
            this.n = node;
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            this.n.r = new Range(Int32.Parse(this.Value1.Text), Int32.Parse(this.Value2.Text));
            this.Hide();
            this.Close();
        }
    }
}
