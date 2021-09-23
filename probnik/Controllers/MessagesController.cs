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
using probnik.Hubs;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Routing;

namespace probnik.Controllers
{

    public class MessegaseModel
    {
        public List<AddGroupChat> AddGroupChats { get; set; }
        public List<User> User { get; set; }

    }


    [Authorize]
    public class MessagesController : Controller
    {

        private readonly IHubContext<ChatHub> hC;
        private ApplicationContext db;
        private readonly ILogger<MessagesController> _logger;
        UserManager<User> _userManager;
        RoleManager<IdentityRole> _roleManager;

        public MessagesController(ILogger<MessagesController> logger, ApplicationContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IHubContext<ChatHub> hubContext)
        {
            hC = hubContext;
            _logger = logger;
            db = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userName = User.Identity.Name;
            var list = db.AddGroupChat.ToList();
            var user = db.Users.ToList();
            //.Where(x => x.message != null)

            MessegaseModel model = new MessegaseModel()
            {
                AddGroupChats = list,
                User = user
            };

            ViewBag.Messages = db.Messages.ToList();
            //ViewBag.Users = db.Users.ToList();
            ViewBag.Photo = db.Messages.Select(x => x.Photo).ToList();
            ViewBag.AddGroupChat = db.AddGroupChat.Where(x => x.userId == id).ToList();
            ViewBag.GroupChat = db.GroupChat.ToList();
            return View(model);
        }   

        [Authorize]
        public IActionResult Message( string id, string name, string Email, byte[] photo)
        {
            
            if (id != null)
            {
                //Messages messages = await db.Messages
                //    .FirstOrDefaultAsync(p => p.id == id && p.user.Name == name && p.user.Email == Email && p.user.Photo == photo);
                //var only = User.Identity.Name;
                //var idd = User.FindFirstValue(ClaimTypes.NameIdentifier);
                //ViewBag.Message = db.Messages
                //    .Where(x => (x.id == id && x.Fromm == only) || (x.Fromm == Email && x.id == idd))
                //    .OrderBy(x => x.Date)
                //    .ToList();
                ViewBag.Users = db.Users
                    .Where(x => x.Id == id)
                    .ToList();
                ViewBag.Name = name;
                ViewBag.Email = Email;
                ViewBag.Mid = id;
                return View();
                
            }
            return NotFound();

        }
        [HttpPost]
        public async Task<ActionResult> sendMessages(Messages msg,string Email)
        {
            //if (photo != null)
            //{
            //    byte[] imageData = null;
            //    // считываем переданный файл в массив байтов
            //    using (var binaryReader = new BinaryReader(photo.OpenReadStream()))
            //    {
            //        imageData = binaryReader.ReadBytes((int)photo.Length);
            //    }
            //    // установка массива байтов
            //    msg.Photo = imageData;
            //}
            var idd = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var only = User.Identity.Name;
            //var messag = db.Messages.LastOrDefault(x => (x.id == msg.id && x.Fromm == only) || (x.Fromm == Email && x.id == idd));
            var mes = db.Messages.ToList();
            if (msg.Message != null)
            {
                db.Messages.Add(msg);
            }
            await db.SaveChangesAsync();
            string messagee = "SUCCESS";
            return Json(new { Messagee = messagee, System.Web.Mvc.JsonRequestBehavior.AllowGet });

        }
        public  JsonResult getMessages(string id,string Email)
        {
            var only = User.Identity.Name;
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            List<Messages> messages = new List<Messages>();
            messages = db.Messages.ToList();
            return Json(messages.Where(x => (x.id == id && x.Fromm == only) || (x.Fromm == Email && x.id == userId)));
        }
        //[HttpPost]
        //public async Task<IActionResult> Message(Messages messages, MessagesViewModel mvm)
        //{
        //    if (mvm.Photo != null)
        //    {
        //        byte[] imageData = null;
        //        // считываем переданный файл в массив байтов
        //        using (var binaryReader = new BinaryReader(mvm.Photo.OpenReadStream()))
        //        {
        //            imageData = binaryReader.ReadBytes((int)mvm.Photo.Length);
        //        }
        //        // установка массива байтов
        //        messages.Photo = imageData;
        //    }
        //    if (mvm.Video != null)
        //    {
        //        byte[] imageData = null;
        //        // считываем переданный файл в массив байтов
        //        using (var binaryReader = new BinaryReader(mvm.Video.OpenReadStream()))
        //        {
        //            imageData = binaryReader.ReadBytes((int)mvm.Video.Length);
        //        }
        //        // установка массива байтов
        //        messages.Video = imageData;
        //    }

