using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using Resume_Napawan.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
//using  Resume_Napawan.Models.ProjectNapawanContext;
using static Resume_Napawan.Models.ProjectNapawanContext;

//using static Resume_Napawan.Models.NetCoreWebApp;

namespace Resume_Napawan.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IActionResult Index()
        {
            //Resume_NapawanContext context = HttpContext.RequestServices.GetService(serviceType: typeof(Resume_NapawanContext.Models.Resume_NapawanContext)) as Resume_NapawanContext;

            //return View(context.Getprojectname());

            return View();
        }


        public IActionResult Created()
        {
            return View();
        
        }
            public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
