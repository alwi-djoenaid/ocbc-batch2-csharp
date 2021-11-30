using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTest_Mock.Models;
using Microsoft.EntityFrameworkCore;

namespace UnitTest_Mock.Services
{
    public class EmployeeService : IEmployeeService
    {
        #region property
        private readonly ApiDbContext _apiDbContext;
        #endregion

        #region constructor
        public EmployeeService(ApiDbContext apiDbContext)
        {
            _apiDbContext = apiDbContext;
        }
        #endregion

        public async Task<string> GetEmployeeById(int id)
        {
            var name = await _apiDbContext.Employees.Where(c => c.id == id).Select(d => d.name).FirstOrDefaultAsync();
            return name;
        }

        public async Task<Employee> GetEmployeeDetails(int id)
        {
            var emp = await _apiDbContext.Employees.FirstOrDefaultAsync(c => c.id == id);
            return emp;
        }
    }
}