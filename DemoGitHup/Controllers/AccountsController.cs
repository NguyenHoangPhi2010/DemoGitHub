﻿using Microsoft.AspNetCore.Mvc;

namespace DemoGitHup.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
