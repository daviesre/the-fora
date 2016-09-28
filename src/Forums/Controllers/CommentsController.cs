using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Forums.Models;
using Forums.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Forums.Controllers
{
    public class CommentsController : Controller
    {
        private ForumsDbContext db = new ForumsDbContext();
        public IActionResult Index(int id)
        {
            var model = new CommentsViewModel();
            model.post = db.Posts.FirstOrDefault(post => post.PostId == id);
            model.Comments = db.Comments.Include(comments => comments.Post).Where(posts => posts.PostId == id).ToList();
            return View(model);
        }

        [Authorize]
        public IActionResult Create()
        {
            ViewBag.PostId = new SelectList(db.Posts, "PostId", "Title");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Comment comment)
        {
            db.Comments.Add(comment);
            db.SaveChanges();
            return RedirectToAction("Create");
        }

    }
}
