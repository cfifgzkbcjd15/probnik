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
    public class GroupChatViewModel
    {
        public GroupChat Chat { get; set; }
        public List<UserViewModel> UsersViewModel { get; set; }
        public GroupChatViewModel()
        {
            UsersViewModel =new List<UserViewModel>();
        }
    }
}