using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab11.Models
{
    public class EditMemberResponse
    {
        public bool ok { get; set; }
        public string errMsg { get; set; }

        public EditMemberResponse()
        {
            this.ok = true;
            this.errMsg = "";
        }
    }
}