#pragma checksum "C:\Users\isip_\Desktop\Web_Shop_Core\WEB_Shop_core\Views\Home\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "102c1d4cbe3f8ba5522d2349b8ddbe2ce7136fb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cart), @"mvc.1.0.view", @"/Views/Home/Cart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"102c1d4cbe3f8ba5522d2349b8ddbe2ce7136fb2", @"/Views/Home/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7216a8b97223b255dd639e983ed40e9b8abc87a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WEB_Shop_core.Data.Models.Mebel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/Аннотация 2020-09-14 095617.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin:auto; display:block; margin:0 auto; padding-top:20px; margin-bottom:20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\isip_\Desktop\Web_Shop_Core\WEB_Shop_core\Views\Home\Cart.cshtml"
  
    ViewBag.Title = "Корзина";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h1 style=\"text-align: center; color: white; padding: 10px 0px 0px 0px\">Корзина</h1><hr />\r\n    <div>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "102c1d4cbe3f8ba5522d2349b8ddbe2ce7136fb23868", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <h2 style=""text-align:center; color:#bababa; border-bottom:none; font-size:25px;"">
            В корзине нет ни одного товара
        </h2>

        <h3 style=""text-align:center; color:white; padding: 15px 0px 30px 0px; font-size:15px;"">
            <a");
            BeginWriteAttribute("href", " href=\"", 572, "\"", 599, 1);
#nullable restore
#line 14 "C:\Users\isip_\Desktop\Web_Shop_Core\WEB_Shop_core\Views\Home\Cart.cshtml"
WriteAttributeValue("", 579, Url.Action("Index"), 579, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""color:white;text-decoration: none; "">Нажмите здесь,</a>чтобы продолжить покупки
        </h3>
        <h3 style=""border-bottom: none; padding:10px; text-align:center "">Оформление заказа</h3>
        <div style=""padding:10px;color:white;"">
            <div>
                <span class=""redstar"">*</span> Имя:<br><input id=""order_name"" name=""order_name"" type=""text"" style=""width: 50%;"">
            </div>
            <div class=""field adap_ord2"">
                <table border=""0"" cellspacing=""0"" cellpadding=""0"" width=""50%"" style=""color: #fff;"">
                    <tbody>

                        <tr>
                            <td><div class=""adap""><span class=""redstar"">*</span> Электронная почта</div><input id=""order_email"" name=""order_email"" type=""text"" style=""width: 94%;""></td>
                            <td><div class=""adap""><span class=""redstar"">*</span> Телефон:</div><input id=""order_phone"" name=""order_phone"" type=""text"" style=""width: 100%;""></td>
                        </tr>
    ");
            WriteLiteral(@"                </tbody>
                </table>
            </div>
            <div> Адрес доставки:<br><input id=""order_address"" name=""order_address"" type=""text"" style=""width: 50%;""> </div>
            <div style=""padding-bottom: 4px;"">
                Вид доставки:<br>
                <div style=""line-height: 40px;"" class=""adap_ord3"">
                    <label><input type=""radio"" name=""delivery"" value=""самовывоз""");
            BeginWriteAttribute("checked", " checked=\"", 2052, "\"", 2062, 0);
            EndWriteAttribute();
            WriteLiteral(@"> самовывоз</label>
                    <label><input type=""radio"" name=""delivery"" value=""доставка по Подмосковью""> доставка по Подмосковью</label>
                    <label><input type=""radio"" name=""delivery"" value=""доставка по Москве""> доставка по Москве</label>
                    <br>
                    <label><input type=""radio"" name=""delivery"" value=""доставка до тр.компании""> доставка до транспортной компании</label>
                </div>
            </div>
            <div><ul><li>Срок доставки – 3 рабочих дня (при условии наличия нужного товара на складе)</li><li>Стоимость ДОСТАВКИ по Москве в пределах МКАД  – 3000р.</li><li>от МКАД – 45 руб./км.</li><li>Мы можем осуществить доставку в выбранную Вами транспортную компанию. Стоимость доставки в транспортную компанию – 5000р.</li></ul><hr/></div>
            <div>
                ВНИМАНИЕ! Для ускорения выставления счета при безналичной оплате сразу указывайте реквизиты/ФИО получателя и адрес доставки товара.
                <br>
         ");
            WriteLiteral(@"       Комментарий к заказу: <br>
                <textarea id=""order_comment"" name=""order_comment"" rows=""6"" style=""width: 50%;""></textarea>
            </div>
            <div><span class=""redstar"">*</span> — обязательны к заполнению</div>
            <button onclick=""OrderSend()"" type=""button"">Отправить заказ</button>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WEB_Shop_core.Data.Models.Mebel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
