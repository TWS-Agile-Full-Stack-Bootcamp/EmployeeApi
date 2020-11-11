using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("employees")]
    public class EmployeeController
    {
        [HttpGet]
        public string Get()
        {
            return File.ReadAllText("AllEmployees.json");
        }
    }
}
