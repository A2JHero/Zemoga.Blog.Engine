#pragma checksum "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93aafcc4b884d631e9c384df2e7227f37ba8c9f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Views\_ViewImports.cshtml"
using Zemoga.Blog.Engine.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Views\_ViewImports.cshtml"
using Zemoga.Blog.Engine.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93aafcc4b884d631e9c384df2e7227f37ba8c9f8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ac80ade242bc9a4526524ef6f042c721a38b32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Zemoga.Blog.Engine.Web.Models.Home.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 7 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Views\Home\Index.cshtml"
     foreach (var post in Model.Posts)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-4\">\r\n            <h2>");
#nullable restore
#line 10 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Views\Home\Index.cshtml"
           Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 11 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Views\Home\Index.cshtml"
             if (post.PostStatusId == (int)Zemoga.Blog.Engine.Domain.Enum.PostStatusEnum.Published && post.ApprovalDate.HasValue)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <small>Published on: ");
#nullable restore
#line 13 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Views\Home\Index.cshtml"
                                Write(post.ApprovalDate.Value.ToString("dd-MM-yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n");
#nullable restore
#line 14 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Views\Home\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <small>Unpublished</small>\r\n");
#nullable restore
#line 18 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>By: <a href=\"javascript:;\">");
#nullable restore
#line 19 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Views\Home\Index.cshtml"
                                     Write(post.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n            <p><a class=\"btn btn-default\"");
            BeginWriteAttribute("href", " href=\"", 698, "\"", 758, 1);
#nullable restore
#line 20 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 705, Url.Action("Index", "Posts", new { id=post.PostId }), 705, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">View more &raquo;</a></p>\r\n        </div>\r\n");
#nullable restore
#line 22 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Zemoga.Blog.Engine.Web.Models.Home.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591