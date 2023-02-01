using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace MUD
{
    class Program
    {
        public static MongoClient client;
        public static IMongoDatabase database;
        // create seralized object for users
        public static IMongoCollection<String> users;

        static void Main(string[] args)
        {
            /*
            MongoClientSettings settings = MongoClientSettings.FromConnectionString("mongodb+srv://admin:password9876@mud.f2j6dzf.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            client = new MongoClient(settings);
            database = client.GetDatabase("mud");
            users = database.GetCollection("users");
            */

            Console.WriteLine("Hello, Welcome to GAME.");
            bool isNewUser = Utilities.YesNoInput("Are you a new user?");
            if (isNewUser)
            {
                Console.WriteLine("Very well, create your account.");
                String username = Utilities.StringInput("Choose a username");
                // check if username is taken
                String password = Utilities.StringInput("Choose a password");
                // create user
            }
            else
            {
                String username = Utilities.StringInput("Username");
                // check if username is taken
                String password = Utilities.StringInput("Password");
                
                database.GetCollection("users")
                // check if password is correct for the user
            }

            
        }
    }
}