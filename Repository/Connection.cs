using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Driver;

namespace Repository
{
    public class Connection
    {
        public string user { get; set; }
        public string password { get; set; }

        public string uri
        {
            get { return string.Format("mongodb://{0}:{1}@ds061767.mongolab.com:61767/meuapp",this.user,this.password); }
        }

        private MongoUrl url;
        private MongoClient client;
        private MongoServer server;
        public MongoDatabase db;
        public Connection(string user, string password)
        {
            this.user = user;
            this.password = password;
             url = new MongoUrl(uri);
             client = new MongoClient(url);
             server = client.GetServer();
             db = server.GetDatabase(url.DatabaseName);
        }
    }
}
