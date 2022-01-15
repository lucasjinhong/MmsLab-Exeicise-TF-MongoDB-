using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab11.Models
{
    public class AddMemberRequest
    {
        public string uid { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
    }
}