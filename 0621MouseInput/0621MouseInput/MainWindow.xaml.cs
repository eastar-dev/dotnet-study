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

namespace _0621MouseInput
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ellipse1.MouseDown += new MouseButtonEventHandler(ellipse1_MouseDown);
            ellipse1.MouseMove += new MouseEventHandler(ellipse1_MouseMove);
            ellipse1.MouseUp += new MouseButtonEventHandler(ellipse1_MouseUp);
            MouseRightButtonDown += new MouseButtonEventHandler(Window1_MouseRightButtonDown);
        }

        void ellipse1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            label1.Content = "MouseDown";
            Mouse.Capture(ellipse1);
        }

        void ellipse1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Content = "MouseMove " + Mouse.GetPosition(ellipse1);
        }

        void ellipse1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            label1.Content = "MouseUp " + Mouse.GetPosition(ellipse1);
        }

        void Window1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Mouse.Capture(null);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (ellipse1.Fill == Brushes.Red)
                ellipse1.Fill = Brushes.Blue;
            else
                ellipse1.Fill = Brushes.Red;
        }
    }
}