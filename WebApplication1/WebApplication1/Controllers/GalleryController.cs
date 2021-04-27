using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class GalleryController : Controller
    {
        public async Task<IActionResult> Index(int page=1)
        {
            page = page < 1 ? 1 : page;
            var client = new HttpClient();
            var path = $"https://api.unsplash.com/photos?client_id=nviiZIrxgImnT3mQ9QDoSKAOuJ291HWqcaXsjv7u0Mo&page={page}";
            
            var response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                var responseStr = await response.Content.ReadAsStringAsync();
                var photosData= JsonConvert.DeserializeObject<PhotoData[]>(responseStr);

                ViewBag.CurrentPage = page;

                return View(photosData);
            }
            return View();
        }
    }
}
