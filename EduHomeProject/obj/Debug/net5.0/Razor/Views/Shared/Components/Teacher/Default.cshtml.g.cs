#pragma checksum "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Teacher\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b35de08ed8ff5ae25a4a9e27d5a6949bec7b55f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Teacher_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Teacher/Default.cshtml")]
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
#line 1 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\_ViewImports.cshtml"
using EduHomeProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\_ViewImports.cshtml"
using EduHomeProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\_ViewImports.cshtml"
using EduHomeProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35de08ed8ff5ae25a4a9e27d5a6949bec7b55f8", @"/Views/Shared/Components/Teacher/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab236ad53306eaa48b7aa63bddc9cfd78ecb0802", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Teacher_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Teacher>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Teacher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TeacherDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Teacher\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-3 col-sm-4 col-xs-12\">\n    <div class=\"single-teacher mb-45\">\n        <div class=\"single-teacher-img\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b35de08ed8ff5ae25a4a9e27d5a6949bec7b55f84920", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b35de08ed8ff5ae25a4a9e27d5a6949bec7b55f85136", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 276, "~/img/", 276, 6, true);
#nullable restore
#line 8 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Teacher\Default.cshtml"
AddHtmlAttributeValue("", 282, item.TeacherImageName, 282, 22, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 8 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Teacher\Default.cshtml"
                                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n        <div class=\"single-teacher-content text-center\">\n            <h2><a href=\"teacher-details.html\">");
#nullable restore
#line 11 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Teacher\Default.cshtml"
                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\n            <h4>");
#nullable restore
#line 12 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Teacher\Default.cshtml"
           Write(item.TeacherProfessions);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n            <ul>\n");
#nullable restore
#line 14 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Teacher\Default.cshtml"
                 foreach (var url in item.SocialAdresses)
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li><a");
            BeginWriteAttribute("href", " href=\"", 630, "\"", 645, 1);
#nullable restore
#line 16 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Teacher\Default.cshtml"
WriteAttributeValue("", 637, url.Url, 637, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i");
            BeginWriteAttribute("class", " class=\"", 650, "\"", 680, 3);
            WriteAttributeValue("", 658, "zmdi", 658, 4, true);
            WriteAttributeValue(" ", 662, "zmdi-", 663, 6, true);
#nullable restore
#line 16 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Teacher\Default.cshtml"
WriteAttributeValue("", 668, url.UrlName, 668, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a></li>\n");
#nullable restore
#line 17 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Teacher\Default.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\n        </div>\n    </div>\n</div>            \n");
#nullable restore
#line 22 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Teacher\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Teacher>> Html { get; private set; }
    }
}
#pragma warning restore 1591
