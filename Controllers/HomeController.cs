using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


       
        [HttpGet]
        public IActionResult Index()
        {
            ListModel model = new ListModel();
            List<TestModel> TestModels = new List<TestModel>();
            TestModel item = new TestModel();
            item.Id = 1;item.Name = "数学";item.Introduction = "数学运用于题目中";
            TestModels.Add(item);
            TestModel item2 = new TestModel();
            item2.Id = 2; item2.Name = "语文"; item2.Introduction = "语文运用于题目中";
            TestModels.Add(item2);
            model.TestModels = TestModels;
            return View(model);
        }


        [HttpPost]
        public IActionResult Index(int[] Problem,int[] RecommendedValue)
        {
            ArrayList list = new ArrayList();

            foreach (var item in Problem)
            {
                //可以自己写Insert语句(添加数据)

                list.Add(item.ToString());//这样写方便调试看
            }
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
    }
}
