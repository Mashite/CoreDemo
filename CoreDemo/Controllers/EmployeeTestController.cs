using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class EmployeeTestController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://localhost:44370/api/Default");
            var jsonString = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject < List<Class1>>(jsonString);
            return View(values);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Class1 p)
        {
            var httpClient = new HttpClient();
            var jsonString = JsonConvert.SerializeObject(p);
            StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://localhost:44370/api/Default", content);
            if(response.IsSuccessStatusCode)
            {
                return RedirectToAction("index");
            }
            return View(p);

        }

        [HttpGet]
        public async Task<IActionResult> EditEmployee(int id)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://localhost:44370/api/Default/"+id);
            if(response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<Class1>(jsonString);
                return View(values);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> EditEmployee(Class1 c)
        {
            var httpClient = new HttpClient();
            var jsonString = JsonConvert.SerializeObject(c);
            StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync("https://localhost:44370/api/Default", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("index");
            }
            return View(c);
        }
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.DeleteAsync("https://localhost:44370/api/Default/" + id);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }


    public class Class1
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
