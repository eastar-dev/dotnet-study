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

namespace _0521Popup
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
        private void img_MouseEnter(object sender, MouseEventArgs e)
        {
            Image img = (Image)sender;
            imgFullScale.Source = img.Source;
            popFullScale.PlacementTarget = img;
            popFullScale.IsOpen = true;
        }

        private void img_MouseLeave(object sender, MouseEventArgs e)
        {
            popFullScale.IsOpen = false;
        }
    }
}
