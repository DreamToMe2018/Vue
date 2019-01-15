using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Vue.Controllers
{
    public class ServiceController : Controller
    {
        [HttpPost]
        public IActionResult GetAnswer(string question)
        {
            if (question == "Hello?")
                return Json(true);

            return Json(false);
        }
    }
}