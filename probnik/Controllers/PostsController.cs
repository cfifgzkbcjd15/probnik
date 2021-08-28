using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using probnik.Models; // пространство имен моделей и контекста данных
using probnik.Data;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using probnik.ViewModels;

namespace probnik.Controllers
{
    public class PostsController : Controller
    {
        List<Posts> postt;
        private ApplicationContext db;
        public PostsController(ApplicationContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index(string searchString, int page = 1)
        {

            int pageSize = 10;   // количество элементов на странице

            IQueryable<Posts> source = db.Posts.Include(x => x.Comments);

            if (!String.IsNullOrEmpty(searchString))
            {
                source = source.Where(s => s.Body.Contains(searchString));
            }
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Posts = items

            };

            ViewBag.PageSize = pageSize;
            ViewBag.Coment = db.Comments.ToList();
            ViewBag.Posts = db.Posts.Select(x => x.Id).ToList();
            return View(viewModel);

        }
        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }
    }
}