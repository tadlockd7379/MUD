using System;
using System.Linq;
using MongoDB.Driver;

namespace MUD
{
    public class User
    {
        public int id;
        public String username;
        public String password;

        public User(int id, String username, String password)
        {
            this.id = id;
            this.username = username;
            this.password = password;
        }

        public void Login()
        {
            String username = Utilities.StringInput("Username");

            User user = FindUserByUsername(username);
            if (user == null)
            {
                Console.WriteLine("Unknown User.");
                Login();
            }
            else
            {
                String password = Utilities.StringInput("Password");
                if (user.password != password)
                {
                    Console.WriteLine("Incorrect Password.");
                }
                else
                {
                    Console.WriteLine($"Welcome back, {username}.");
                    this.id = user.id;
                    this.username = user.username;
                    this.password = user.password;
                }
            }
        }

        public void CreateAccount()
        {
            String username = Utilities.StringInput("Choose a username");

            if (FindUserByUsername(username) != null)
            {
                Console.WriteLine("Username already taken!");
                CreateAccount();
            } 

            if (username.Length < 3)
            {
                Console.WriteLine("Username must be greater than 3 characters in length.");
            }

            String password = Utilities.StringInput("Choose a password");

            if (password.Length < 5)
            {
                Console.WriteLine("Password must be greater than 5 characters.");
                // STOPPED HERE
            }
        }

        public static User FindUserByUsername(String username)
        {
            return Program.db.users.Find(Builders<User>.Filter.Eq(usr => usr.username, username)).First();
        }
    }
}
