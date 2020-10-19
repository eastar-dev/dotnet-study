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

namespace _0611UseInput
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

        private void Window_Keyboard_KeyDown(object sender, KeyEventArgs e)
        {
            // label1.Content = "Keyboard.KeyDown";
            if (Keyboard.GetKeyStates(Key.Enter) == KeyStates.Down)
                label1.Content = "Enter 키가 눌려졌습니다.";
            else
                label1.Content = "Enter 키를 누르세요";
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            Label2.Content = "UIElement.KeyDown";
        }

        private void textBox1_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            textBox1.Text = "textBox1_PreviewKeyUp";
        }
    }
}