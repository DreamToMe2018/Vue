using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Vue.Controllers
{
    public class OrganizeController : Controller
    {
        public IActionResult OrganizeTemplate()
        {
            return View();
        }

        public IActionResult OrganizeTemplate2()
        {
            return View();
        }
    }
}