#pragma checksum "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHome-BackEndProject\EduHomeProject\EduHomeProject\Areas\AdminPanel\Views\Teacher\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f3e0c22908f8bc608b58947f07f6d017a143464"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Teacher_Detail), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Teacher/Detail.cshtml")]
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
#line 1 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHome-BackEndProject\EduHomeProject\EduHomeProject\Areas\AdminPanel\Views\_ViewImports.cshtml"
using EduHomeProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f3e0c22908f8bc608b58947f07f6d017a143464", @"/Areas/AdminPanel/Views/Teacher/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5a557f8e033e70181e40bb6073bb258dae8d954", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Teacher_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px;height:150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHome-BackEndProject\EduHomeProject\EduHomeProject\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">");
#nullable restore
#line 10 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHome-BackEndProject\EduHomeProject\EduHomeProject\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
                                  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1f3e0c22908f8bc608b58947f07f6d017a1434645112", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 306, "~/img/", 306, 6, true);
#nullable restore
#line 12 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHome-BackEndProject\EduHomeProject\EduHomeProject\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
AddHtmlAttributeValue("", 312, Model.TeacherImageName, 312, 23, false);

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
            WriteLiteral("\r\n                </p>\n                <span>About Me</span>\r\n                <p>");
#nullable restore
#line 15 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHome-BackEndProject\EduHomeProject\EduHomeProject\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
              Write(Model.TeacherDetail.AboutMeDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <span>Teacher Degree</span>\r\n                <p>");
#nullable restore
#line 17 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHome-BackEndProject\EduHomeProject\EduHomeProject\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
              Write(Model.TeacherDetail.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <span>Teacher hobbies</span>\r\n                <p>");
#nullable restore
#line 19 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHome-BackEndProject\EduHomeProject\EduHomeProject\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
              Write(Model.TeacherDetail.Hobbies);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <span>Teacher Experience</span>\r\n                <p>");
#nullable restore
#line 21 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHome-BackEndProject\EduHomeProject\EduHomeProject\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
              Write(Model.TeacherDetail.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <span>Teacher Faculty</span>\r\n                <p>");
#nullable restore
#line 23 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHome-BackEndProject\EduHomeProject\EduHomeProject\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
              Write(Model.TeacherDetail.Faculty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <span> Teacher Professions</span>\n");
#nullable restore
#line 25 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHome-BackEndProject\EduHomeProject\EduHomeProject\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
                 foreach(var item in Model.TeacherProfessions)
                   {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>");
#nullable restore
#line 28 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHome-BackEndProject\EduHomeProject\EduHomeProject\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
                      Write(item.Profession.ProfessionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 29 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHome-BackEndProject\EduHomeProject\EduHomeProject\Areas\AdminPanel\Views\Teacher\Detail.cshtml"

                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>Innovation Degree</span>\r\n                <p> ");
#nullable restore
#line 32 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHome-BackEndProject\EduHomeProject\EduHomeProject\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
               Write(Model.TeacherDetail.Skill.InnovationDegree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <span>Language Degree</span>\r\n                <p> ");
#nullable restore
#line 34 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHome-BackEndProject\EduHomeProject\EduHomeProject\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
               Write(Model.TeacherDetail.Skill.LanguageDegree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <span>Innovation Degree</span>\r\n                <p> ");
#nullable restore
#line 36 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHome-BackEndProject\EduHomeProject\EduHomeProject\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
               Write(Model.TeacherDetail.Skill.InnovationDegree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <span> Communication Degree</span>\r\n                <p> ");
#nullable restore
#line 38 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHome-BackEndProject\EduHomeProject\EduHomeProject\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
               Write(Model.TeacherDetail.Skill.CommunicationDegree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <span> Development Degree</span>\r\n                <p> ");
#nullable restore
#line 40 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHome-BackEndProject\EduHomeProject\EduHomeProject\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
               Write(Model.TeacherDetail.Skill.DevelopmentDegree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <span>Design Degree</span>\r\n                <p> ");
#nullable restore
#line 42 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHome-BackEndProject\EduHomeProject\EduHomeProject\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
               Write(Model.TeacherDetail.Skill.DesignDegree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f3e0c22908f8bc608b58947f07f6d017a14346412146", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
