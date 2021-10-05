using GAMF_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GAMF_.Data;

namespace GAMF_.Controllers
{
    public class HomeController : Controller
    {

        private readonly GAMFDbContext _context;

        public HomeController(GAMFDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View();
        }

    }
}
