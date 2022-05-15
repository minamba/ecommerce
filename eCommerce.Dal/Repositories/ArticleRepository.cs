using eCommerce.Domain.Interfaces.Repositories;
using eCommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using eCommerce.Dal.Dto;
using eCommerce.Dal.Extensions;

namespace eCommerce.Dal.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private string path = AppDomain.CurrentDomain.BaseDirectory + @"ecommercedb-18b5c-firebase.json";
        private static FirestoreDb db = FirestoreDb.Create("ecommercedb-18b5c");

        public ArticleRepository() => Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);



        public async Task<IEnumerable<Article>> GetArticlesAsync()
        {
            List<ArticleDto> lstArticle = new List<ArticleDto>();
            Query docRef = db.Collection("Article");
            QuerySnapshot snap = await docRef.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                ArticleDto article = docsnap.ConvertTo<ArticleDto>();

                if (docsnap.Exists)
                {
                    ArticleDto newArticle = new ArticleDto();
                    newArticle.IdArticle = article.IdArticle;
                    newArticle.Name = article.Name;
                    newArticle.Description = article.Description;
                    newArticle.Price = article.Price;

                    lstArticle.Add(newArticle);

                }
            }
            return lstArticle.ToArticle();
        }



        //GET ARTICLE WITH IASYNCENUMERABLE METHOD
        //public async  IAsyncEnumerable<Article> GetArticlesAsync()
        //{
        //    List<ArticleDto> lstArticle = new List<ArticleDto>();
        //    Query docRef = db.Collection("Article");
        //    QuerySnapshot snap = await docRef.GetSnapshotAsync();

        //    foreach (DocumentSnapshot docsnap in snap)
        //    {
        //        ArticleDto article = docsnap.ConvertTo<ArticleDto>();

        //        if (docsnap.Exists)
        //        {
        //            yield return await Task.FromResult(new ArticleDto()
        //            {
        //                IdArticle = article.IdArticle,
        //                Name = article.Name,
        //                Description = article.Description,
        //                Price = article.Price
        //            }.ToArticle());

        //        }
        //    }
        //}



        //TO DO : Faire la methode pour recuperer un article via l'ID
        //public async Task<IEnumerable<Article>> GetArticlesByIdAsync(string id)
        //{
        //    Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
        //    List<Article> lstArticle = new List<Article>();
        //    DocumentReference docRef = db.Collection("Article").Document("id"); //2eNxW2Z3vdSqjFSfZYZY (id du premier article de la collection)
        //    DocumentSnapshot snap = await docRef.GetSnapshotAsync();

        //    if(snap.Exists)
        //    {
        //        Article newArticle = new Article();

        //        Article article = snap.ConvertTo<Article>();
        //        newArticle.IdArticle = article.IdArticle;
        //        newArticle.Name = article.Name;
        //        newArticle.Description = article.Description;
        //        newArticle.Price = article.Price;

        //        lstArticle.Add(newArticle);
        //    }

        //    return lstArticle;
        //}

    }
}
