using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Forums.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Forums.Controllers
{
    public class PostsController : Controller
    {
        // GET: /<controller>/
        private ForumsDbContext db = new ForumsDbContext();
        public IActionResult Index()
        {
            return View(db.Posts.Include(posts => posts.Topic).ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Post post)
        {
            db.Posts.Add(post);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
