using eCommerce.Dal.Dto;
using eCommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Dal.Extensions
{
    public static class ArticleDtoExtensions
    {
        public static IEnumerable<Article> ToArticle(this IEnumerable<ArticleDto> articles) => articles.Select(ToArticle);

        public static Article ToArticle(this ArticleDto article) =>
            new()
            {
                IdArticle = article.IdArticle,
                Name = article.Name,
                Description = article.Description,
                Price = article.Price
            };
    }
}
