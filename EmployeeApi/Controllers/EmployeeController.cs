using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EmployeeApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("employees")]
    public class EmployeeController
    {
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return GetAllEmployees();
        }

        private IEnumerable<Employee> GetAllEmployees()
        {
            return new List<Employee>()
            {
                new Employee(id: 0, name: "Xiaoming", age: 20, gender: "Male"),
                new Employee(id: 1, name: "Xiaohong", age: 19, gender: "Female"),
                new Employee(id: 2, name: "Xiaozhi", age: 15, gender: "Male"),
                new Employee(id: 3, name: "Xiaogang", age: 16, gender: "Male"),
                new Employee(id: 4, name: "Xiaoxia", age: 15, gender: "Female"),
            };
        }
    }
}