        //    db.Messages.Add(messages);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}
        //[HttpPost]
        //public async Task<IActionResult> EditMessages(int? id)
        //{
        //    if (id != null)
        //    {
        //        Messages messages = await db.Messages.FirstOrDefaultAsync(p => p.ProstoId == id);
        //        if (messages != null)
        //        {
        //            db.Messages.Update(messages);
        //            await db.SaveChangesAsync();
        //            return RedirectToAction("Index");
        //        }
        //    }
        //    return NotFound();
        //}

        //[HttpPost]
        //public async Task<IActionResult> DeleteMessage(string? id)
        //{
        //    if (id != null)
        //    {
        //        Messages message = await db.Messages.FirstOrDefaultAsync(p => p.id == id);
        //        if (message != null)
        //        {
        //            db.Messages.Remove(message);
        //            await db.SaveChangesAsync();
        //            return RedirectToAction("Message");
        //        }
        //    }
        //    return NotFound();
        //}
        public IActionResult AddGroupChat()
        {
            var idd = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var only = User.Identity.Name;
            ViewBag.Friends = db.Friends.Where(x => x.Sender == idd||x.Recipient==idd).ToList();
            var friends= db.Friends.Where(x => x.Sender == idd || x.Recipient == idd).ToList();
            ViewBag.Users = db.Users.ToList();
            //foreach (var i in friends) 
            //{
            //    ViewBag.Users = db.Users.Where(x => (x.Id == i.Sender || x.Id == i.Recipient) && x.Id != idd).ToList();
            //}

            //ViewBag.Users = db.Users.Include(x=>x.Friends).Where(x => (x.Friends.Recipient == idd && x.Id != idd || x.Friends.Sender == idd && x.Id != idd)).ToList();
            //.Include(x=>x.Friends).Where(x => (x.Id == x.Friends.Sender || x.Id == x.Friends.Recipient) && x.Id != idd)
            //ViewBag.CrUsers = db.Users.Where(x => x.Email == only||x.Email== "admin@mail.com").ToList();
            var Chat = db.AddGroupChat.ToList();
            if (Chat.Count() >= 1)
            {
                ViewBag.Chat = Chat.OrderBy(x => x.GroupId).LastOrDefault(x => x.GroupId != null).GroupId + 1;
            }
            else
            {
                ViewBag.Chat = 1;
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddGroupChat(List<AddGroupChat> groupModels, string NameGroup, IFormFile updatedPhoto)
        {
            for (var i = 0; i < groupModels.Count(); i++)
            {
                if (updatedPhoto != null)
                {
                    byte[] imageData = null;
                    // считываем переданный файл в массив байтов
                    using (var binaryReader = new BinaryReader(updatedPhoto.OpenReadStream()))
                    {
                        imageData = binaryReader.ReadBytes((int)updatedPhoto.Length);
                    }
                    // установка массива байтов
                    groupModels[0].Photo = imageData;
                }
                groupModels[0].Role = groupModels[0].Role;
                groupModels[0].Name = NameGroup;
                if (groupModels[i].userId != null) 
                {
                db.AddGroupChat.AddRange(groupModels[i]);
                }

            }
            
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> EditGroupChat(long? groupId)
        {
            var idd = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (groupId != null)
            {
                AddGroupChat addGroupChat = await db.AddGroupChat.FirstOrDefaultAsync(p => p.GroupId == groupId);
                if (addGroupChat != null)
                {
                    ViewBag.GroupId = groupId;
                    ViewBag.UserId = groupId;
                    ViewBag.Users = db.Users.Where(x => x.AddGroupChats.GroupId == groupId).ToList();
                    ViewBag.Userss = db.Users.ToList();
                    ViewBag.AddGroupChat = db.AddGroupChat.Where(x => x.GroupId == groupId).ToList();
                    ViewBag.Friends = db.Friends.Where(x => x.Sender == idd || x.Recipient == idd).ToList();

                    return View(addGroupChat);
                }
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> EditGroupChat(List<AddGroupChat> addGroupChat, string NameGroup, IFormFile updatedPhoto)
        {
            for (var i = 0; i < addGroupChat.Where(x => x.userId != null).Count(); i++)
            {
                if (updatedPhoto != null)
                {
                    byte[] imageData = null;
                    // считываем переданный файл в массив байтов
                    using (var binaryReader = new BinaryReader(updatedPhoto.OpenReadStream()))
                    {
                        imageData = binaryReader.ReadBytes((int)updatedPhoto.Length);
                    }
                    // установка массива байтов
                    addGroupChat[0].Photo = imageData;
                }
                addGroupChat[0].Role = addGroupChat[0].Role;
                addGroupChat[0].Name = NameGroup;
                db.AddGroupChat.UpdateRange(addGroupChat[i]); ;
            }
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> AddUserChat(List<AddGroupChat> addUserChat)
        {
            //for (var i = 0; i < addUserChat.Where(x => x.userId != null).Count(); i++)
            //{
            //    db.AddGroupChat.UpdateRange(addUserChat[i]); ;
            //}
            db.AddGroupChat.UpdateRange(addUserChat.Where(x=>x.userId!=null));
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> GroupMessage(long groupId, string Name)
        {
            if (groupId != null)
            {
                var idd = User.FindFirstValue(ClaimTypes.NameIdentifier);
                GroupChat groupChats = await db.GroupChat.FirstOrDefaultAsync(p => p.addGroupChat.GroupId == groupId && p.addGroupChat.Name == Name);

                ViewBag.GroupId = groupId;
                ViewBag.Name = Name;
                ViewBag.Id = db.AddGroupChat.OrderBy(x=>x.Id).FirstOrDefault(x => x.GroupId == groupId).Id;
                ViewBag.GroupChat = db.GroupChat.Where(x => x.addGroupChatId == groupId).ToList();
                ViewBag.AddGroupChat = db.AddGroupChat.Where(x => x.GroupId == groupId&&x.Name!=null).ToList();
                ViewBag.Mute = db.AddGroupChat.Where(x=> x.Role != "Mute" && x.userId == idd).ToList();
                ViewBag.Users = db.Users.ToList();
                return View();
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<ActionResult> sendGroupMessage(GroupChat groupChat)
        {

            if (groupChat.Message != null)
            {
                db.GroupChat.Add(groupChat);
            }
            await db.SaveChangesAsync();
            var messagee = "Succes";
            return Json(new { Messagee = messagee, System.Web.Mvc.JsonRequestBehavior.AllowGet });

        }
        //[HttpDelete]
        //public async Task<ActionResult> deleteGroupMessage(GroupChat groupChat, long id)
        //{
        //    db.GroupChat.Remove(groupChat);
        //    await db.SaveChangesAsync();
        //    string messagee = "SUCCESS";
        //    return Json(new { Messagee = messagee, System.Web.Mvc.JsonRequestBehavior.AllowGet });
        //    //return hC.Clients.All.SendAsync(groupChat);

        //}
        public JsonResult getGroupMessage(long groupId)
        {
            var only = User.Identity.Name;
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            List<GroupChat> chat = new List<GroupChat>();
            chat = db.GroupChat.ToList();
            return Json(chat.Where(x => x.addGroupChatId == groupId));
        }
        
        public async Task<IActionResult> DeleteGroupMessage(long? id)
        {
            if (id != null)
            {
                GroupChat groupChat = await db.GroupChat.FirstOrDefaultAsync(p => p.Id == id);
                if (groupChat != null)
                {
                    db.GroupChat.Remove(groupChat);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Message");
                }
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteUsersChat(long Id)
        {
            if (Id != null)
            {
                AddGroupChat addGroupChat = await db.AddGroupChat.FirstOrDefaultAsync(p => p.Id == Id);
                if (addGroupChat != null)
                {
                    db.AddGroupChat.Remove(addGroupChat);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}