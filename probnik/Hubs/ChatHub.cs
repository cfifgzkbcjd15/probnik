using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using probnik.Data;
using probnik.Models;
using System;
using System.Threading.Tasks;

namespace probnik.Hubs
{
    public class ChatHub : Hub
    {
            //private ApplicationContext db;
            //private readonly ILogger<ChatHub> _logger;
            //UserManager<User> _userManager;
            //RoleManager<IdentityRole> _roleManager;

            //public ChatHub(ILogger<ChatHub> logger, ApplicationContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
            //{
            //    _logger = logger;
            //    db = context;
            //    _userManager = userManager;
            //    _roleManager = roleManager;
            //}
            public async Task SendMessage(string message,string userId)
        {
            //Messages messages = new Messages { id = userId,Message=message,Fromm=from,Date=data };
            //db.Messages.Add(messages);
            //await db.SaveChangesAsync();,string from, DateTime data
            await Clients.All.SendAsync("ReceiveMessage", message, userId);
        }
    }
}