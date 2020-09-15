using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class Articles
    {
        private readonly List<Article> _articles = new List<Article>();
        
        public Article GetFirstArticle(int userId)
        {
            // foreach (var article in _articles)
            // {
            //     if (article.User.Id == userId)
            //     {
            //         return article;
            //     }
            // }
            //
            // return null;
            return _articles.First(article => article.User.Id == userId);
        }

        public IEnumerable<Article> GetArticles(int page, int pageSize)
        {
            // var articles = new List<Article>();
            // for (var index = 0; index < _articles.Count; index++)
            // {
            //     if (index >= page * pageSize && index < (page + 1) * pageSize)
            //     {
            //         articles.Add(_articles[index]);
            //     }
            // }
            // return articles;

            return _articles.Skip(page * pageSize).Take(pageSize);
        }
    }
    
    public class User
    {
        public int Id { get; set; }
    }


    public class Article
    {
        public User User { get; set; }
    }
}