using EveningSchool.Business.Interfaces;
using EveningSchool.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EveningSchool.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;

        public ArticleController(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        // GET
        public IActionResult Index()
        {
            var articles = articleService.GetAllArticles();
            return View(articles);
        }

        public IActionResult Article(int id)
        {
            var article = articleService.GetArticleById(id);
            return View(article);
        }

        public IActionResult GetAllArticles()
        {
            var articles = articleService.GetAllArticles();
            return Json(articles);
        }
        
        [HttpPost]
        public JsonResult AddArticle(ArticleViewModel model)
        {
            var article = articleService.AddArticle(model);
            return Json(article);
        }

        [HttpPost]
        public JsonResult EditArticle(ArticleViewModel model)
        {
            var article = articleService.EditArticle(model);
            return Json(article);
        }

        [HttpDelete]
        public IActionResult DeleteArticle(ArticleViewModel model)
        {
            articleService.DeleteArticle(model);
            return Ok();
        }
    }
}