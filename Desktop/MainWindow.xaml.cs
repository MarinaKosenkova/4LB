using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Desktop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PasswordTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (passwordTextBox.Text == "введите пароль")
            {
                passwordTextBox.Text = "";
                passwordTextBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void PasswordTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                passwordTextBox.Text = "введите пароль";
                passwordTextBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void EmailTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (emailTextBox.Text == "exam@yandex.ru")
            {
                emailTextBox.Text = "";
                emailTextBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void EmailTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                emailTextBox.Text = "exam@yandex.ru";
                emailTextBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void OpenRegistration_Click(object sender, RoutedEventArgs e)
        {
            Registration secondWindow = new Registration();
            secondWindow.Show();
            this.Close();
        }

        private void passwordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PasswordTextBox_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void PasswordTextBox_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            Main_empty thirdWindow = new Main_empty();
            thirdWindow.Show();
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
