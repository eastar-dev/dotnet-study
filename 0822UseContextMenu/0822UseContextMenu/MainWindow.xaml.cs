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

namespace _0822UseContextMenu
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
        // Add New Siste 메뉴항목 클릭 시,리스트에 새 웹사이트를 추가
        private void mnuAddNewSite_Click(object sender, RoutedEventArgs e)
        {
            // Get the site's name and URL.
            string site_name = dlgGetInput.ShowDialog("Site name", "");
            if (site_name == null) return;
            string site_url = dlgGetInput.ShowDialog("URL", "");
            if (site_url == null) return;
            // Add the site to the list.
            Label name_label = new Label();
            name_label.Content = site_name;
            name_label.Width = 150;
            Label url_label = new Label();
            url_label.Content = site_url;
            url_label.Width = 150;
            StackPanel stack_panel = new StackPanel();
            stack_panel.Orientation = Orientation.Horizontal;
            stack_panel.Children.Add(name_label);
            stack_panel.Children.Add(url_label);
            ListBoxItem new_item = new ListBoxItem();
            new_item.Content = stack_panel;
            lstWebSites.Items.Add(new_item);
        }

        // Delete Site 메뉴항목 클릭 시, 현재 선택된 웹사이트를 삭제
        private void mnuDeleteSite_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem selected_item = (ListBoxItem)lstWebSites.SelectedItem;
            if (selected_item == null) return;
            StackPanel stack_panel = (StackPanel)selected_item.Content;
            Label site_label = (Label)stack_panel.Children[0];

            if (MessageBox.Show("Are you sure you want to delete " + site_label.Content,
                "Delete site?", MessageBoxButton.YesNo, MessageBoxImage.Question) ==
                MessageBoxResult.Yes)
            {
                lstWebSites.Items.Remove(selected_item);
            }
        }
    }
}