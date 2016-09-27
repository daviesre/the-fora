using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Forums.Models;


namespace Forums.Controllers
{
    public class CommentsController : Controller
    {
        private ForumsDbContext db = new ForumsDbContext();
        public IActionResult Index()
        {
            return View(db.Comments.Include(comments => comments.Post).ToList());
        }
    }
}
