using System.Collections.Generic;
using System.Linq;
using Kata.Models;

namespace Kata
{
    public class Articles
    {
        private readonly List<Article> _articles = new List<Article>();

        private const int PageSize = 10;
        
        public Article GetFirstArticle(int userId)
        {
            return _articles.First(article => article.User.Id == userId);
        }

        public IEnumerable<Article> GetArticles(int page)
        {
            var articles = new List<Article>();
            for (var index = 0; index < _articles.Count; index++)
            {
                if (index >= page * PageSize && index < (page + 1) * PageSize)
                {
                    articles.Add(_articles[index]);
                }
            }
            return articles;
        }
    }
}