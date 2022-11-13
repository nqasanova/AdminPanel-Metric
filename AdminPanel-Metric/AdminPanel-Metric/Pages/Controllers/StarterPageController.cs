using System;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel_Metric.Pages.Controllers
{
    public class StarterPageController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}