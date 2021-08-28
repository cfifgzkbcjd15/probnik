using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using probnik.Data;
using Microsoft.AspNetCore.Identity;

namespace probnik.ViewModels
{ 
    public class UserViewModel
    {
        //public long Id { get; set; }
        //public List<long> GroupsId { get; set; }
        //public string userId { get; set; }
        //public List<IdentityRole> Roles { get; set; }
        public bool IsSelected { get; set; }
        public User User { get; set; }
        //public string Name { get; set; }

    }
}