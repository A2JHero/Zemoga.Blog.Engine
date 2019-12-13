using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zemoga.Blog.Engine.Web.Areas.PublishFlow.Models.Publish
{
    public class PostInputModel
    {
        public int PostId { get; set; }

        [Required(ErrorMessage = "{0} field is required")]
        [StringLength(300, ErrorMessage = "{0} field only allows 300 characters")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "{0} field is required")]
        [StringLength(4000, ErrorMessage = "{0} field only allows 4000 characters")]
        [Display(Name = "Post Content")]
        public string Text { get; set; }

        public int PostStatusId { get; set; }
        public string PostStatusName { get; set; }

        public string SendType { get; set; }
        public bool IsEditMode { get; set; }
    }
}
