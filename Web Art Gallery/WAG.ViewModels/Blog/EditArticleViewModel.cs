﻿using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WAG.ViewModels.Blog
{
    public class EditArticleViewModel
    {
        [Required]
        public string Title { get; set; }

        [Display(Name = "Short Description")]
        [Required]
        public string ShortDescription { get; set; }

        [Display(Name = "Article Content")]
        [Required]
        public string ArticleContent { get; set; }

        public IFormFile MainPicture { get; set; }

        public ICollection<IFormFile> Pictures { get; set; }
    }
}
