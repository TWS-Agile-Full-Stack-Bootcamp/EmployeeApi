using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using EmployeeApi;
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

            // then
            string result = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(File.ReadAllText("result.json")), Formatting.None);
            Assert.Equal(result, responseString);
        }
    }
}
