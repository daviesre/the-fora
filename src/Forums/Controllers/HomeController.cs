using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Forums.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Forums.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        private ForumsDbContext db = new ForumsDbContext();
        public IActionResult Index()
        {
            return View(db.Topics.ToList());
        }
        public IActionResult Posts (int id)
        {
            var thisPost = db.Posts.FirstOrDefault(topics => topics.PostId == id);
            return View(thisPost);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Topic topic)
        {
            db.Topics.Add(topic);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
