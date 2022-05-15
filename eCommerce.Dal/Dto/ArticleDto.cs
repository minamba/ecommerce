using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Dal.Dto
{
    [FirestoreData]
    public class ArticleDto
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

    }
}
