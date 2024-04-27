using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GroceryManagementSystem
{
    public class User
    {
        // Properties

        public int User_ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Isadmin { get; set; }
        public string Email { get; set; }

        //Constructor
        public User(int user_ID,string username, string password, bool isadmin, string email)
        {
            User_ID = user_ID;
            Username = username;
            Password = password;
            Isadmin = isadmin;
            Email = email;
        }
    }
}
