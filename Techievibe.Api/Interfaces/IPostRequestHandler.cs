using Techievibe.Models.Api;

namespace Techievibe.Api.Interfaces
{
    public interface IPostRequestHandler
    {
        bool IsValidPostRequest(Post post);
        void CreatePost(Post post);
    }
}
