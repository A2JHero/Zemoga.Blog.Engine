#pragma checksum "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Areas\PublishFlow\Views\Publish\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2259e807a0826baa994ff055716f2b1b23e4be40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PublishFlow_Views_Publish_Index), @"mvc.1.0.view", @"/Areas/PublishFlow/Views/Publish/Index.cshtml")]
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
#line 1 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Areas\PublishFlow\Views\_ViewImports.cshtml"
using Zemoga.Blog.Engine.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Areas\PublishFlow\Views\_ViewImports.cshtml"
using Zemoga.Blog.Engine.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2259e807a0826baa994ff055716f2b1b23e4be40", @"/Areas/PublishFlow/Views/Publish/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2648bb7b850ff7c13a5a52b32ae399bbd0a05609", @"/Areas/PublishFlow/Views/_ViewImports.cshtml")]
    public class Areas_PublishFlow_Views_Publish_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Zemoga.Blog.Engine.Web.Areas.PublishFlow.Models.Publish.PostsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "PublishFlow", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Publish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Areas\PublishFlow\Views\Publish\Index.cshtml"
  
    ViewData["Title"] = "Posts";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-sm-12"">
        <h1>All Posts</h1>
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Date</th>
                    <th>Title</th>
                    <th>Author</th>
                    <th>Status</th>
                    <th>Approved by</th>
                    <th>Approval date</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 24 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Areas\PublishFlow\Views\Publish\Index.cshtml"
                 foreach (var post in Model.Posts)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 27 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Areas\PublishFlow\Views\Publish\Index.cshtml"
                                   Write(post.PostId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Areas\PublishFlow\Views\Publish\Index.cshtml"
                       Write(post.CreationtDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Areas\PublishFlow\Views\Publish\Index.cshtml"
                       Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Areas\PublishFlow\Views\Publish\Index.cshtml"
                       Write(post.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Areas\PublishFlow\Views\Publish\Index.cshtml"
                       Write(post.PostStatus.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Areas\PublishFlow\Views\Publish\Index.cshtml"
                       Write(post.ApproverName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 34 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Areas\PublishFlow\Views\Publish\Index.cshtml"
                             if (post.ApprovalDate.HasValue)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Areas\PublishFlow\Views\Publish\Index.cshtml"
                            Write(post.ApprovalDate.Value.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Areas\PublishFlow\Views\Publish\Index.cshtml"
                                                                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1489, "\"", 1574, 1);
#nullable restore
#line 40 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Areas\PublishFlow\Views\Publish\Index.cshtml"
WriteAttributeValue("", 1496, Url.Action("Post", "Publish", new { id = post.PostId, area = "PublishFlow" }), 1496, 78, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Edit\"> <span class=\"glyphicon glyphicon-edit\">Edit</span></a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 43 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Areas\PublishFlow\Views\Publish\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div class=\"col-sm-12\">\r\n");
#nullable restore
#line 48 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Areas\PublishFlow\Views\Publish\Index.cshtml"
         if (User.IsInRole("Writer"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2259e807a0826baa994ff055716f2b1b23e4be4010256", async() => {
                WriteLiteral(" <span class=\"glyphicon glyphicon-plus\" aria-hidden=\"true\"></span> Add Post");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 51 "C:\Users\Team\Downloads\Assesments\Zemoga\Zemoga.Blog.Engine\Zemoga.Blog.Engine.Web\Areas\PublishFlow\Views\Publish\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Zemoga.Blog.Engine.Web.Areas.PublishFlow.Models.Publish.PostsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591