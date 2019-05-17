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
using System.Text.RegularExpressions;

namespace Homework4
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

        private void uxInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            string zips = @"^\d{5}-\d{4}$|^\d{5}$|^[A-Z]\d[A-Z]\d[A-Z]\d$";

            string result = uxInput.Text;
            if (Regex.Match(result, zips).Success)
            {
                this.uxSubmit.IsEnabled = true;
            }
            else
            {
                this.uxSubmit.IsEnabled = false;
            }
        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zip Code:" + uxInput.Text);
        }
    }
}
