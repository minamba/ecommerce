using eCommerce.Domain.Interfaces.Repositories;
using eCommerce.Domain.Interfaces.Services;
using eCommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;


        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }


        public async Task<IEnumerable<Article>> GetArticlesAsync()
        {
            return await _articleRepository.GetArticlesAsync();
        }
    }
}
