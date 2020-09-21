using System.Collections.Generic;
using System.Linq;
using Kata.Models;

namespace Kata
{
    public class Blog
    {
        private readonly List<Article> _articles;
        private const int PageSize = 10;

        public Blog(List<Article> articles)
        {
            _articles = articles;
        }

        public Page GetMainPage()
        {
            return new MainPage()
            {
                TopBar = GetTopBar(),
                Footer = GetFooter(),
                Articles = GetLatestArticlesByPage()
            };
        }

        public Page GetUserPage(int userId)
        {
            return new UserPage()
            {
                TopBar = GetTopBar(),
                Footer = GetFooter(),
                Articles = GetUserArticles(userId),
                ReadingList = GetReadingList(userId),
            };
        }

        public Page GetSettingPage(int userId)
        {
            return new SettingPage()
            {
                Preference = GetPreference(userId),
                Language = GetLanguage(userId),
            };
        }

        private IEnumerable<Article> GetLatestArticlesByPage()
        {
            return _articles.OrderByDescending(article => article.PublishTime).Take(10);
        }

        private IEnumerable<Article> GetUserArticles(int userId)
        {
            return _articles.Where(article => article.User.Id == userId);
        }

        private IEnumerable<Article> GetUserArticlesByPage(int userId, int page)
        {
            return GetUserArticles(userId).Skip((page - 1) * PageSize).Take(PageSize);
        }

        private object GetFooter()
        {
            throw new System.NotImplementedException();
        }

        private object GetTopBar()
        {
            throw new System.NotImplementedException();
        }
        
        private IEnumerable<Article> GetReadingList(int userId)
        {
            throw new System.NotImplementedException();
        }

        private string GetLanguage(int userId)
        {
            throw new System.NotImplementedException();
        }

        private object GetPreference(int userId)
        {
            throw new System.NotImplementedException();
        }
    }

    public class Page
    {
        public object TopBar { get; set; }
        
        public IEnumerable<Article> Articles { get; set; }

        public object Footer { get; set; }
    }

    public class MainPage : Page
    {
        
    }

    public class UserPage : Page
    {
        public IEnumerable<Article> ReadingList { get; set; }
    }

    public class SettingPage : Page
    {
        public object Preference { get; set; }

        public string Language { get; set; }
    }
}