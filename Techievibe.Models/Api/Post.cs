using System;
using System.Collections.Generic;
using System.Text;

namespace Techievibe.Models.Api
{
    public class Post : RequestBase
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostBody { get; set; }
        public string PostAuthor { get; set; }
        public string PostDate { get; set; }
        public bool PostIsDraft { get; set; }
        public int PostReadingTime { get; set; }
        public int PostLikeCount { get; set; }
        public int PostCommentCount { get; set; }
    }
}
