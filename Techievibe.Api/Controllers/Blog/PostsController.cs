using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Techievibe.Api.Interfaces;
using Techievibe.Models.Api;

namespace Techievibe.Api.Controllers.Blog
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private IPostRequestHandler _postRequestHandler;
        public PostsController(IPostRequestHandler postRequestHandler)
        {
            _postRequestHandler = postRequestHandler;
        }
        [HttpPost("create")]
        public ActionResult<string> CreatePost([FromBody] Post post)
        {
            if (post == null)
                return StatusCode(400, "Bad Request - Request is null.");

            post.RequestId = Guid.NewGuid().ToString();

            if (!_postRequestHandler.IsValidPostRequest(post))
                return StatusCode(400, "Bad Request - Request fields are not valid.");

            try
            {
                _postRequestHandler.CreatePost(post);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

            return StatusCode(200, "Post Created");
        }
    }
}
