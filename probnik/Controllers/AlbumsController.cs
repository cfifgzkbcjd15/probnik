using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using probnik.Models; // пространство имен моделей и контекста данных
using probnik.Data;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using System.Security.Claims;

namespace probnik.Controllers
{
    public class AlbumsController : Controller
    {
        private ApplicationContext db;
        public AlbumsController(ApplicationContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            /*var alboms = (from item in db.Albums.Include(x => x.Photos)
                          orderby item.Photos.albumId
                          select item).ToList();
            ViewBag.Count = db.Photos.ToList();

            return View(alboms.Distinct().ToList());
            */
            var idd = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.Count = db.Photos.ToList();
            ViewBag.Users = db.Users.Where(x => x.Id == idd).ToList();

            return View(db.Albums.Where(x => x.UserId == idd).OrderByDescending(x => x.Id).ToList());
        }
        public async Task<IActionResult> UsersAlbums(string? userId)
        {
            if (userId != null)
            {
                Albums album = await db.Albums.FirstOrDefaultAsync(p =>p.UserId==userId);
                    ViewBag.UserId = userId;
                    ViewBag.Count = db.Photos.ToList();
                    ViewBag.Users = db.Users.ToList();
                ViewBag.Albums = db.Albums.Where(x => x.UserId == userId).OrderByDescending(x => x.Id).ToList();
                ViewBag.Photos = db.Photos.ToList();

                return View();
            }
            return NotFound("ошибка");
        }
        public IActionResult Details(int? id)
        {
            if (id != null)
            {
                var details = (from item in db.Photos.Include(p => p.albums)
                               where item.albumId == id
                               select item).ToList();
                ViewBag.Albums = db.Albums.ToList();
                return View(details.OrderByDescending(x => x.Id).ToList());
            }
            return NotFound();
        }
        public IActionResult CreateAlbums()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAlbums(Albums albums)
        {
            db.Albums.Add(albums);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult CreatePhotos()
        {
            SelectList album = new SelectList(db.Albums.OrderByDescending(x => x.Id), "Id", "Title");
            ViewBag.Album = album;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreatePhotos(Photos photos,PhotosViewModel pvm)
        {
            if (pvm.Photo != null)
            {
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(pvm.Photo.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)pvm.Photo.Length);
                }
                // установка массива байтов
                photos.Photo = imageData;
            }
            db.Photos.Add(photos);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        [ActionName("DeleteAlbums")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Albums albums = await db.Albums.FirstOrDefaultAsync(p => p.Photos.albumId == id);
                if (albums != null)
                    return View(albums);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteAlbums(int? id)
        {
            if (id != null)
            {
                IQueryable<Photos> photos = from o in db.Photos
                                            where o.albums.Id == id
                                            select o;
                Albums albums = db.Albums.Find(id);
                if (albums != null && photos != null)
                {
                    foreach (Photos od in photos)
                    {
                        db.Photos.Remove(od);
                    }
                    db.Albums.Remove(albums);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
        [HttpGet]
        [ActionName("DeletePhotos")]
        public async Task<IActionResult> ConfirmDeletePhotos(int? id)
        {
            if (id != null)
            {
                Photos photos = await db.Photos.FirstOrDefaultAsync(p => p.Id == id);
                if (photos != null)
                    return View(photos);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeletePhotos(int? id)
        {
            if (id != null)
            {
                Photos user = await db.Photos.FirstOrDefaultAsync(p => p.Id == id);
                if (user != null)
                {
                    db.Photos.Remove(user);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}

