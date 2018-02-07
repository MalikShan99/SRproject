using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test.Models;

namespace test.Controllers
{
    public class HomeController : Controller
    {
        public ShowRoomDBContext lc = null;

        public HomeController(ShowRoomDBContext abc)
        {

            lc = abc;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        
        [HttpGet]
        public IActionResult test()
        {


            return View();
        }
        
        [HttpPost]
        public IActionResult test(Item t)
        {
            t.CreatedDate = System.DateTime.Now;
            t.CreatedBy = "ali";
            lc.Item.Add(t);
            lc.SaveChanges();

            ModelState.Clear();
            return View();


        }

       
}
}