using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost("/shippingdetails")]
        public ActionResult ShippingDetails(int length, int height, int width, int weight)
        {
            Package myPackage = new Package(length, height, width, weight);
            return RedirectToAction("ShippingDetails");
        }

        [HttpGet("/shippingdetails")]
        public ActionResult ShippingDetails()
        {
            List<Package> list = Package.GetList();
            return View(list);
        }

    }
}