using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Test.Models;
using System.Data;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        User u = new User();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(u);
        }
        [HttpPost]
        public IActionResult Index(User u)
        {
            Repository r = new Repository();
            r.getUserId(u);
            if (u.Id == null)
            {

            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Show()
        {
            Repository r = new Repository();
            DataTable dt = r.test("PARCELS");
            return View(dt);
        }
        [HttpGet]
        public IActionResult Package()
        {
            Parcel p = new Parcel();
            return View(p);
        }

        [HttpPost]
        public IActionResult Package(Parcel p)
        {
            Repository r = new Repository();
            r.addParcel(p);
            ViewBag.client = p;
            return null ;
        }
        /*
         *[http get]
        public IActionResult Client()
        {
            c = client;
        }
        */

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
