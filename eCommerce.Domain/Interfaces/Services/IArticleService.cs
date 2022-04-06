﻿using eCommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain.Interfaces.Services
{
    public interface IArticleService
    {
        Task<IEnumerable<Article>> GetArticlesAsync();
    }
}
