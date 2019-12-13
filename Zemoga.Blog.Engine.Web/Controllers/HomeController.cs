using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Zemoga.Blog.Engine.Web.App;
using Zemoga.Blog.Engine.Web.Models;
using Zemoga.Blog.Engine.Web.Models.Home;
using Zemoga.Blog.Engine.Domain.Enum;

namespace Zemoga.Blog.Engine.Web.Controllers
{
    public class HomeController : Controller
    {
        IPostsApprovalFlowService _postsApprovalFlowService;

        public HomeController(IPostsApprovalFlowService postsApprovalFlowService)
        {
            _postsApprovalFlowService = postsApprovalFlowService;
        }

        public async Task<IActionResult> Index()
        {
            HomeViewModel model = new HomeViewModel();
            if (User.Identity.IsAuthenticated)
                model.Posts = await _postsApprovalFlowService.GetPostsByStatus(null);
            else
                model.Posts = await _postsApprovalFlowService.GetPostsByStatus(PostStatusEnum.Published.GetHashCode());
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
