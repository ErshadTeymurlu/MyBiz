using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyBiz.DAL;
using MyBiz.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyBiz.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _db { get; }
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<Team> members = await _db.Teams.ToListAsync();
            return View(members);
        }
    }
}
