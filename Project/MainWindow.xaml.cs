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

namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string userName = "";
        string password = "";
        int usernameLabelHover = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void ForgotPasswordClick(object sender, MouseButtonEventArgs e)
        {
            LoginPanel.Visibility = Visibility.Hidden;
        }

        private void ForgotPasswordHover(object sender, MouseEventArgs e)
        {
            ForgotPassword.TextDecorations = TextDecorations.Underline;
        }

        private void ForgotPasswordLeave(object sender, MouseEventArgs e)
        {
            ForgotPassword.TextDecorations = null;
        }

        //Username

        private void UsernameLabelHover(object sender, MouseEventArgs e)
        {
            UsernameLabel.Visibility = Visibility.Hidden;
            usernameLabelHover = 1;
        }

        private void UsernameTB_Text_Changed(object sender, TextChangedEventArgs e)
        {
            userName = UsernameTB.Text;
        }

        private void UsernameTB_GotFocus(object sender, RoutedEventArgs e)
        {
            UsernameLabel.Visibility = Visibility.Hidden;
        }

        private void UsernameTB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (UsernameTB.IsFocused == false && (userName == "" || userName == null))
            {
                UsernameLabel.Visibility = Visibility.Visible;
            }
        }

        private void UsernameTB_MouseEnter(object sender, MouseEventArgs e)
        {
            UsernameLabel.Visibility = Visibility.Hidden;
        }

        private void UsernameTB_MouseLeave(object sender, MouseEventArgs e)
        {
            if (UsernameTB.IsFocused == false && (userName == "" || userName == null))
            {
                UsernameLabel.Visibility = Visibility.Visible;
            }
        }

        //Password

        private void PasswordLabelHover(object sender, MouseEventArgs e)
        {
            PasswordLabel.Visibility = Visibility.Hidden;
        }

        private void PasswordTB_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordLabel.Visibility = Visibility.Hidden;
        }

        private void PasswordTB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordTB.IsFocused == false && (password == "" || password == null))
            {
                PasswordLabel.Visibility = Visibility.Visible;
            }
        }

        private void PasswordTB_MouseEnter(object sender, MouseEventArgs e)
        {
            PasswordLabel.Visibility = Visibility.Hidden;
        }

        private void PasswordTB_MouseLeave(object sender, MouseEventArgs e)
        {
            if (PasswordTB.IsFocused == false && (password == "" || password == null))
            {
                PasswordLabel.Visibility = Visibility.Visible;
            }
        }

        private void PasswordTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            password = PasswordTB.Text;
        }
    }
}
