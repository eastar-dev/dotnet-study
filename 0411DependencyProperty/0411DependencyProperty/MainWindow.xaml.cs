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

namespace _0411DependencyProperty
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
        public String UserText
        {
            get { return (String)GetValue(UserTextProperty); }
            set { SetValue(UserTextProperty, value); }
        }
        public static readonly DependencyProperty UserTextProperty
            = DependencyProperty.Register("UserText", typeof(String), typeof(MainWindow),
            new FrameworkPropertyMetadata(new PropertyChangedCallback(OnTextChangePropertyChanged)));
        private static void OnTextChangePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MainWindow userNamecontrol = d as MainWindow;
            string newText = (string)e.NewValue;
            string oldText = (string)e.OldValue;
            userNamecontrol.txtNewText.Text = newText;
            userNamecontrol.txtOldText.Text = oldText;
        }
        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            UserText = textBox1.Text;
        }
    }
}


