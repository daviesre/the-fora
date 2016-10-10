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
        
        [HttpPost]
        public IActionResult NewComment(string newText, string newUser,int PostId)
        {
            Post foundProduct=db.Posts.FirstOrDefault(model => model.PostId == PostId);
            Comment newComment = new Comment(newText, newUser);
            newComment.Post = foundProduct;
            newComment.PostId = PostId;

            db.Comments.Add(newComment);
            db.SaveChanges();
            return Json(newComment);
        }
    }
}
