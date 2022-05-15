using Google.Cloud.Firestore;

namespace eCommerce.Api.ViewModels
{
    [FirestoreData]
    public class ArticleViewModel
    {
        [FirestoreProperty]
        public int IdArticle { get; set; }
        [FirestoreProperty]
        public string Name { get; set; }
        [FirestoreProperty]
        public string Description { get; set; }
        [FirestoreProperty]
        public float Price { get; set; }
    }
}
