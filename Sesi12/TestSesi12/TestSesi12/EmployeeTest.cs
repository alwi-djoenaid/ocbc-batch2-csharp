using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;

namespace TestSesi12
{
    class EmployeeTest
    {
        #region Property
        Mock<IEmployeeService> mock = new Mock<IEmployeeService>();
        #endregion

        [Fact]
        public async void GetEmployeeById(int id)
        {
            mock.Setup(p => p.GetEmployeeById(1)).ReturnsAsync("JK");
            EmployeeController emp = new EmployeeController(mock.Object);
            string result = await emp.GetEmployeeById(1);
        }

        [Fact]
        public async void GetEmployeeDetails(int id)
        {
            var employeeDTO = new Employee()
            {
                id = 
            }
        }
    }
}
