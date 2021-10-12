﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAMF_.Data;
using GAMF_.Models;

namespace GAMF_.Controllers
{
    public class ReportController : Controller
    {

        private readonly GAMFDbContext _context;

        public ReportController(GAMFDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }


      public IActionResult EnrollmentDateReport()
        {
            var result = from student in _context.Students
                         group student by student.EnrollmentDate into dateGroup
                         select new EnrollmentDateVM
                         {
                             EnrollmentDate = dateGroup.Key,
                             StudentCount = dateGroup.Count()
                         };

            return View(result.ToList());
        }


        public IActionResult CreditReport()
        {
            var result = "";
                          


            return View(result.ToList());
        }
    }
}
