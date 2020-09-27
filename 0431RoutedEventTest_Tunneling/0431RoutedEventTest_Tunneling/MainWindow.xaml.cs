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

namespace _0431RoutedEventTest_Tunneling
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
        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine(string.Empty);
            Console.WriteLine("1 : PreviewMouseDown_Window");
        }
        private void PreviewMouseDownGrid(object sender,
        System.Windows.Input.MouseButtonEventArgs e)
        {
            Console.WriteLine("2 : PreviewMouseDown_Grid");
        }
        private void PreviewMouseDownButton(object sender,
        System.Windows.Input.MouseButtonEventArgs e)
        {
            Console.WriteLine("3 : PreviewMouseDown_Button");
        }
        private void PreviewMouseDownCanvas(object sender,
        System.Windows.Input.MouseButtonEventArgs e)
        {
            Console.WriteLine("4 : PreviewMouseDown_Canvas");
        }
        private void PreviewMouseDownEllipse(object sender,
        System.Windows.Input.MouseButtonEventArgs e)
        {
            Console.WriteLine("5 : PreviewMouseDown_Ellipse");
        }
    }
}
