#pragma checksum "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Notice\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "305518dd0bcf8ee6cdd3a1b549165eaa96c2bc81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Notice_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Notice/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"305518dd0bcf8ee6cdd3a1b549165eaa96c2bc81", @"/Views/Shared/Components/Notice/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab236ad53306eaa48b7aa63bddc9cfd78ecb0802", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Notice_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NoticeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Notice\Default.cshtml"
  
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-right-wrapper mb-25 pb-25"">
                    <h3>TAKE A VIDEO TOUR</h3>
                    <div class=""notice-video""");
            BeginWriteAttribute("style", " style=\"", 310, "\"", 368, 3);
            WriteAttributeValue("", 318, "background:url(../img/", 318, 22, true);
#nullable restore
#line 10 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Notice\Default.cshtml"
WriteAttributeValue("", 340, Model.VIdeoTour.VideoImage, 340, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 367, ")", 367, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n                        <div class=\"video-icon video-hover\">\n                            <a class=\"video-popup\"");
            BeginWriteAttribute("href", " href=\"", 482, "\"", 510, 1);
#nullable restore
#line 12 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Notice\Default.cshtml"
WriteAttributeValue("", 489, Model.VIdeoTour.Link, 489, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                <i class=""zmdi zmdi-play""></i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-left-wrapper"">
                    <h3>notice board</h3>
                    <div class=""notice-left"">
");
#nullable restore
#line 23 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Notice\Default.cshtml"
                         foreach (var item in Model.NoticeArea)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Notice\Default.cshtml"
                             if (count == 0)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Notice\Default.cshtml"
                           Write(Html.Raw("<div class='single-notice-left mb-23 pb-20'>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Notice\Default.cshtml"
                                                                                         
                            }
                            else if (count == 1)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Notice\Default.cshtml"
                           Write(Html.Raw("<div class='single-notice-left hidden-sm mb-23 pb-20'>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Notice\Default.cshtml"
                                                                                                   
                            }
                            else if (count == 2)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Notice\Default.cshtml"
                           Write(Html.Raw("<div class='single-notice-left pb-70'>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Notice\Default.cshtml"
                                                                                   
                                count = 0;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h4>");
#nullable restore
#line 38 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Notice\Default.cshtml"
                           Write(item.StartTime.ToString("dd, MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                            <p>");
#nullable restore
#line 39 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Notice\Default.cshtml"
                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 40 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Notice\Default.cshtml"
                       Write(Html.Raw("</div>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Rail\Desktop\BackEnd-Project-EduHome\EduHomeProject\Views\Shared\Components\Notice\Default.cshtml"
                                               
                            count++;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NoticeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
