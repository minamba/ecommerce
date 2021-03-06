using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain.Models
{
    [FirestoreData]
    public class Article
    {
        [FirestoreProperty]
        public int IdArticle { get; set; }
        [FirestoreProperty]
        public string Name { get; set; }
        [FirestoreProperty]
        public string Description { get; set; }
        [FirestoreProperty]
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
