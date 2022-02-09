using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EveningSchool.Business.Interfaces;
using EveningSchool.Migrations;
using EveningSchool.Models;
using EveningSchool.ViewModels;

namespace EveningSchool.Business.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IMapper mapper;
        private readonly ApplicationContext db;

        public ArticleService(IMapper mapper, ApplicationContext db)
        {
            this.mapper = mapper;
            this.db = db;
        }

        public List<ArticleViewModel> GetAllArticles()
        {
            var articles = db.Articles.ToList();
            return mapper.Map<List<ArticleViewModel>>(articles);
        }

        public ArticleViewModel GetArticleById(int id)
        {
            var article = db.Articles.FirstOrDefault(x => x.Id == id);
            return mapper.Map<ArticleViewModel>(article);
        }

        public ArticleViewModel AddArticle(ArticleViewModel model)
        {
            var addArticle = mapper.Map<Article>(model);
            addArticle.DatePublication = DateTime.Now;
            db.Articles.Add(addArticle);
            db.SaveChanges();
            return mapper.Map<ArticleViewModel>(addArticle);
        }

        public ArticleViewModel EditArticle(ArticleViewModel model)
        {
            var editArticle = db.Articles.FirstOrDefault(x => x.Id == model.Id);
            if (editArticle != null)
            {
                editArticle.Title = model.Title;
                editArticle.Image = model.Image;
                editArticle.Text = model.Text;
                db.SaveChanges();
            }

            return mapper.Map<ArticleViewModel>(editArticle);
        }

        public void DeleteArticle(ArticleViewModel model)
        {
            var article = db.Articles.FirstOrDefault(x => x.Id == model.Id);
            if (article != null) db.Articles.Remove(article);
            db.SaveChanges();
        }
    }
}