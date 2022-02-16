using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using task14022022.Models;
using task14022022.Services;

namespace task14022022.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepo2<int, Product> _repo;

        public ProductController(IRepo2<int, Product> repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            var products = _repo.GetAll();
            return View(products);
        }

        public IActionResult Detail(int id)
        {
            var product = _repo.GetT(id);
            return View(product);
        }

        public IActionResult RegisterItem()
        {
            ViewBag.Categories = GetCategories();
            return View();
        }

        [HttpPost]
        public IActionResult RegisterItem(Product product)
        {
            _repo.Add(product);
            return RedirectToAction("Index");
        }

        public IActionResult ProductDetails(int id)
        {
            Product product = _repo.GetT(id);
            return View(product);
        }

        IEnumerable<SelectListItem> GetCategories()
        {
           List<SelectListItem> categories = new List<SelectListItem>();
            categories.Add(new SelectListItem { Text = "Toy", Value = "Toy" });
            categories.Add(new SelectListItem { Text = "Clothing", Value = "Clothing" });
            categories.Add(new SelectListItem { Text = "Food", Value = "Food" });
            return categories;
        }
        public IActionResult Purchase(Product product)
        {
            Product pd = _repo.GetT(product.ProductId);
            PurchaseProduct purchaseProduct = new PurchaseProduct { Product = pd };

            return View(purchaseProduct);
        }

        [HttpPost]
        public IActionResult Purchase(PurchaseProduct pp)
        {
            Product product = _repo.GetT(pp.Product.ProductId);
            product.ProductQuantity = product.ProductQuantity - pp.PurchaseQty;
            _repo.Update(product);
            return RedirectToAction("Index");
        }

    }
}
