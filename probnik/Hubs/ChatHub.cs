using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using probnik.Data;
using probnik.Models;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace probnik.Hubs
{
    public class ChatsHub : Hub
    {
        
        public async  Task sendMessage(string user,string message,string myId,string userId)
        {
            await Clients.All.SendAsync(user,message,myId,userId);
            //await Clients.Clients(id,idd).SendAsync("ReceiveMessage", user, message);
        }
    }
}