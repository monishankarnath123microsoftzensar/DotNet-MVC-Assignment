using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebAppCodeFirstWithAuthen.Models;

namespace MVCWebAppCodeFirstWithAuthen.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;
        // GET: Customer
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var customer = _context.Customers.Include(c=>c.MembershipType).ToList();
            return View(customer);
        }
        public ActionResult Details(int id)
        {
            var singleCustomer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (singleCustomer == null)
            {
                return HttpNotFound();
            }
            return View(singleCustomer);
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

    }
}