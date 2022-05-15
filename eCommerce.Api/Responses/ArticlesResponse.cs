using eCommerce.Api.ViewModels;

namespace eCommerce.Api.Responses
{
    public class ArticlesResponse
    {
        public IEnumerable<ArticleViewModel> Articles { get; set; }
    }
}
