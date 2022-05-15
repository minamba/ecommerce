using eCommerce.Api.ViewModels;
using eCommerce.Domain.Models;

namespace eCommerce.Api.Extensions
{
    public static class ArticleExtension
    {
        public static IEnumerable<ArticleViewModel> ToArticleViewModel(this IEnumerable<Article> articles) => articles.Select(ToArticleViewModel);

        public static ArticleViewModel ToArticleViewModel(this Article article) =>
            new()
            {
                IdArticle = article.IdArticle,
                Description = article.Description,
                Name = article.Name,
                Price = article.Price,
            };
    }
}
