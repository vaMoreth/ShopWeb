﻿using Microsoft.AspNetCore.Mvc;

namespace ShopWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
