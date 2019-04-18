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

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Submitting password:" + uxPassword.Text);
        }

        private void txtChangeuxName(object sender, TextChangedEventArgs e)
        {
            //TextBox box = sender as TextBox;
            //this.uxSubmit.IsEnabled = box.Text.Length > 100;
            if (uxName.Text.Length > 0)
            {
                if (uxPassword.Text.Length > 0)
                {
                    this.uxSubmit.IsEnabled = true;
                }
                else
                {
                    this.uxSubmit.IsEnabled = false;
                }
            }
            else
            {
                this.uxSubmit.IsEnabled = false;
            }

        }

        //private void txtChangeuxPassword(object sender, TextChangedEventArgs e)
        //{
        //    TextBox box1 = sender as TextBox;
        //    this.uxSubmit.IsEnabled = box1.Text.Length > 0;
        //}
    }
}
