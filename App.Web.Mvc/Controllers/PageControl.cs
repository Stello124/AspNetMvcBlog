﻿using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class PageControl : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
