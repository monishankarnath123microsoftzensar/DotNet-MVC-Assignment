using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssignmentWebApp18_08.Models;

namespace AssignmentWebApp18_08.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            var product = GetProduct();
            return View(product);
        }
        private IEnumerable<Product> GetProduct()
        {
            return new List<Product>
            {
                new Product {Id = 101 , PName = "AC", PRate=45000},
                new Product {Id = 102 , PName = "Mobile", PRate=38000},
                new Product {Id = 103 , PName = "Bike", PRate=94000},
            };
        }
        public ActionResult Details(int id)
        {
            var proDetail = GetProduct().SingleOrDefault(c => c.Id == id);
            if (proDetail == null)
            {
                return HttpNotFound();

            }
            return View(proDetail);
        }
    }
}