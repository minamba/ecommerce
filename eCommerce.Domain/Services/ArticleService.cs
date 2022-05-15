using eCommerce.Domain.Interfaces.Repositories;
using eCommerce.Domain.Interfaces.Services;
using eCommerce.Domain.Models;
//using log4net;
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
        //private static ILog _logger;
        string error_no_data = "Un problème à été rencontré, aucune data n'a été trouvée";

        public ArticleService(IArticleRepository articleRepository /*, ILog logger*/)
        {
            _articleRepository = articleRepository;
            //_logger = logger;
        }


        public async Task<IEnumerable<Article>> GetArticlesAsync()
        {
            if(await _articleRepository.GetArticlesAsync() != null)
                return await _articleRepository.GetArticlesAsync();
            else
                //_logger.Error(error_no_data);
                throw new Exception(error_no_data);
        }

        //public async IAsyncEnumerable<Article> GetArticlesAsync()
        //{
        //   throw new NotImplementedException();
        //}
    }
}
