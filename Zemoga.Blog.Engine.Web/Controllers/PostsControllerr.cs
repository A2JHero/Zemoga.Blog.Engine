using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zemoga.Blog.Engine.Web.App;
using Zemoga.Blog.Engine.Web.Models.Posts;

namespace Zemoga.Blog.Engine.Web.Controllers
{
    public class PostsController : Controller
    {
        IPostsService _postsService;

        public PostsController(IPostsService postsService)
        {
            _postsService = postsService;
        }

        public async Task<IActionResult> Index(int id)
        {
            PostDetailViewModel model = new PostDetailViewModel();
            model.PostId = id;
            model.Post = await _postsService.GetPost(id);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(int id, PostDetailViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _postsService.AddPostComment(id, model.AuthorName, model.AuthorEmail, model.Comment);
                model.AuthorName = string.Empty;
                model.AuthorEmail = string.Empty;
                model.Comment = string.Empty;

                return RedirectToAction("Index", new { id = id });
            }

            model.PostId = id;
            model.Post = await _postsService.GetPost(id);

            return View(model);
        }
    }
}
