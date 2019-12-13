using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zemoga.Blog.Engine.Domain;

namespace Zemoga.Blog.Engine.Web.Models.Home
{
    public class HomeViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
    }
}
