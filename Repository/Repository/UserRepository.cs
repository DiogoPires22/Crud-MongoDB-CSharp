using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
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

    }
}
