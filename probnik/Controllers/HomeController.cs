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

        public async Task<IActionResult> UserId(string? id, string Email)
        {
            if (id != null)
            {
                ViewBag.Friends = db.Friends.ToList();
                var userr = db.Users.ToList();
                User user = await db.Users.FirstOrDefaultAsync(p => p.Id == id);
                var idd = User.FindFirstValue(ClaimTypes.NameIdentifier);
                ViewBag.Albums = db.Albums.Where(x => x.UserId == id).ToList();
                ViewBag.Photos = db.Photos.ToList();
                ViewBag.Posts = db.Posts.Where(x => x.To == id).ToList();
                ViewBag.Likes = db.LikesPosts.ToList();
                var list = db.Posts.Where(x => x.To == id).ToList();
                ViewBag.Mid = id;
                ViewBag.Comments = db.Comments.ToList();
                ViewBag.User = db.Users.Where(x => x.Email == User.Identity.Name).ToList();
                ViewBag.UserId = db.Users.Where(x => x.Id == id).ToList();
                if (user != null)
                    return View();
            }
            return NotFound("Страница удалена");
        }
        [HttpPost]
        public async Task<IActionResult> UserId(CommentsViewModels cvm, Comments comment,string userId)
        {
            if (cvm.Photo != null)
            {
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(cvm.Photo.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)cvm.Photo.Length);
                }
                // установка массива байтов
                comment.Photo = imageData;
            }
            if (cvm.Video != null)
            {
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(cvm.Video.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)cvm.Video.Length);
                }
                // установка массива байтов
                comment.Video = imageData;
            }
            if (cvm.Music != null)
            {
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(cvm.Music.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)cvm.Music.Length);
                }
                // установка массива байтов
                comment.Video = imageData;
            }
            if (comment.Body != null)
            {
                db.Comments.Add(comment);
            }
            await db.SaveChangesAsync();
            return RedirectToAction("UserId", "Home",new { userId });
        }
        public IActionResult CreatePosts(string? id)
        {
            if (id != null)
            {

                ViewBag.Mid = id;
                return View();
            }
            return NotFound("ошибка");
        }
        [HttpPost]
        public async Task<IActionResult> CreatePosts(PostsViewModel pvm, Posts posts, string Id)
        {
            var idd = User.FindFirstValue(ClaimTypes.NameIdentifier);
            
            if (pvm.Photo != null)
            {
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(pvm.Photo.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)pvm.Photo.Length);
                }
                // установка массива байтов
                posts.Photo = imageData;
            }
            if (pvm.Video != null)
            {
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(pvm.Video.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)pvm.Video.Length);
                }
                // установка массива байтов
                posts.Video = imageData;
            }
            if (pvm.Music != null)
            {
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(pvm.Music.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)pvm.Music.Length);
                }
                // установка массива байтов
                posts.Music = imageData;
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
        public async Task<IActionResult> DeletePosts(int? id,string userId)
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
                    userId = posts.UserId;
                    return RedirectToAction("UserId", "Home", userId);
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
                    return RedirectToAction("UserId",new { uss });
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
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> EditFriends(long id, string sender, string recipient, string confirmation)
        {
            Friends friends = new Friends() { Id = id, Sender = sender, Recipient = recipient, Confirmation = confirmation };
            db.Friends.Update(friends);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
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
                    return RedirectToAction("Index");
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
