using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zemoga.Blog.Engine.Domain;
using Zemoga.Blog.Engine.Domain.Posts;

namespace Zemoga.Blog.Engine.Web.App
{
    public class PostsService : IPostsService
    {
        IPostsRepository _postsRepository;

        public PostsService(IPostsRepository postsRepository)
        {
            _postsRepository = postsRepository;
        }

        public async Task<bool> AddPostComment(int postId, string authorName, string authorEmail, string comment)
        {
            var post = await GetPost(postId);

            bool canAdd = post.AddComment(authorName, authorEmail, comment);

            if (canAdd)
            {
                _postsRepository.Update(post);
                await _postsRepository.UnitOfWork.SaveChangesAsync();
            }

            return canAdd;
        }

        public async Task<IList<Post>> GetAllPosts()
        {
            return await _postsRepository.GetAll();
        }

        public async Task<Post> GetPost(int postId)
        {
            return await _postsRepository.GetPost(postId);
        }
    }
}
