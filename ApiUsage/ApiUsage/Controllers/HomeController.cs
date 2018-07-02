using Microsoft.AspNetCore.Mvc;
using System;
using ApiUsage.Models;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ApiUsage.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using (var client = new HttpClient())

            {
                // add the appropriate properties on top of the client base address.
                client.BaseAddress = new Uri("https://todolistappprogram.azurewebsites.net");

                //the .Result is important for us to extract the result of the response from the call
                var response = client.GetAsync("api/todo").Result;

                if (response.EnsureSuccessStatusCode().IsSuccessStatusCode)
                {
                    var stringResult = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<List<TodoItem>>(stringResult);
                    return View(obj);
                }

                return View();
            }
        }
    }
}