using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _0822UseContextMenu
{
    /// <summary>
    /// dlgGetInput.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class dlgGetInput : Window
    {
        public dlgGetInput()
        {
            InitializeComponent();
        }
        // 대화상자를 초기화하고, 대화상자의 타이틀명을 prompt가 가지고 있는 값으로 변경하고
        // TextBox(txtValue)의 Text를 초기값으로 변경한 후, 키보드 입력 포커스로 지정한다.
        public dlgGetInput(string prompt, string initial_value)
        {
            InitializeComponent();
            this.Title = prompt;
            txtValue.Text = initial_value;
            txtValue.Focus();
            txtValue.SelectAll();
        }

        // 대화상자(dialog)를 만들고, 나타나며, 결과를 반환하는 정적 메서드
        public static string ShowDialog(string prompt, string initial_value)
        {
            // 새로운 대화상자(dialog) 객체를 만든다.
            dlgGetInput dlg = new dlgGetInput(prompt, initial_value);
            // 대화상자를 나타낸다.
            bool? result = dlg.ShowDialog();
            // 사용자가 OK 버튼을 클릭하면 대화창의 TextBox(txtValue)의 텍스트를 반환한다.
            if (result == true) return dlg.txtValue.Text;
            return null;
        }


        // OK버튼이 클릭되었으면, 대화상자는 true 값을 반환한다.
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        // Cancel 버튼이 클릭되었으며, 대화상자를 닫는다.
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
