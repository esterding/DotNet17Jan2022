using FirstAPI.Models;
using FirstAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")] //Attribute based routing
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IRepo<int, Customer> _repo;

        //static List<Customer> _customers = new List<Customer>
        //{
        //    new Customer { Id = 1, Name = "Tim", Age = 23},
        //    new Customer { Id = 2, Name = "Lim", Age = 33},
        //    new Customer { Id = 3, Name = "Jim", Age = 43}
        //};
        public CustomerController(IRepo<int, Customer> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _repo.GetAll();
        }

        [HttpPost]
        public Customer Post(Customer customer)
        {
            _repo.Add(customer);
            return customer;
        }

        [HttpGet]
        [Route("SingleEmployee")]
        public Customer Get(int id)
        {
            return _repo.Get(id);
        }

        [HttpPut]
        public Customer Put(int id, Customer customer)
        {
            return _repo.Update(id, customer);
           
        }

        [HttpDelete]
        public Customer Delete(int id)
        {
            return _repo.Delete(id);
        }
    }
}
