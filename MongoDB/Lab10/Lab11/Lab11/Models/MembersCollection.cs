using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace Lab11.Models
{
    public class MembersCollection
    {
        public ObjectId _id { get; set; }
        public string uid { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
    }
}