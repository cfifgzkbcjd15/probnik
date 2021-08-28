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
        public async Task<IActionResult> CreateMessage(string id, string name, string Email, byte[] photo)
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
        public async Task<IActionResult> CreateMessage(Messages messages, MessagesViewModel mvm)
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
        public async Task<IActionResult> AddGroupChat()
        {
            //List<UserViewModel> usersmodel = new List<UserViewModel>();
            //GroupChatViewModel groupChatViewModel = new GroupChatViewModel();
            ////var roles = _userManager.GetRolesAsync(User);
            ////foreach(var i in db.Users.Include(x=>x.GroupChats).ToList())
            ////{
            ////    groupModel.Add(new UserViewModel() {
            ////        userId=i.Id,
            ////        Name=i.Name,
            ////        Roles=,
            ////        GroupsId =i.GroupChats.Select(x => x.GroupId).ToList() });
            ////}
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //groupChatViewModel.Chat = db.GroupChat.FirstOrDefault(x => x.userId == userId);
            //foreach (var i in db.Users.ToList())
            //{
            //    groupChatViewModel.UsersViewModel.Add(new UserViewModel() {User=i });
            //}
            //return View(usersmodel);
            var only = User.Identity.Name;
            ViewBag.Users = db.Users
                        .Where(x => x.Email != "admin@mail.com" &&x.Email != only)
                        .ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddGroupChat(string[] groupModels)
        {
            for (int i = 0; i < groupModels.Length; i += 3)
            {
                if (groupModels[i+1]  != null && groupModels[i]!=null) {
                db.GroupChat.AddRange(new GroupChat() { Creator = groupModels[1 + i], userId = groupModels[0 + i] });//db.GroupChat.AddRange(groupModels);
                }
            }
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}