using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Techievibe.Infrastructure.Connections;
using Techievibe.Models.Entities.Blog;
using Techievibe.Services.Blog.Interfaces;

namespace Techievibe.Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly IConfiguration _configuration;

        public PostRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<int> Add(Post entity)
        {
            entity.CreatedTime = DateTime.Now;
            if (!entity.IsDraft)
            {
                entity.PublishedTime = DateTime.Now;
            }
            var query = "INSERT INTO Posts (Title, Body, AuthorId, IsDraft, ReadingTime, LikeCount, CommentCount, CreatedTime," +
                "CreatedByUserId, PublishedTime, PublishedByUserId, UpdatedTime, UpdatedByUserId, CategoryId) VALUES " +
                "@Title, @Body, @AuthorId, @IsDraft, @ReadingTime, @LikeCount, @CommentCount, @CreatedTime, @CreatedByUserId, " +
                "@PublishedTime, @PublishedByUserId, @UpdatedTime, @UpdatedByUserId, @CategoryId";

            using (var con = ConnectionFactory.GetConnection())
            {
                con.Open();
                var affectedRows = await con.ExecuteAsync(query, entity);
                return affectedRows;
            }


        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Post> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Post>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
