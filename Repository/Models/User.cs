using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;

namespace Repository.Models
{
   public class User
    {
        public ObjectId _id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }
}
