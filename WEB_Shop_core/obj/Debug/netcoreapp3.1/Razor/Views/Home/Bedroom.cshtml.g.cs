#pragma checksum "C:\Users\isip_\Source\Repos\PDA2304\Web_Shop_Core\WEB_Shop_core\Views\Home\Bedroom.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55818ff9c2868b4675f0caf2f2254a4a8ef2b289"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Bedroom), @"mvc.1.0.view", @"/Views/Home/Bedroom.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55818ff9c2868b4675f0caf2f2254a4a8ef2b289", @"/Views/Home/Bedroom.cshtml")]
    public class Views_Home_Bedroom : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:300px; padding:10px; margin: 0; "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\isip_\Source\Repos\PDA2304\Web_Shop_Core\WEB_Shop_core\Views\Home\Bedroom.cshtml"
  
    ViewBag.Title = "Спальни";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\isip_\Source\Repos\PDA2304\Web_Shop_Core\WEB_Shop_core\Views\Home\Bedroom.cshtml"
   string[] name_bedroom = { "Спальня ROUND янтарная береза", "Спальня ROUND серебристая береза", "Спальня MAIA янтарная береза", "Спальня MAIA серебристая береза", "Cпальня TREVISO avorio", "Cпальня TREVISO" };
    string[] path_bedroom = { "camel-round-sabbia-bg.jpg", "camel-round-bg.jpg", "camel-maia-sabbia-bg.jpg", "sp-maia2.jpg", "trevi1.gif", "treviso_night10b.jpg" };

    int count = 0;
    //    style = "padding-left:4%; "



#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"text-align:center\">\r\n");
#nullable restore
#line 14 "C:\Users\isip_\Source\Repos\PDA2304\Web_Shop_Core\WEB_Shop_core\Views\Home\Bedroom.cshtml"
           for (int i = 0; i < path_bedroom.Length; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <article style=\"text-align:center; display:inline-flex; justify-content:space-around; margin:5px; background: #5e5d5b;\">\r\n                    <section>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 792, "\"", 826, 1);
#nullable restore
#line 18 "C:\Users\isip_\Source\Repos\PDA2304\Web_Shop_Core\WEB_Shop_core\Views\Home\Bedroom.cshtml"
WriteAttributeValue("", 799, Url.Action("Product_card"), 799, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "55818ff9c2868b4675f0caf2f2254a4a8ef2b2894776", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 915, "~/Assets/", 915, 9, true);
#nullable restore
#line 19 "C:\Users\isip_\Source\Repos\PDA2304\Web_Shop_Core\WEB_Shop_core\Views\Home\Bedroom.cshtml"
AddHtmlAttributeValue("", 924, path_bedroom[i], 924, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br />\r\n                            <p style=\"color:white\">\r\n                                ");
#nullable restore
#line 21 "C:\Users\isip_\Source\Repos\PDA2304\Web_Shop_Core\WEB_Shop_core\Views\Home\Bedroom.cshtml"
                           Write(name_bedroom[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </a>\r\n                    </section>\r\n                </article>\r\n");
#nullable restore
#line 26 "C:\Users\isip_\Source\Repos\PDA2304\Web_Shop_Core\WEB_Shop_core\Views\Home\Bedroom.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
