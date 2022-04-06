using eCommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain.Interfaces.Repositories
{
    public interface IArticleRepository
    {
        Task<IEnumerable<Article>> GetArticlesAsync();
    }
}
