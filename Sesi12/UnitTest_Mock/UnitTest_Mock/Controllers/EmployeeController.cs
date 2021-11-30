using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Core;
using UnitTest_Mock.Models;
using UnitTest_Mock.Services;

namespace UnitTest_Mock.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        #region property
        private readonly IEmployeeService _employeeService;
        #endregion

        #region constructor
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        #endregion

        [HttpGet(nameof(GetEmployeeById))]
        public async Task<string> GetEmployeeById(int id)
        {
            var result = await _employeeService.GetEmployeeById(id);
            return result;
        }

        [HttpGet(nameof(GetEmployeeDetails))]
        public async Task<Employee> GetEmployeeDetails(int id)
        {
            var result = await _employeeService.GetEmployeeDetails(id);
            return result;
        }
    }
}