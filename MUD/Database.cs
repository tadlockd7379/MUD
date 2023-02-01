using MongoDB.Driver;

namespace MUD
{
    class Database
    {
        private string connectionString = "mongodb+srv://admin:<password>@mud.f2j6dzf.mongodb.net/?retryWrites=true&w=majority";
        public MongoClient client;
        public IMongoDatabase database;
        public IMongoCollection<User> users;

        public Database()
        {
            MongoClientSettings settings = MongoClientSettings.FromConnectionString(connectionString);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            client = new MongoClient(settings);
            database = client.GetDatabase("mud");
            users = database.GetCollection<User>("users");
            if (users == null)
            {
                database.CreateCollection("users");
                users = database.GetCollection<User>("users");
            }
        }
    }
}
