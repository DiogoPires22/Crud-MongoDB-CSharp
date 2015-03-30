using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using Repository.Models;

namespace Repository
{
    public class UserRepository
    {

        private Connection c = new Connection("diogopiresvr", "221292di");

        public MongoCursor GetAllUsers()
        {
            var x = c.db.GetCollection<User>("users");

            return x.FindAll();
        }


        public User GetUserById(string id)
        {
            var x = c.db.GetCollection<User>("users");

            var query_id = Query.EQ("_id", ObjectId.Parse(id));

            var u = x.FindOne(query_id);
            return u;
        }

    }
}
