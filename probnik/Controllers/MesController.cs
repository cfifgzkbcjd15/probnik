using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using probnik.Data;
using probnik.Hubs;
using probnik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace probnik.Controllers
{
    public class MesController : Controller
    {
        private readonly IHubContext<ChatHub> hC;
        private ApplicationContext db;
        public MesController(ApplicationContext context, IHubContext<ChatHub> hubContext)
        {
            hC = hubContext;
            db = context;

        }
        public ActionResult Mes()
        {
            return View();
        }
        [HttpPost]
        public async Task sendMessages(Messages msg,string age)
        {

            await hC.Clients.All.SendAsync(age);
        }
        public JsonResult getMessages(string idd)
        {
            List<Messages> messages = new List<Messages>();
            messages = db.Messages.ToList();
            return Json(messages);
        }
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult createStudent(Student std)
        //{
        //    context.Students.Add(std);
        //    context.SaveChanges();
        //    string message = "SUCCESS";
        //    return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        //}
    }
}
