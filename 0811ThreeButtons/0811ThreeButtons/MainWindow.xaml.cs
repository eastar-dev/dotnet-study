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

namespace _0811ThreeButtons
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
        void OnClick1(object sender, RoutedEventArgs e)
        {
            btn1.Background = Brushes.Red;
            btn1.Content = "버튼1(빨강색)";
        }
        void OnClick2(object sender, RoutedEventArgs e)
        {
            btn2.Background = Brushes.Blue;
            btn2.Content = "버튼2(파란색)";
        }
        void OnClick3(object sender, RoutedEventArgs e)
        {
            btn1.Background = Brushes.Pink;
            btn1.Content = "버튼1(분홍색)";
            btn2.Background = Brushes.SkyBlue;
            btn2.Content = "버튼1(하늘색)";
            MessageBox.Show(DateTime.Now.ToString());
        }

        void onClickHello(object sender , RoutedEventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString() + "hello");
        }
    }
}