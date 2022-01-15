using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab11.Models
{
    public class AddMemberResponse
    {
        public bool ok { get; set; }
        public string errMsg { get; set; }

        public AddMemberResponse()
        {
            this.ok = true;
            this.errMsg = "";
        }
    }
}