using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zemoga.Blog.Engine.Domain;

namespace Zemoga.Blog.Engine.Web.App
{
    /// <summary>
    /// Contract for post approval flow
    /// </summary>
    public interface IPostsApprovalFlowService
    {
        /// <summary>
        /// Add new post
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        Task<int> AddPost(Post post);

        /// <summary>
        /// Update existing post
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        Task UpdatePost(Post post);

        /// <summary>
        /// Remove post by id
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        Task RemovePost(int postId);

        /// <summary>
        /// Get post by status
        /// </summary>
        /// <param name="postStatusId">(Optional) status id</param>
        /// <returns></returns>
        Task<IList<Post>> GetPostsByStatus(int? postStatusId);
    }
}
