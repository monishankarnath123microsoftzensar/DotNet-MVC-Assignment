using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebAppCodeFirstWithAuthen.Models;

namespace MVCWebAppCodeFirstWithAuthen.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _context;
        // GET: Movie
        public MovieController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var mov = _context.Movies.ToList();
            return View(mov);
        }
        public ActionResult Details(int id)
        {
            var singleMovie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (singleMovie == null)
            {
                return HttpNotFound();
            }
            return View(singleMovie);
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

    }
}