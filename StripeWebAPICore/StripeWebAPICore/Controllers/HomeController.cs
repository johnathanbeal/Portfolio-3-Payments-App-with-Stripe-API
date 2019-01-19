using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using StripeWebAPICore.Models;
using StripeWebAPICore.Services;

namespace StripeWebAPICore.Controllers
{
    public class HomeController : Controller
    {
        private IChargeCreationService _chargeCreationService;

        public HomeController(IChargeCreationService chargeCreationService)
        {
            _chargeCreationService = chargeCreationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult DefaultError()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Charge(string stripeEmail, string stripeToken)
        {
            _chargeCreationService.CreateCharge(stripeEmail, stripeToken);

            return View();
        }
    }
}
