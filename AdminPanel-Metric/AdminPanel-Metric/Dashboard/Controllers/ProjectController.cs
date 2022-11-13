using System;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel_Metric.Dashboard.Controllers
{
    public class ProjectController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}