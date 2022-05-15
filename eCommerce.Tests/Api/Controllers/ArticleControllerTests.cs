using AutoFixture.Xunit2;
using eCommerce.Api.Controllers;
using eCommerce.Domain.Interfaces.Services;
using eCommerce.Domain.Models;
using eCommerce.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using NFluent;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace eCommerce.Tests.Api.Controllers
{
    public class ArticleControllerTests
    {
        [Fact]
        public async Task Should_Return_200_When_Get_Articles_Return_OK()
        {

            //var articleService = Substitute.For<IArticleService>();
            //articleService.GetArticlesAsync().Returns(new List<Article>
            //{
            //    new Article { IdArticle = 1,  Name = "Iphone", Description = "Iphone 13 pro", Price = float.Parse("1000,50") },
            //    new Article { IdArticle = 1,  Name = "Ipad", Description = "Iphone pro 12 pouce", Price = float.Parse("1100,50") }
            //});

            //var articleController = new ArticleController(articleService);
            //var result = await articleController.GetArticlesAsync();

            //var okObjectResult = result as OkObjectResult;
            //var value = okObjectResult.Value as IEnumerable<Article>;

            //Check.That(value).IsNotNull();
        }
    }
}
