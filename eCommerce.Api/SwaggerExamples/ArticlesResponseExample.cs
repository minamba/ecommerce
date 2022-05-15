using eCommerce.Api.Responses;
using eCommerce.Api.ViewModels;
using Swashbuckle.AspNetCore.Filters;

namespace eCommerce.Api.SwaggerExamples
{
    public class ArticlesResponseExample : IExamplesProvider<ArticlesResponse>
    {
        public ArticlesResponse GetExamples() => new ArticlesResponse
        {
            Articles = new[]
            {
                new ArticleViewModel
                {
                    IdArticle = 1,
                    Name = "iphone",
                    Description =  "iphone 13",
                    Price = 1000,
                },
                new ArticleViewModel
                {
                    IdArticle = 1,
                    Name = "samsung",
                    Description =  "samsung 9",
                    Price = 1000,
                },

            }
        };
    }
}
