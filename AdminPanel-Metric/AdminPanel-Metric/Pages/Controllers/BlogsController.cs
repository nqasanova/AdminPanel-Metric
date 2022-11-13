using System;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel_Metric.Pages.Controllers
{
    public class BlogsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}