using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Forums.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Forums.Controllers
{
    public class HomeClass : Controller
    {
        private ForumsDbContext db = new ForumsDbContext();
        public IActionResult Index()
        {
            return View(db.Topics.ToList());
        }
    }
}
