using System.Collections.Generic;
using EveningSchool.ViewModels;

namespace EveningSchool.Business.Interfaces
{
    public interface IArticleService
    {
        public List<ArticleViewModel> GetAllArticles();
        public ArticleViewModel GetArticleById(int id);
        public ArticleViewModel AddArticle(ArticleViewModel model);
        public ArticleViewModel EditArticle(ArticleViewModel model);
        public void DeleteArticle(ArticleViewModel model);
    }
}