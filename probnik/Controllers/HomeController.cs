using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
    public class FriendsModel
    {
        public List<Friends> Friends { get; set; }
        public List<User> User { get; set; }
        public List<Messages> Message { get; set; }
        public List<Posts> Posts { get; set; }
        public List<Comments> Comments { get; set; }
    }
    [Authorize]
    public class HomeController : Controller
    {
        private ApplicationContext db;
        private readonly ILogger<HomeController> _logger;
        UserManager<User> _userManager;

        public HomeController(ILogger<HomeController> logger, ApplicationContext context, UserManager<User> userManager)
        {
            _logger = logger;
            db = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult GetUsers(string searchString)
        {

            IQueryable<User> source = db.Users.Include(x => x.message);
            if (!String.IsNullOrEmpty(searchString))
            {
                source = source.Where(s => s.Name.Contains(searchString));
            }
            ViewBag.Users = db.Messages.ToList();
            return View(source);
        }

        public async Task<IActionResult> UserId(string id,string name)
        {
            if (id != null)
            {
                ViewBag.Friends = db.Friends.ToList();
                var userr = db.Users.ToList();
                User user = await db.Users.FirstOrDefaultAsync(p => p.Id == id);
                var idd = User.FindFirstValue(ClaimTypes.NameIdentifier);
                ViewBag.Albums = db.Albums.Where(x => x.UserId == id).ToList();
                ViewBag.Photos = db.Photos.ToList();
                ViewBag.Posts = db.Posts.Where(x => x.To == id).OrderByDescending(x=>x.Id).ToList();
                ViewBag.Likes = db.LikesPosts.ToList();
                ViewBag.Mid = id;
                ViewBag.Name = name;
                ViewBag.Comments = db.Comments.ToList();
                ViewBag.User = db.Users.ToList();
                ViewBag.UserId = db.Users.Where(x => x.Id == id).ToList();

                if (user != null)
                    return View();
            }
            return NotFound("Страница удалена");
        }
        [HttpPost]
        public async Task<IActionResult> UserId(Comments comment,string userId,IFormFile photo, IFormFile video, IFormFile music)
        {
            var idd = User.FindFirstValue(ClaimTypes.NameIdentifier);
            comment.Data = DateTime.Now;
            foreach(var i in db.Users.Where(x => x.Id == idd).ToList())
            {
                comment.Name = i.Name;
            }
            List<string> png = "89 50 4E 47".Split().ToList();
            List<string> jpg = "FF D8 FF DB".Split().ToList();
            List<string> jpeg = "FF D8 FF E0".Split().ToList();
            List<string> mp4 = "00 00 00 18".Split().ToList();
            List<string> mp3 = "49 44 33".Split().ToList();
            List<string> fileHead = new List<string>();
            if (photo != null)
            {

                using (var binaryReader = new BinaryReader(photo.OpenReadStream()))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        string bit = binaryReader.ReadByte().ToString("X2");
                        fileHead.Add(bit);
                    }
                }
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(photo.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)photo.Length);
                }
                if (!png.Except(fileHead).Any())
                {
                    comment.Photo = imageData;
                }
                if (!jpg.Except(fileHead).Any())
                {
                    comment.Photo = imageData;
                }
                if (!jpeg.Except(fileHead).Any())
                {
                    comment.Photo = imageData;
                }
                if (comment.Photo == null)
                {
                    return NotFound("не подходит под разрешение");
                }
            }
            if (video != null)
            {
                using (var binaryReader = new BinaryReader(video.OpenReadStream()))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        string bit = binaryReader.ReadByte().ToString("X2");
                        fileHead.Add(bit);
                    }
                }
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(video.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)video.Length);
                }
                // установка массива байтов
                if (!mp4.Except(fileHead).Any())
                {
                    comment.Video = imageData;
                }
                if (comment.Video == null)
                {
                    return NotFound("не подходит под разрешение");
                }
            }
            if (music != null)
            {
                using (var binaryReader = new BinaryReader(music.OpenReadStream()))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        string bit = binaryReader.ReadByte().ToString("X2");
                        fileHead.Add(bit);
                    }
                }
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(music.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)music.Length);
                }

                // установка массива байтов
                if (!mp3.Except(fileHead).Any())
                {
                    comment.Music = imageData;
                }
                if (comment.Music == null)
                {
                    return NotFound("не подходит под разрешение");
                }
            }
            if (comment.Body != null)
            {
                db.Comments.Add(comment);
            }
            await db.SaveChangesAsync();
            return RedirectToAction("UserId", "Home",new { userId });
        }
        public IActionResult CreatePosts(string id)
        {
            if (id != null)
            {

                ViewBag.Mid = id;
                return View();
            }
            
            return NotFound("ошибка");
        }
        [HttpPost]
        public async Task<IActionResult> CreatePosts(Posts posts, string Id,IFormFile photo, IFormFile video, IFormFile music)
        {
            var idd = User.FindFirstValue(ClaimTypes.NameIdentifier);
            posts.To=Id;
            posts.UserId = idd;
            posts.Data = DateTime.Now;
            List<string> png = "89 50 4E 47".Split().ToList();
            List<string> jpg = "FF D8 FF DB".Split().ToList();
            List<string> jpeg = "FF D8 FF E0".Split().ToList();
            List<string> mp4 = "00 00 00 18".Split().ToList();
            List<string> mp3 = "49 44 33".Split().ToList();
            List<string> fileHead = new List<string>();
            if (photo != null)
            {
            
            using (var binaryReader = new BinaryReader(photo.OpenReadStream()))
            {
                for (int i = 0; i < 4; i++)
                {
                    string bit = binaryReader.ReadByte().ToString("X2");
                    fileHead.Add(bit);
                }
            }
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(photo.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)photo.Length);
                }
                if (!png.Except(fileHead).Any())
                {
                    posts.Photo = imageData; 
                }
                if (!jpg.Except(fileHead).Any())
                {
                    posts.Photo = imageData;
                }
                if (!jpeg.Except(fileHead).Any())
                {
                    posts.Photo = imageData;
                }
                if (posts.Photo == null)
                {
                    return NotFound("не подходит под разрешение");
                }
            }
            if (video != null)
            {
                using (var binaryReader = new BinaryReader(video.OpenReadStream()))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        string bit = binaryReader.ReadByte().ToString("X2");
                        fileHead.Add(bit);
                    }
                }
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(video.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)video.Length);
                }
                // установка массива байтов
                if (!mp4.Except(fileHead).Any())
                {
                    posts.Video = imageData;
                }
                if (posts.Video== null)
                {
                    return NotFound("не подходит под разрешение");
                }
            }
            if (music != null)
            {
                using (var binaryReader = new BinaryReader(music.OpenReadStream()))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        string bit = binaryReader.ReadByte().ToString("X2");
                        fileHead.Add(bit);
                    }
                }
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(music.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)music.Length);
                }

                // установка массива байтов
                if (!mp3.Except(fileHead).Any())
                {
                    posts.Music = imageData;
                }
                if (posts.Music == null)
                {
                    return NotFound("не подходит под разрешение");
                }
            }
            db.Posts.Add(posts);
            await db.SaveChangesAsync();
            return RedirectToAction("UserId",new { Id });
        }
        public ActionResult addLikes(int id,string name,string userId)
        {
            LikesPosts update = new LikesPosts() {postId=id,UserName=name,Like=1 };
            db.LikesPosts.Add(update);
            db.SaveChanges();
            return RedirectToAction("UserId" + userId);
        }
        public ActionResult delLikes(int id,string userId)
        {
            LikesPosts update = new LikesPosts() { Id=id};
            db.LikesPosts.Remove(update);
            db.SaveChanges();
            return RedirectToAction("UserId"+userId);
        }
        [HttpPost]
        public async Task<IActionResult> DeletePosts(int id)
        {
            if (id != null)
            {
                IQueryable<Comments> comments = from o in db.Comments
                                                where o.Posts.Id == id
                                                select o;
                Posts posts = db.Posts.Find(id);
                if (posts != null && comments != null)
                {
                    foreach (Comments od in comments)
                    {
                        db.Comments.Remove(od);
                    }
                    db.Posts.Remove(posts);
                    await db.SaveChangesAsync();
                    return RedirectToAction("UserId", "Home", new { @id = posts.To });
                }
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteComments(string uss,int id)
        {
            if (id != null)
            {
                Comments comments = await db.Comments.FirstOrDefaultAsync(p => p.Id == id);
                if (comments != null)
                {
                    db.Comments.Remove(comments);
                    await db.SaveChangesAsync();
                    return RedirectToAction(nameof(UserId), "Home", new { uss });
                    //return RedirectToRoute("default", new { controller="Home", action="UserId", userId });
                }
            }
            return NotFound();
        }
        public IActionResult Comment()
        {
            var users = db.Users.ToList();
            var posts = db.Posts.ToList();
            var coment = db.Comments.ToList();
            FriendsModel model = new FriendsModel()
            {
                User=users,
                Posts=posts,
                Comments=coment
            };
            
            return View(model);
        }
        //public async Task<ActionResult> sendComments(Comments cms)
        //{
        //    if (cms.Body != null)
        //    {
        //        db.Comments.Add(cms);
        //    }
        //    db.SaveChanges();
        //    string messagee = "SUCCESS";

        //    return Json(new { Messagee = messagee, System.Web.Mvc.JsonRequestBehavior.AllowGet });

        //}
        //public JsonResult getComments()
        //{
        //    List<Comments> comments = new List<Comments>();
        //    comments = db.Comments.ToList();

        //    return Json(comments);
        //}
        public async Task<IActionResult> EditUser(string id, EdUserViewModel evm)
        {
            User user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            EditUserViewModel model = new EditUserViewModel { Id = user.Id, Name = user.Name, Email = user.Email, PhoneNumber = user.PhoneNumber, Year = user.Year, Photo = user.Photo };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(EditUserViewModel model, EdUserViewModel evm)
        {

            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByIdAsync(model.Id);
                if (user != null)
                {
                    if (evm.Photo != null)
                    {
                        byte[] imageData = null;
                        // считываем переданный файл в массив байтов
                        using (var binaryReader = new BinaryReader(evm.Photo.OpenReadStream()))
                        {
                            imageData = binaryReader.ReadBytes((int)evm.Photo.Length);
                        }
                        // установка массива байтов
                        user.Photo = imageData;
                    }
                    user.Email = model.Email;
                    user.Name = model.Name;
                    user.UserName = model.Email;
                    user.PhoneNumber = model.PhoneNumber;
                    user.Year = model.Year;
                    model.Photo = user.Photo;

                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
            }
            return View(model);
        }
        public IActionResult Friends()
        {
            var idd = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.Friends = db.Friends.Where(x => x.Recipient == idd && x.Confirmation == "false").ToList();
            ViewBag.User = db.Users.ToList();
            return View(db.Friends.ToList());
        }
        [HttpPost]
        public async Task<IActionResult> addFriends(string sender, string recipient, string confirmation)
        {
            Friends friends = new Friends() { Sender = sender, Recipient = recipient, Confirmation = confirmation };
            db.Friends.Add(friends);
            await db.SaveChangesAsync();
            return RedirectToAction("Friends");
        }
        [HttpPost]
        public async Task<IActionResult> EditFriends(long id, string sender, string recipient, string confirmation)
        {
            Friends friends = new Friends() { Id = id, Sender = sender, Recipient = recipient, Confirmation = confirmation };
            db.Friends.Update(friends);
            await db.SaveChangesAsync();
            return RedirectToAction("Friends");
        }
        [HttpPost]
        public async Task<IActionResult> reject_addition(long? id)
        {
            if (id != null)
            {
                Friends friends = await db.Friends.FirstOrDefaultAsync(p => p.Id == id);
                if (friends != null)
                {
                    db.Friends.Update(friends);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Friends");
                }
            }
            return NotFound();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
