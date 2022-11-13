using System;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel_Metric.Dashboard.Controllers
{
    public class CryptoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}