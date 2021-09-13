using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using probnik.Data;
using probnik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace probnik.Controllers
{
    public class MesController : Controller
    {
        
        private ApplicationContext db;
        public MesController(ApplicationContext context)
        {
            db = context;

        }
        public ActionResult Mes()
        {
            return View();
        }
        [HttpPost]
        public ActionResult sendMessages(Messages msg)
        {
            db.Messages.Add(msg);
            db.SaveChanges();
            string mes = "SUCCESS";
            return Json(new { Message = mes, System.Web.Mvc.JsonRequestBehavior.AllowGet });
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
