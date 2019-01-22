using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vue.Models;

namespace Vue.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Test()
        {
            return View();
        }

        // 基礎範例
        public IActionResult BasicExample()
        {
            return View();
        }

        // 模板語法
        public IActionResult TemplateSyntax()
        {
            return View();
        }

        // 計算屬性和偵聽器
        public IActionResult CalculationPropertie()
        {
            return View();
        }

        // Class與Style綁定
        public IActionResult ClassAndStyleBinding()
        {
            return View();
        }

        // 條件渲染
        public IActionResult ConditionalRendering()
        {
            return View();
        }

        // 列表渲染
        public IActionResult ListRendering()
        {
            return View();
        }

        // 事件處理
        public IActionResult EventProcessing()
        {
            return View();
        }

        // 表單輸入綁定
        public IActionResult FormInputBinding()
        {
            return View();
        }

        // 組件基礎
        public IActionResult ComponentBasis()
        {
            return View();
        }
    }
}