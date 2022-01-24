using System;

namespace Techievibe.Models.Entities.Blog
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public Author Author { get; set; }
        public bool IsDraft { get; set; }
        public int ReadingMinutes { get; set; }
        public int LikeCount { get; set; }
        public int CommentCount { get; set; }
        public DateTime CreatedTime { get; set; }
        public User CreatedUser { get; set; }
        public DateTime? PublishedTime { get; set; }
        public User PublishedUser { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public User UpdatedUser { get; set; }
        public PostCategory Category { get; set; }
    }
}
