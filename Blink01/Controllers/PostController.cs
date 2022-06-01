using Blink01.DAL;
using Blink01.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blink01.Controllers
{
    public class PostController : Controller
    {
        private readonly AppDbContext db;
        public PostController(AppDbContext _db)
        {
            db = _db;
        }
        public async Task<IActionResult> Details(int Id)
        {
            Post post = await db.Posts.FindAsync(Id);
            return View(post);
        }
    }
}
