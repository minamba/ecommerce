using eCommerce.Api.Extensions;
using eCommerce.Api.Responses;
using eCommerce.Api.SwaggerExamples;
using eCommerce.Domain.Interfaces.Services;
using eCommerce.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Filters;
using System.Net;

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

        [HttpGet("/Articles")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ArticlesResponse), Description = "Retrieve list of all Articles")]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ArticlesResponseExample))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "An unexpected error occurred")]
        public async Task<IActionResult> GetArticlesAsync()
        {
            var articles = await _articleServices.GetArticlesAsync();
            return Ok(new ArticlesResponse { Articles = articles.ToArticleViewModel() });
        }
    }
}
