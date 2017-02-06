using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SinExWebApp20326022.Models;

namespace SinExWebApp20326022.Controllers
{
    public class TrialController : Controller
    {
        // GET: Trial/Random
        public ActionResult Random()
        {
            var movie = new Trial() { Name = "Shrek!" };

            return View(movie);
        }
        
        // Attribute Route: creates a custom url route that handles multiple parameters with constraints
        // For more info on constraints, google asp.net mvc attribute route constraints
        [Route("trial/{pageIndex:regex(\\d{2})}/{sortBy}")]
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));
        }
    }
}