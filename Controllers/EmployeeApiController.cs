using System.Collections.Generic;
using BookStore.Models;
using BookStore.Services;
using Microsoft.AspNetCore.Mvc;


namespace BookStore.Controllers
{

    [Route("api/employee")]
    [ApiController]
    public class EmployeeApiController : ControllerBase
    {
        private readonly EmployeeService _empService;

        public EmployeeApiController(EmployeeService empService)
        {
            _empService = empService;
        }

        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            return _empService.Get();
        }

        

        [HttpGet("{id:length(24)}", Name = "GetEmployee")]
        public ActionResult<Employee> Get(string id)
        {
            var emp = _empService.Get(id);

            if (emp == null)
            {
                return NotFound();
            }

            return emp;
        }

        [HttpPost]
        public ActionResult<Employee> Create(Employee emp)
        {
            _empService.Create(emp);

            return CreatedAtRoute("GetEmployee", new { id = emp.Id.ToString() }, emp);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Employee empIn)
        {
            var emp = _empService.Get(id);

            if (emp == null)
            {
                return NotFound();
            }

            _empService.Update(id, empIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var emp = _empService.Get(id);

            if (emp == null)
            {
                return NotFound();
            }

            _empService.Remove(emp.Id);

            return NoContent();
        }

       
    }
}