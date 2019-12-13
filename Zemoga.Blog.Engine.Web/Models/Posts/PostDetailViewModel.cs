using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Zemoga.Blog.Engine.Domain;

namespace Zemoga.Blog.Engine.Web.Models.Posts
{
    public class PostDetailViewModel
    {
        public Post Post { get; set; }

        public int PostId { get; set; }

        [Required(ErrorMessage = "{0} field is required")]
        [StringLength(100, ErrorMessage = "{0} field only allows 100 characters")]
        [Display(Name = "Comment author")]
        public string AuthorName { get; set; }

        [Required(ErrorMessage = "{0} field is required")]
        [StringLength(100, ErrorMessage = "{0} field only allows 100 characters")]
        [Display(Name = "Comment email")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "{0} field is an invalid email")]
        public string AuthorEmail { get; set; }

        [Required(ErrorMessage = "{0} field is required")]
        [StringLength(4000, ErrorMessage = "{0} field only allows 4000 characters")]
        [Display(Name = "Comment")]
        public string Comment { get; set; }
    }
}
