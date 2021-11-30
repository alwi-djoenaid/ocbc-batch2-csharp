using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UnitTest_Mock.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string designation { get; set; }
    }
}
