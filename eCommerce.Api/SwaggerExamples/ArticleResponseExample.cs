using eCommerce.Api.Responses;
using eCommerce.Api.ViewModels;
using Swashbuckle.AspNetCore.Filters;

namespace eCommerce.Api.SwaggerExamples
{
    public class ArticleResponseExample : IExamplesProvider<ArticleResponse>
    {
        public ArticleResponse GetExamples() => new ArticleResponse
        {
            Article = new ArticleViewModel
            {
                IdArticle = 1,
                Name = "iphone",
                Description = "iphone 13",
                Price = 1000
            }
        };
    }
}
