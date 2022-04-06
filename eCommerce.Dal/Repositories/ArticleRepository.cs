using eCommerce.Domain.Interfaces.Repositories;
using eCommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Dal.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        public async Task<IEnumerable<Article>> GetArticlesAsync() =>

        await Task.FromResult(new List<Article>
        {
            new Article { IdArticle = 1, Name = "Iphone", Description = "Iphone 13 pro", Price = float.Parse("1000,50") },
            new Article { IdArticle = 1, Name = "Ipad", Description = "Ipad pro 12 pouces", Price = float.Parse("1250,00") }

        } );
        
    }
}
