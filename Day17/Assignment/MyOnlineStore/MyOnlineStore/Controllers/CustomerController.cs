using Microsoft.AspNetCore.Mvc;
using MyOnlineStore.Models;
using MyOnlineStore.Services;

namespace MyOnlineStore.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IRepo<int, Customer> _repo;

        public CustomerController(IRepo<int, Customer> repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAccount(Customer cus)
        {
            _repo.Add(cus);
            return View();
        }
    }
}
