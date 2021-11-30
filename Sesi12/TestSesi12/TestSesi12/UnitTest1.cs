using System;
using Xunit;
using Moq;

namespace TestSesi12
{
    public class UnitTest1
    {
        #region Property
        Mock<IEmployeeService> mock = new Mock<IEmployeeService>();
        #endregion

        [Fact]
        public async void GetEmployeeById(int id)
        {

        }
    }
}
