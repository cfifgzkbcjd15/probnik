using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using probnik.Data;
using probnik.Models;
using probnik.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace probnik.Controllers
{
    [Authorize]
    public class MessagesController : Controller
    {
        private ApplicationContext db;
        private readonly ILogger<MessagesController> _logger;
        UserManager<User> _userManager;
        RoleManager<IdentityRole> _roleManager;

        public MessagesController(ILogger<MessagesController> logger, ApplicationContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _logger = logger;
            db = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userName = User.Identity.Name;

            ViewBag.Users = db.Users.ToList();
            ViewBag.Photo = db.Messages.Select(x => x.Photo).ToList();
            ViewBag.GroupChat = db.AddGroupChat.Distinct().ToList();

            //List<Messages> users = new List<Messages>();

            //await db.Messages
            //    .ForEachAsync(x => 
            //    {
            //        if(users.FirstOrDefault(g => x.id == g.id && x.Fromm == userName) == null && (x.Fromm == userName || x.id == id))
            //        {
            //            users.Add(x);
            //        }
            //    });

            return View(db.Messages.Where(x => x.id == id));
        }
        [Authorize]
        public async Task<IActionResult> Message(string id, string name, string Email, byte[] photo)
        {
            if (id != null)
            {
                Messages messages = await db.Messages
                    .FirstOrDefaultAsync(p => p.id == id && p.user.Name == name && p.user.Email == Email && p.user.Photo == photo);
                if (messages != null)
                {
                    var only = User.Identity.Name;
                    var idd = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    ViewBag.Message = db.Messages
                        .Where(x => (x.id == id && x.Fromm == only) || (x.Fromm == Email && x.id == idd))
                        .OrderBy(x => x.Date)
                        .ToList();
                    ViewBag.Users = db.Users
                        .Where(x => x.Id == id)
                        .ToList();
                    ViewBag.Mid = id;
                    ViewBag.Name = name;
                    ViewBag.Emaill = Email;
                    ViewBag.Photo = photo;
                    return View(messages);

                }
                else
                {
                    var only = User.Identity.Name;
                    var idd = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    ViewBag.Message = db.Messages
                        .Where(x => (x.id == id && x.Fromm == only) || (x.Fromm == Email && x.id == idd))
                        .OrderBy(x => x.Date)
                        .ToList();
                    ViewBag.Users = db.Users
                        .Where(x => x.Id == id)
                        .ToList();
                    ViewBag.Mid = id;
                    ViewBag.Name = name;
                    ViewBag.Emaill = Email;
                    ViewBag.Photo = photo;
                    return View();
                }


            }
            return NotFound();

        }
        [HttpPost]
        public async Task<IActionResult> Message(Messages messages, MessagesViewModel mvm)
        {
            if (mvm.Photo != null)
            {
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(mvm.Photo.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)mvm.Photo.Length);
                }
                // установка массива байтов
                messages.Photo = imageData;
            }
            if (mvm.Video != null)
            {
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(mvm.Video.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)mvm.Video.Length);
                }
                // установка массива байтов
                messages.Video = imageData;
            }

            db.Messages.Add(messages);
            await db.SaveChangesAsync();
            return RedirectToAction("/Message/Index/");
        }
        [HttpPost]
        public async Task<IActionResult> EditMessages(int? id)
        {
            if (id != null)
            {
                Messages messages = await db.Messages.FirstOrDefaultAsync(p => p.ProstoId == id);
                if (messages != null)
                {
                    db.Messages.Update(messages);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteMessage(string? id)
        {
            if (id != null)
            {
                Messages message = await db.Messages.FirstOrDefaultAsync(p => p.id == id);
                if (message != null)
                {
                    db.Messages.Remove(message);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Message");
                }
            }
            return NotFound();
        }
        //public async Task<IActionResult> GroupChat()
        //{
        //    return View();
        //}
        public async Task<IActionResult> EditGroupChat()
        {
            return View();
        }
        public async Task<IActionResult> GroupMessage(long? groupId,string? Name)
        {
            if (groupId != null)
            {
                GroupChat groupChat = await db.GroupChat.FirstOrDefaultAsync(p => p.addGroupChat.GroupId == groupId&&p.addGroupChat.Name==Name);
                if (groupChat != null)
                {
                    ViewBag.GroupId = groupId;
                    ViewBag.GroupChat = db.GroupChat.ToList();
                }
                return View();
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> GroupMessage(GroupChat groupChat)
        {
            db.GroupChat.Add(groupChat);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteGroupMessage(string? id)
        {
            if (id != null)
            {
                GroupChat groupChat = await db.GroupChat.FirstOrDefaultAsync(p => p.id == id);
                if (groupChat != null)
                {
                    db.GroupChat.Remove(groupChat);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Message");
                }
            }
            return NotFound();
        }
        public async Task<IActionResult> AddGroupChat()
        {
            var only = User.Identity.Name;
            ViewBag.Users = db.Users
                        .Where(x => x.Email != "admin@mail.com" &&x.Email != only)
                        .ToList();
            var Chat = db.AddGroupChat.ToList();
            if (Chat.Count() >= 1)
            {
                ViewBag.Chat = Chat.OrderBy(x => x.GroupId).LastOrDefault(x => x.GroupId != null).GroupId;
            }
            else
            {
                ViewBag.Chat = 0;
            }
            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddGroupChat(List<AddGroupChat> groupModels,string NameGroup)
        {
            foreach(var i in groupModels.Where(x=>x.userId!=null)) {
                i.Name = NameGroup;
                db.AddGroupChat.AddRange(i);
            }
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}