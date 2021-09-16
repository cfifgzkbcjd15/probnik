using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using probnik.Data;
using probnik.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace probnik.Hubs
{
    public class ChatHub : Hub
    {
        public async  Task sendMessage(Messages msg)
        {
        }
    }
}