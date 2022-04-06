using eCommerce.Domain.Interfaces.Services;
using eCommerce.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleServices;

        public ArticleController(IArticleService articleServices)
        {
            _articleServices = articleServices;
        }




        [HttpGet]
        public async Task<IActionResult> GetArticlesAsync()
        {
            var articles = await _articleServices.GetArticlesAsync();
            return Ok(articles);
        }
    }
}
