using System.Text.RegularExpressions;

namespace Desktop
{
    using System.Text.RegularExpressions;

    namespace Desktop
    {
        public static class InputValidator
        {
        // Метод для проверки имени пользователя public static bool IsUsernameValid(string username)
        {
            return !string.IsNullOrWhiteSpace(username) && username.Length >= 3;
        }

        // Метод для проверки адреса электронной почты
        public static bool IsEmailValid(string email)
        {
            // Регулярное выражение для проверки формата почты string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        // Метод для проверки пароля public static bool IsPasswordValid(string password)
        {
            return !string.IsNullOrWhiteSpace(password) && password.Length >= 6;
        }
}
} 


