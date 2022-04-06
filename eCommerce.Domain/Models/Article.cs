using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain.Models
{
    public class Article
    {
        public int IdArticle { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        //public ArticleImage Image { get; set; }



        public Article(int idArticle, string name, string description, float price)
        {
            IdArticle = idArticle;
            Name = name;
            Description = description;
            Price = price;
        }

        public Article()
        {

        }
    }
}
