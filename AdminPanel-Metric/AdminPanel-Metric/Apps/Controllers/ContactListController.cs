using System;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel_Metric.Apps.Controllers
{
    public class ContactListController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}