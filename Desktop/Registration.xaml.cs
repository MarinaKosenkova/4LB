using System.Windows;
using System.Windows.Controls;
using System.Text.RegularExpressions;
using Desktop.Repository;
using System;

namespace Desktop
{
    public partial class Registration : Window
    {
        private UserRepository _userRepository;
        public Registration()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void UsernameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (UsernameTextBox.Text == "введите имя пользователя")
            {
                UsernameTextBox.Text = "";
                UsernameTextBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void UsernameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text))
            {
                UsernameTextBox.Text = "введите имя пользователя";
                UsernameTextBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void EmailTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (EmailTextBox.Text == "exam@yandex.ru")
            {
                EmailTextBox.Text = "";
                EmailTextBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void EmailTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                EmailTextBox.Text = "exam@yandex.ru";
                EmailTextBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void PasswordTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordTextBox.Text == "введите пароль")
            {
                PasswordTextBox.Text = "";
                PasswordTextBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void PasswordTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                PasswordTextBox.Text = "введите пароль";
                PasswordTextBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void ConfirmPasswordTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (ConfirmPasswordTextBox.Text == "повторите пароль")
            {
                ConfirmPasswordTextBox.Text = "";
                ConfirmPasswordTextBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void ConfirmPasswordTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ConfirmPasswordTextBox.Text))
            {
                ConfirmPasswordTextBox.Text = "повторите пароль";
                ConfirmPasswordTextBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            // Валидация имени пользователя
            if (UsernameTextBox.Text == "введите имя пользователя" || string.IsNullOrWhiteSpace(UsernameTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите имя пользователя.");
                return;
            }

            // Валидация адреса электронной почты if (EmailTextBox.Text == "exam@yandex.ru" || string.IsNullOrWhiteSpace(EmailTextBox.Text) || !IsValidEmail(EmailTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите корректный адрес электронной почты.");
                return;
            }

            // Валидация пароля
            if (PasswordTextBox.Text == "введите пароль" || string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите пароль.");
                return;
            }

            // Валидация подтверждения пароля
            if (ConfirmPasswordTextBox.Text == "повторите пароль" || string.IsNullOrWhiteSpace(ConfirmPasswordTextBox.Text) || ConfirmPasswordTextBox.Text != PasswordTextBox.Text)
            {
                MessageBox.Show("Пароли не совпадают.");
                return;
            }

            try
            {
                // Используем экземпляр _userRepository для вызова метода Register
                _userRepository.Register(UsernameTextBox.Text, EmailTextBox.Text, PasswordTextBox.Text);
                MessageBox.Show("Регистрация прошла успешно!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

                // Открытие главного окна
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

                // Закрытие текущего окна регистрации
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка регистрации", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            // Простейшая валидация email с использованием регулярных выражений
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
