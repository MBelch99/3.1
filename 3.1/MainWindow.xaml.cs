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

namespace _3._1
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

        private void btSuma_Click(object sender, RoutedEventArgs e)
        {
            float a = float.Parse(tbA.Text);
            float b = float.Parse(tbB.Text);
            lbWynik.Content = (a + b);
        }

        private void btRoznica_Click(object sender, RoutedEventArgs e)
        {
            float a = float.Parse(tbA.Text);
            float b = float.Parse(tbB.Text);
            lbWynik.Content = (a - b);
        }

        private void btIloczyn_Click(object sender, RoutedEventArgs e)
        {
            float a = float.Parse(tbA.Text);
            float b = float.Parse(tbB.Text);
            lbWynik.Content = (a * b);
        }

        private void btIloraz_Click(object sender, RoutedEventArgs e)
        {
            float a = float.Parse(tbA.Text);
            float b = float.Parse(tbB.Text);
            if (b != 0)
            {
                lbWynik.Content = (a / b);
            }
            else
            {
                lbWynik.Content = "Nie dziel przez 0";
                MessageBox.Show("Nie dziel przez 0");
            }
        }
    }
}
