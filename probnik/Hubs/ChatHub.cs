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
            private ApplicationContext db;

        public ChatHub(ApplicationContext context)
        {
            db = context;
        }
        public async Task SendMessage(string userId,string message,DateTime date)
        {
            Messages messages = new Messages { id = userId,Message=message,Date=date};
            db.Messages.Add(messages);
            db.SaveChanges();
            await Clients.All.SendAsync("ReceiveMessage", message, userId);
        }
    }
}