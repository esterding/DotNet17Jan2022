using FirstAPI.Models;
using FirstAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IRepo<int, Employee> _repo;

        public EmployeeController(IRepo<int, Employee> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _repo.GetAll();
        }

        [HttpGet]
        [Route("SingleEmployee")]
        public Employee Get(int id)
        {
            return _repo.Get(id);
        }

        [HttpPost]
        public Employee Post(Employee employee)
        {
            _repo.Add(employee);
            return employee;
        }

        [HttpDelete]
        public Employee Delete(int id)
        {
            return _repo.Delete(id);
        }

        [HttpPut]
        public Employee Put(int id, Employee employee)
        {
           return _repo.Update(id, employee);
        }
    }
}
