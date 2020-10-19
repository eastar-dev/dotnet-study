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

namespace _0622MouseWheel
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
        private void button1_MouseEnter(object sender, MouseEventArgs e)
        {
            label1.Content = "button1 MouseOver : " + button1.IsMouseOver.ToString();
        }
        private void ellipse1_MouseEnter(object sender, MouseEventArgs e)
        {
            label1.Content = "ellipse1 MouseOver : " + ellipse1.IsMouseOver.ToString();
        }
        private void button2_MouseEnter(object sender, MouseEventArgs e)
        {
            label1.Content = "button2 MouseDirectlyOver : " + button2.IsMouseDirectlyOver.ToString();
        }
        private void rectangle2_MouseEnter(object sender, MouseEventArgs e)
        {
            label1.Content = "rectangle2 MouseDirectlyOver : " + rectangle2.IsMouseDirectlyOver.ToString();
        }
        private void button1_MouseLeave(object sender, MouseEventArgs e)
        {
            label1.Content = "";
        }
        private void button2_MouseLeave(object sender, MouseEventArgs e)
        {
            label1.Content = "";
        }
        private void ellipse1_MouseLeave(object sender, MouseEventArgs e)
        {
            label1.Content = "button1 MouseOver : " + button1.IsMouseOver.ToString();
        }
        private void rectangle2_MouseLeave(object sender, MouseEventArgs e)
        {
            label1.Content = "button2 MouseDirectlyOver : " + button2.IsMouseDirectlyOver.ToString();
        }
        private void Window_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta == 120) label2.Content = Convert.ToInt32(label2.Content) + 1;
            else if (e.Delta == -120) label2.Content = Convert.ToInt32(label2.Content) - 1;
        }
    }
}