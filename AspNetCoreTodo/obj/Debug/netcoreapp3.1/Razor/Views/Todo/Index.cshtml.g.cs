#pragma checksum "C:\Users\Marvin\desktop\Lets-Learn-DOTNC\AspNetCoreTodo\Views\Todo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6c30049cfa96710e8b1103adc563c8fc0318efa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_Index), @"mvc.1.0.view", @"/Views/Todo/Index.cshtml")]
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
#line 1 "C:\Users\Marvin\desktop\Lets-Learn-DOTNC\AspNetCoreTodo\Views\_ViewImports.cshtml"
using AspNetCoreTodo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marvin\desktop\Lets-Learn-DOTNC\AspNetCoreTodo\Views\_ViewImports.cshtml"
using AspNetCoreTodo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6c30049cfa96710e8b1103adc563c8fc0318efa", @"/Views/Todo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63823eaa5b73e495aebe7447edc96790f50c299d", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TodoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Marvin\desktop\Lets-Learn-DOTNC\AspNetCoreTodo\Views\Todo\Index.cshtml"
  
ViewData["Title"] = "Manage your todo list";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"panel panel-default todo-panel\">\r\n    <div class=\"panel-heading\">");
#nullable restore
#line 7 "C:\Users\Marvin\desktop\Lets-Learn-DOTNC\AspNetCoreTodo\Views\Todo\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
    <table class=""table table-hover"">
        <thead>
            <tr>
                <td>&#x2714;</td>
                <td>Item</td>
                <td>Due</td>
                Create a view
                28
            </tr>
        </thead>
");
#nullable restore
#line 18 "C:\Users\Marvin\desktop\Lets-Learn-DOTNC\AspNetCoreTodo\Views\Todo\Index.cshtml"
         foreach (var item in Model.Items)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <input type=\"checkbox\" class=\"done-checkbox\">\r\n            </td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Marvin\desktop\Lets-Learn-DOTNC\AspNetCoreTodo\Views\Todo\Index.cshtml"
           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Marvin\desktop\Lets-Learn-DOTNC\AspNetCoreTodo\Views\Todo\Index.cshtml"
           Write(item.DueAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\Users\Marvin\desktop\Lets-Learn-DOTNC\AspNetCoreTodo\Views\Todo\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n    <div class=\"panel-footer add-item-form\">\r\n        <!-- TODO: Add item form -->\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TodoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
