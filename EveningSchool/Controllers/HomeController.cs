using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EveningSchool.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EveningSchool.Models;
using EveningSchool.ViewModels;

namespace EveningSchool.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IArticleService articleService;

        public HomeController(ILogger<HomeController> logger, IArticleService articleService)
        {
            _logger = logger;
            this.articleService = articleService;
        }

        public IActionResult Index()
        {
            var articles = articleService.GetAllArticles();
            articles.Reverse();
            return View(articles);
        }

        public IActionResult AllStudent()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}