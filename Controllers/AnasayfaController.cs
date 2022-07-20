using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NToastNotifyDeneme.Controllers
{
    public class AnasayfaController : Controller
    {
       private readonly IToastNotification _toastNotification;

        public AnasayfaController(IToastNotification toastNotification)
        {
            _toastNotification = toastNotification;
        }

        public IActionResult Index()
        {
            _toastNotification.AddSuccessToastMessage("başarılı configre edilmiş bir toastr");
            _toastNotification.AddErrorToastMessage("Test Erro", new NotyOptions()
            {
                Timeout = 0
            });
            return View();
        }
    }
}
