#pragma checksum "D:\Tikhon\Github\ApplicantsHelper\ApplicantsHelper\Views\Home\Universities.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0cf2890a516bfc6f22d732b9062f3e7d106384d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Universities), @"mvc.1.0.view", @"/Views/Home/Universities.cshtml")]
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
#line 1 "D:\Tikhon\Github\ApplicantsHelper\ApplicantsHelper\Views\_ViewImports.cshtml"
using ApplicantsHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tikhon\Github\ApplicantsHelper\ApplicantsHelper\Views\_ViewImports.cshtml"
using ApplicantsHelper.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tikhon\Github\ApplicantsHelper\ApplicantsHelper\Views\Home\Universities.cshtml"
using ApplicantsHelper.BLL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Tikhon\Github\ApplicantsHelper\ApplicantsHelper\Views\Home\Universities.cshtml"
using System.Reflection;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0cf2890a516bfc6f22d732b9062f3e7d106384d", @"/Views/Home/Universities.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"202b2f56f48586e2d544c77f73961c08e79c8eff", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Universities : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicantsHelper.BLL.Models.UniversityDTO>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowUniversityInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:100%;display:block;color:black;text-decoration:none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:100%;width:100%;display:block;color:black;text-decoration:none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div>\r\n    <table class=\"col-md-12 table\" style=\"text-align:center\">\r\n        <thead class=\"thead-dark\">\r\n            <tr style=\"font-size:20px;\">\r\n");
#nullable restore
#line 9 "D:\Tikhon\Github\ApplicantsHelper\ApplicantsHelper\Views\Home\Universities.cshtml"
                  
                    Type type = typeof(UniversityDTO);
                    List<PropertyInfo> infos = type.GetProperties().ToList();
                    infos.Remove(infos.FirstOrDefault(p=>p.Name == "Id"));
                    UniversityDTO university = Model.First();
                    foreach (PropertyInfo item in infos)
                    {
                        var value = item.GetValue(university);
                        if (value != null)
                        {
                            if (item.PropertyType == typeof(string))
                            {
                                if (value.ToString() != "")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <th style=\"padding:1vw\">\r\n                                        ");
#nullable restore
#line 24 "D:\Tikhon\Github\ApplicantsHelper\ApplicantsHelper\Views\Home\Universities.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n");
#nullable restore
#line 26 "D:\Tikhon\Github\ApplicantsHelper\ApplicantsHelper\Views\Home\Universities.cshtml"
                                }
                            }
                            else
                            {
                                if (item.PropertyType == typeof(int) || item.PropertyType == typeof(double))
                                {
                                    if (Convert.ToDouble(value) != 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <th style=\"padding:1vw\">\r\n                                            ");
#nullable restore
#line 35 "D:\Tikhon\Github\ApplicantsHelper\ApplicantsHelper\Views\Home\Universities.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n");
#nullable restore
#line 37 "D:\Tikhon\Github\ApplicantsHelper\ApplicantsHelper\Views\Home\Universities.cshtml"
                                    }
                                }
                            }
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 46 "D:\Tikhon\Github\ApplicantsHelper\ApplicantsHelper\Views\Home\Universities.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr style=\"font-size:20px;\">\r\n");
#nullable restore
#line 50 "D:\Tikhon\Github\ApplicantsHelper\ApplicantsHelper\Views\Home\Universities.cshtml"
                     foreach (PropertyInfo prop in infos)
                    {
                        var value = prop.GetValue(item);
                        if (value != null)
                        {
                            if (prop.PropertyType == typeof(string))
                            {
                                if (value.ToString() != "")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td style=\"padding:1vw\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0cf2890a516bfc6f22d732b9062f3e7d106384d9248", async() => {
                WriteLiteral("\r\n                                            ");
#nullable restore
#line 61 "D:\Tikhon\Github\ApplicantsHelper\ApplicantsHelper\Views\Home\Universities.cshtml"
                                       Write(value.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
#line 60 "D:\Tikhon\Github\ApplicantsHelper\ApplicantsHelper\Views\Home\Universities.cshtml"
                                                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n");
#nullable restore
#line 64 "D:\Tikhon\Github\ApplicantsHelper\ApplicantsHelper\Views\Home\Universities.cshtml"
                                }
                            }
                            else
                            {
                                if (prop.PropertyType == typeof(int) || prop.PropertyType == typeof(double))
                                {
                                    if (Convert.ToDouble(value) != 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td style=\"padding:1vw\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0cf2890a516bfc6f22d732b9062f3e7d106384d12931", async() => {
                WriteLiteral("\r\n                                                ");
#nullable restore
#line 74 "D:\Tikhon\Github\ApplicantsHelper\ApplicantsHelper\Views\Home\Universities.cshtml"
                                           Write(value.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
#line 73 "D:\Tikhon\Github\ApplicantsHelper\ApplicantsHelper\Views\Home\Universities.cshtml"
                                                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n");
#nullable restore
#line 77 "D:\Tikhon\Github\ApplicantsHelper\ApplicantsHelper\Views\Home\Universities.cshtml"
                                    }
                                }
                            }
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 83 "D:\Tikhon\Github\ApplicantsHelper\ApplicantsHelper\Views\Home\Universities.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n       \r\n    </table>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicantsHelper.BLL.Models.UniversityDTO>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591