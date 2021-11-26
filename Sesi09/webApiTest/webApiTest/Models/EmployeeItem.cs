using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApiTest.Models
{
    public class EmployeeItem
    {
        //private Models.EmployeeContext context;

        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
    }
}
