using Microsoft.AspNetCore.Mvc;
using SampleMVC.Models;
using SampleMVC.Services;

namespace SampleMVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IRepo<int, Customer> _repo;

        //take IRepo as injection
        public CustomerController(IRepo<int, Customer> repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }
        public IActionResult Details(int id)
        {
            Customer customer = _repo.GetT(id);
            return View(customer);
        }
        public IActionResult Edit(int id)
        {
            Customer customer = _repo.GetT(id);
            return View(customer);
        }
        [HttpPost]
        public IActionResult Edit(int id, Customer customer)
        {
            _repo.Update(customer);
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            return View(new Customer());
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(customer);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Create");
        }
        public IActionResult Delete(int id)
        {
            Customer customer = _repo.GetT(id);
            return View(customer);
        }
        [HttpPost]
        public IActionResult Delete(int id, Customer customer)
        {
            _repo.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
