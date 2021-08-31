using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace probnik.Data
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public DateTime Year { get; set; }
        public byte[] Photo { get; set; }
        public Messages message { get; set; }
        public virtual AddGroupChat AddGroupChats { get; set; }

    }
}