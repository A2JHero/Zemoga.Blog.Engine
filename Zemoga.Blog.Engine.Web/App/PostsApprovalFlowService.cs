using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zemoga.Blog.Engine.Domain;
using Zemoga.Blog.Engine.Domain.Posts;

namespace Zemoga.Blog.Engine.Web.App
{
    public class PostsApprovalFlowService : IPostsApprovalFlowService
    {
        IPostsRepository _postsRepository;

        public PostsApprovalFlowService(IPostsRepository postsRepository)
        {
            _postsRepository = postsRepository;
        }

        public async Task<int> AddPost(Post post)
        {
            _postsRepository.Add(post);
            await _postsRepository.UnitOfWork.SaveChangesAsync();

            return post.PostId;
        }

        public async Task<IList<Post>> GetPostsByStatus(int? postStatusId)
        {
            return await _postsRepository.GetByStatus(postStatusId);
        }

        public async Task RemovePost(int postId)
        {
            await _postsRepository.Delete(postId);
            await _postsRepository.UnitOfWork.SaveChangesAsync();
        }

        public async Task UpdatePost(Post post)
        {
            _postsRepository.Update(post);
            await _postsRepository.UnitOfWork.SaveChangesAsync();
        }
    }
}
