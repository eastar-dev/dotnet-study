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

namespace _0812UseCheckBoxes
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
        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            ShowHobbies();
        }

        private void ShowHobbies()
        {
            Console.WriteLine("당신의 취미는:");
            if (chkReading.IsChecked == true) Console.WriteLine("    독서");
            if (chkReading.IsChecked == null) Console.WriteLine("    (독서?)");
            if (chkHiking.IsChecked == true) Console.WriteLine("    등산");
            if (chkHiking.IsChecked == null) Console.WriteLine("    (등산?)");
            if (chkFishing.IsChecked == true) Console.WriteLine("    낚시");
            if (chkFishing.IsChecked == null) Console.WriteLine("    (낚시?)");
            if (chkListeningToMusic.IsChecked == true) Console.WriteLine("    음악 감상");
            if (chkListeningToMusic.IsChecked == null) Console.WriteLine("    (음악 감상?)");
            if (chkWatchingMovie.IsChecked == true) Console.WriteLine("    영화 감상");
            if (chkWatchingMovie.IsChecked == null) Console.WriteLine("    (영화 감상?)");
            Console.WriteLine();
        }
    }
}
