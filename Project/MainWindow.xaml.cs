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
        string passwordDummy = "";

        public MainWindow()
        {
            InitializeComponent();
            ShowPasswordLabel.Visibility = Visibility.Hidden;
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
            LoginPanel.Visibility           = Visibility.Hidden;
            PasswordRecoveryP1.Margin       = new Thickness(510,81,0,0);
            PasswordRecoveryP1.Visibility   = Visibility.Visible;
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

        private void PasswordTB_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PasswordTB.Password != "")
            {
                password = PasswordTB.Password;
            }
        }

        //ShowPasswordIcon

        private void ShowPassword_MouseEnter(object sender, MouseEventArgs e)
        {
            ShowPasswordLabel.Text = password;
            ShowPasswordLabel.Visibility = Visibility.Visible;
            PasswordTB.Password = passwordDummy;
            PasswordTB.IsEnabled = false;
        }

        private void ShowPassword_MouseLeave(object sender, MouseEventArgs e)
        {
            ShowPasswordLabel.Text  = "";
            ShowPasswordLabel.Visibility = Visibility.Hidden;
            PasswordTB.Password = password;
            LoginButton.Focus();
            PasswordTB.IsEnabled = true;
        }

        private void PR1SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            PasswordRecoveryP1.Visibility   = Visibility.Hidden;
            PasswordRecoveryP2.Margin       = new Thickness(510, 81, 0, 0);
            PasswordRecoveryP2.Visibility   = Visibility.Visible;
        }

        private void BackBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            BackBtn1.TextDecorations = TextDecorations.Underline;
            BackBtn2.TextDecorations = TextDecorations.Underline;
        }

        private void BackBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            BackBtn1.TextDecorations = null;
            BackBtn2.TextDecorations = null;
        }

        private void BackBtn_Click(object sender, MouseButtonEventArgs e)
        {
            PasswordRecoveryP1.Visibility   = Visibility.Hidden;
            PasswordRecoveryP2.Visibility   = Visibility.Hidden;
            LoginPanel.Visibility           = Visibility.Visible;

            string ghello = "SEND ME BOBZ";
            byte[] data = System.Text.Encoding.ASCII.GetBytes(ghello);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);
            Console.WriteLine(hash);
            
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
