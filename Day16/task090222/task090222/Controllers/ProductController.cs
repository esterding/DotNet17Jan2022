using Microsoft.AspNetCore.Mvc;
using task090222.Models;
using System.Linq;

namespace task090222.Controllers
{
    public class ProductController : Controller
    {
        static public List<Product> Products = new List<Product>(){

            new Product { Id = 1, Name = "Spicy Chicken Noodles", Price = 4.50, Quantity = 150, Remarks = "Spicy", SupplierId = 005 },
            new Product { Id = 2, Name = "Sweet and Sour Chicken Noodles", Price = 4.30, Quantity = 120, Remarks = "Non Spicy", SupplierId = 005 },
            new Product { Id = 3, Name = "Clear Soup Glass Noodles", Price = 4.00, Quantity = 120, Remarks = "Non Spicy", SupplierId = 006 }

        };
        public IActionResult Index()
        {
            return View(Products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Product());
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            Products.Add(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int productId)
        {
            //Product product = new Product();
            var product = Products.FirstOrDefault(p => p.Id == productId);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(int productId, Product product)
        {
            //Product product = new Product();
            var MyProduct = Products.FirstOrDefault(p => p.Id == productId);
            MyProduct.Name = product.Name;
            MyProduct.Price = product.Price;
            MyProduct.Quantity = product.Quantity;
            MyProduct.Remarks = product.Remarks;
            MyProduct.SupplierId = product.SupplierId;

            return RedirectToAction("Index");
        }
    }
}
