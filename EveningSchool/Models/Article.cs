﻿using System;

namespace EveningSchool.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
        public DateTime DatePublication { get; set; }
    }
}