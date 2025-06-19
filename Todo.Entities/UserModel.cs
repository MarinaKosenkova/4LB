using System;

namespace Todo.Entities
{
    public class UserModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public UserModel(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }
    }
}
