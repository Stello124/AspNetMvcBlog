﻿using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class AdminSettingsControl : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
