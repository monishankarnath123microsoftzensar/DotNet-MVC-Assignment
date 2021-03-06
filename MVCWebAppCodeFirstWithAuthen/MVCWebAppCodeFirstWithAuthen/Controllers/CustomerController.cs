﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebAppCodeFirstWithAuthen.Models;
using MVCWebAppCodeFirstWithAuthen.ViewModel;

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
        public ActionResult New()
        {
            var membership = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membership
            };
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Create(Customer customer)//Model binding
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index","Customer");
        }
        //[HttpPost]
        //public ActionResult Delete(int? id)
        //{
        //    return View();
        //}
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

    }
}