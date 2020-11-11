using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using EmployeeApi;
using EmployeeApi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using Xunit;

namespace EmployeeApiTest.Controllers
{
    public class EmployeeApiTest
    {
        [Fact]
        public async Task Should_return_all_employees_when_call_employee_api()
        {
            // given
            TestServer server = new TestServer(new WebHostBuilder()
               .UseStartup<Startup>());
            HttpClient client = server.CreateClient();

            // when
            var response = await client.GetAsync("/employees");
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            List<Employee> actualEmployees = JsonConvert.DeserializeObject<List<Employee>>(responseString);

            // then
            List<Employee> expectedEmployees = new List<Employee>
            {
                new Employee(id: 0, name: "Xiaoming", age: 20, gender: "Male"),
                new Employee(id: 1, name: "Xiaohong", age: 19, gender: "Female"),
                new Employee(id: 2, name: "Xiaozhi", age: 15, gender: "Male"),
                new Employee(id: 3, name: "Xiaogang", age: 16, gender: "Male"),
                new Employee(id: 4, name: "Xiaoxia", age: 15, gender: "Female"),
            };

            Assert.Equal(expectedEmployees, actualEmployees);
        }
    }
}
