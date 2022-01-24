using Techievibe.Api.Interfaces;
using Techievibe.Models.Api;

namespace Techievibe.Api.Routers
{
    public class PostRequestHandler : IPostRequestHandler
    {
        public PostRequestHandler()
        {

        }
        public void CreatePost(Post post)
        {
            
        }

        public bool IsValidPostRequest(Post post)
        {
            bool isValid = true;
            if(string.IsNullOrEmpty(post.PostAuthor) || string.IsNullOrEmpty(post.PostBody) || string.IsNullOrEmpty(post.PostTitle) || post.PostReadingTime == 0)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
