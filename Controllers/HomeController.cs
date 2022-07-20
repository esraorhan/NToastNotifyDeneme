using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NToastNotify;
using NToastNotifyDeneme.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NToastNotifyDeneme.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IToastNotification _toastNotification;
        public HomeController(ILogger<HomeController> logger, IToastNotification toastNotification)
        {
            _logger = logger;
            _toastNotification = toastNotification;
        }

        public IActionResult Index()
        {
            _toastNotification.AddSuccessToastMessage();
            _toastNotification.AddErrorToastMessage("Test Erro", new NotyOptions()
            {
                Timeout = 0
            }); // siz elinizle kapatmak istediğinizde kapanacaktır. 
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Message"] = "Your application description page.";
            _toastNotification.AddInfoToastMessage("My About Warning Message");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
