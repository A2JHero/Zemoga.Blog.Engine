using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zemoga.Blog.Engine.Domain;
using Zemoga.Blog.Engine.Domain.Enum;
using Zemoga.Blog.Engine.Domain.Posts;
using Zemoga.Blog.Engine.Infrastructure.Data;
using Zemoga.Blog.Engine.Infrastructure.Data.Repository;
using Zemoga.Blog.Engine.Web.App;

namespace Zemoga.Blog.Engine.Tests
{
    public class PostsApprovalFlowServiceTest
    {
        IPostsService _postsService;
        IPostsApprovalFlowService _postsApprovalFlowService;

        public PostsApprovalFlowServiceTest()
        {
            var services = new ServiceCollection();

            //Register entity framework context for app
            services.AddDbContext<EngineContext>(options =>
            {
                options.UseSqlServer("Server=tcp:.\\;Database=ZemogaBlogEngine;User Id=ZemogaUsr;Password=P@ssword!;",
                                     sqlServerOptionsAction: sqlOptions =>
                                     {
                                         //Configuring Connection Resiliency: https://docs.microsoft.com/en-us/ef/core/miscellaneous/connection-resiliency 
                                         sqlOptions.EnableRetryOnFailure(maxRetryCount: 10, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
                                     });
            });

            #region [Dependency Injection]
            services.AddTransient<IPostsRepository, SQLPostsRepository>();
            services.AddTransient<IPostsService, PostsService>();
            services.AddTransient<IPostsApprovalFlowService, PostsApprovalFlowService>();
            #endregion

            var serviceProvider = services.BuildServiceProvider();
            _postsApprovalFlowService = serviceProvider.GetRequiredService<IPostsApprovalFlowService>();
            _postsService = serviceProvider.GetRequiredService<IPostsService>();
        }

        [Test]
        public async Task AddPost()
        {
            Post post = new Post("Test 1", "Lorem ipsum dolor amet....", "user");

            int postId = await _postsApprovalFlowService.AddPost(post);
            Assert.IsTrue(postId > 0);
        }

        [Test]
        public async Task ApprovePost()
        {
            Post post = new Post("Test 1", "Lorem ipsum dolor amet....", "user");

            int postId = await _postsApprovalFlowService.AddPost(post);

            //Approve post
            post.UpdatePostStatus(Domain.Enum.PostStatusEnum.Published, "editor");
            await _postsApprovalFlowService.UpdatePost(post);
        }

        [Test]
        public async Task AddPostComment()
        {
            Post post = new Post("Test 1", "Lorem ipsum dolor amet....", "user");

            int postId = await _postsApprovalFlowService.AddPost(post);

            //Approve post
            post.UpdatePostStatus(Domain.Enum.PostStatusEnum.Published, "editor");

            bool added = await _postsService.AddPostComment(postId, "user", "user@server.com", "Lorem ipsum dolor amet....");

            Assert.IsTrue(added);
        }

        [Test]
        public async Task GetApprovedPosts()
        {
            Post post = new Post("Test 1", "Lorem ipsum dolor amet....", "user");

            await _postsApprovalFlowService.AddPost(post);

            //Approve post
            post.UpdatePostStatus(Domain.Enum.PostStatusEnum.Published, "editor");

            var posts = await _postsApprovalFlowService.GetPostsByStatus(PostStatusEnum.Published.GetHashCode());

            Assert.IsTrue(posts.Count > 0);
        }
    }
}
