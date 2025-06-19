using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Entities;

namespace Desktop.Repository
{
    internal class UserRepository
    {
        private static List<UserModel> _registeredUsers = new List<UserModel>();

        public void Register(string username, string email, string password)
        {
            // Проверка уникальности логина
            if (_registeredUsers.Exists(user => user.Username == username))
            {
                throw new Exception("Пользователь с таким именем уже существует.");
            }

            // Создание нового пользователя
            var newUser = new UserModel(username, email, password);
            _registeredUsers.Add(newUser);
        }

        public UserModel Authenticate(string username, string password)
        {
            var user = _registeredUsers.Find(u => u.Username == username && u.Password == password);
            if (user == null)
            {
                throw new Exception("Неверное имя пользователя или пароль.");
            }
            return user;
        }
    }
}
