using System;

namespace Kata.Models
{
    public class Article
    {
        public User User { get; set; }
        public DateTime PublishTime { get; set; }
    }
}