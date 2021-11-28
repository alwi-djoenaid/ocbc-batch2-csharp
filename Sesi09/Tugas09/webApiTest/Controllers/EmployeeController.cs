using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using webApiTest.Models;

namespace webApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController: ControllerBase
    {
        private EmployeeContext _context;

        public EmployeeController(EmployeeContext context)
        {
            this._context = context;
        }

        // GET: api/User
        [HttpGet(Name = "GetEmployee")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;

            var employee = _context.GetAllEmployee();

            if (employee.Count != 0)
            {
                return new OkObjectResult(new { Success = true, employee });
            }

            return BadRequest("Failed to get employee records");
        }

        // GET: api/User/{id}
        [HttpGet("{id}", Name = "GetEmployeeById")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItem(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;

            var employee = _context.GetEmployee(id);

            if(employee.Count == 1)
            {
                return new OkObjectResult(new { Success = true, employee });
            }

            return BadRequest("Failed to get employee details");
        }

        // POST: api/User/
        [HttpPost(Name = "InsertEmployee")]
        public ActionResult<IEnumerable<EmployeeItem>> InsertEmployee(EmployeeItem employee)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;

            // return new string[]
            return _context.InsertEmployee(employee);
        }

        // PUT: api/User/{id}
        [HttpPut("{id}", Name = "UpdateEmployee")]
        public ActionResult<IEnumerable<EmployeeItem>> UpdateEmployee(int id, EmployeeItem employee)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;

            // return new string[]
            return _context.UpdateEmployee(id, employee);
        }

        // DELETE: api/User/{id}
        [HttpDelete("{id}", Name = "DeleteEmployee")]
        public ActionResult<IEnumerable<EmployeeItem>> DeleteEmployee(int id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;

            // return new string[]
            if (_context.DeleteEmployee(id))
            {
                return Ok("Delete Success!");
            }

            return NotFound("Failed to delete employee record");
        }
    }
}
