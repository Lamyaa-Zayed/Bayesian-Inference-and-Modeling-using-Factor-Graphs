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
    /// Interaction logic for InferWindow.xaml
    /// </summary>
    public partial class InferWindow : Window
    {
        private InferNode n;
        public InferWindow(InferNode node)
        {
            InitializeComponent();
            this.n = node;
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            n.EngineName = this.Value1.Text;
            n.Type = this.Value2.Text;
            n.Observale = this.Value3.Text;
            //this.Visibility = Visibility.Hidden;
            this.Hide();
            this.Close();
        }
    }
}
