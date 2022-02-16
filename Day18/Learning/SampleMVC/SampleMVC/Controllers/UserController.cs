using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SampleMVC.Models;
using SampleMVC.Services;
using System.Diagnostics;

namespace SampleMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IRepo<string, User> _adding;
        private readonly IRepo<int, Customer> _repo;
        private readonly LoginService _lservice;

        public UserController(IRepo<string, User> adding, IRepo<int, Customer> repo,
            LoginService lservice)
        {
            _adding = adding;
            _repo = repo;
            _lservice = lservice;
        }

        public IActionResult Register()
        {
            ViewBag.Roles = GetUserRoles();
            return View(new UserCustomer());
        }
        [HttpPost]
        public IActionResult Register(UserCustomer userCustomer)
        {
            try 
            {
                if (ModelState.IsValid)
                {
                    Customer customer = new Customer();
                    customer.Name = userCustomer.Name;
                    customer.Age = userCustomer.Age;
                    customer = _repo.Add(customer);
                    User user = new User();
                    user.CustomerId = customer.Id;
                    user.Username = userCustomer.Username;
                    user.Password = userCustomer.Password;
                    user.Role = userCustomer.Role;
                    _adding.Add(user);
                    TempData.Add("registeredUser", user.Username);
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(userCustomer, ex.Message);
            }

            //return View(new UserCustomer());
            return RedirectToAction("Login");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            var myUser = _lservice.LoginCheck(user);
            if (myUser == null)
                return View();
            HttpContext.Session.SetString("un", user.Username);
            return RedirectToAction("ShowProducts", "Home");
        }

        IEnumerable<SelectListItem> GetUserRoles()
        {
            List<SelectListItem> roles = new List<SelectListItem>();
            roles.Add(new SelectListItem { Text = "Admin", Value = "admin" });
            roles.Add(new SelectListItem { Text = "Power User", Value = "power" });
            roles.Add(new SelectListItem { Text = "User", Value = "user" });
            return roles;
        }

       
    }
}
