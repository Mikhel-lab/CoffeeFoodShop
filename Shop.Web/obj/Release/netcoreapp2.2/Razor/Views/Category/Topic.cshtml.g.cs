#pragma checksum "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e87941cd9edcd0062e2b2bc0eb01b687914a23ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Topic), @"mvc.1.0.view", @"/Views/Category/Topic.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/Topic.cshtml", typeof(AspNetCore.Views_Category_Topic))]
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
#line 1 "C:\CoffeeFoodStore\Shop.Web\Views\_ViewImports.cshtml"
using Shop.Web;

#line default
#line hidden
#line 2 "C:\CoffeeFoodStore\Shop.Web\Views\_ViewImports.cshtml"
using Shop.Web.Models;

#line default
#line hidden
#line 3 "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml"
using Shop.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e87941cd9edcd0062e2b2bc0eb01b687914a23ac", @"/Views/Category/Topic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"305828443d1bbb5288a5e50c77b527fb67997e89", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Topic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shop.Web.Models.Category.CategoryTopicModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("searchBar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onfocus", new global::Microsoft.AspNetCore.Html.HtmlString("clearThis(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Food", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "New", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(215, 142, true);
            WriteLiteral("\n<div class=\"container body-content\">\n    <div class=\"sectionHeader\">\n        <div class=\"sectionHeading\">\n            <h3><span id=\"results\">");
            EndContext();
            BeginContext(358, 19, false);
#line 11 "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml"
                              Write(Model.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(377, 149, true);
            WriteLiteral("</span><h3/>\n        </div>\n        <div class=\"row\">\n            <div class=\"col-md-8 sectionDescription\">\n                <div class=\"categoryLogo\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 526, "\"", 603, 5);
            WriteAttributeValue("", 534, "background-image:", 534, 17, true);
            WriteAttributeValue(" ", 551, "url(", 552, 5, true);
#line 15 "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml"
WriteAttributeValue("", 556, Model.Category.ImageUrl, 556, 24, false);

#line default
#line hidden
            WriteAttributeValue("", 580, ");", 580, 2, true);
            WriteAttributeValue(" ", 582, "background-size:100%", 583, 21, true);
            EndWriteAttribute();
            BeginContext(604, 50, true);
            WriteLiteral("></div>\n                <p>Welcome to the <strong>");
            EndContext();
            BeginContext(655, 19, false);
#line 16 "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml"
                                     Write(Model.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(674, 216, true);
            WriteLiteral("</strong> section</p>\n                <p>\n                    Please read the Category Guidelines before ordering a product.\n                </p>\n            </div>\n            <div class=\"col-md-4\">\n                ");
            EndContext();
            BeginContext(890, 549, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87941cd9edcd0062e2b2bc0eb01b687914a23ac10311", async() => {
                BeginContext(956, 70, true);
                WriteLiteral("\n                    <div class=\"searchForm\">\n                        ");
                EndContext();
                BeginContext(1026, 109, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e87941cd9edcd0062e2b2bc0eb01b687914a23ac10766", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 24 "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchQuery);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1135, 225, true);
                WriteLiteral("\n                        <button type=\"submit\" class=\"btn btn-categorySearch\">\n                            <i class=\"material-icons\">search</i>\n                        </button>\n                    </div>\n                    ");
                EndContext();
                BeginContext(1360, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e87941cd9edcd0062e2b2bc0eb01b687914a23ac13063", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 29 "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Category.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1415, 17, true);
                WriteLiteral("\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1439, 35, true);
            WriteLiteral("\n            </div>\n        </div>\n");
            EndContext();
#line 33 "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml"
         if(User.IsInRole("Admin"))
        {

#line default
#line hidden
            BeginContext(1520, 205, true);
            WriteLiteral("            <div class=\"row\">\n                <div class=\"col-md-11\"></div>\n                <div class=\"col-md-1\">\n                    <div class=\"row\" style=\"margin-bottom:16px;\">\n                        ");
            EndContext();
            BeginContext(1725, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87941cd9edcd0062e2b2bc0eb01b687914a23ac17257", async() => {
                BeginContext(1830, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml"
                                                                                                 WriteLiteral(Model.Category.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1838, 90, true);
            WriteLiteral("\n                    </div>\n                    <div class=\"row\">\n                        ");
            EndContext();
            BeginContext(1929, 187, false);
#line 42 "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = @Model.Category.Id },
                new { onclick = "return confirm('Are sure you want to delete category?');", @class="btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2116, 70, true);
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n");
            EndContext();
#line 47 "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml"
        }

#line default
#line hidden
            BeginContext(2196, 11, true);
            WriteLiteral("    </div>\n");
            EndContext();
#line 49 "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml"
     if(User.IsInRole("Admin"))
    {

#line default
#line hidden
            BeginContext(2245, 42, true);
            WriteLiteral("        <div class=\"newFood\">\n            ");
            EndContext();
            BeginContext(2287, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87941cd9edcd0062e2b2bc0eb01b687914a23ac21079", async() => {
                BeginContext(2405, 8, true);
                WriteLiteral("New food");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml"
                                                                                                  WriteLiteral(Model.Category.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2417, 16, true);
            WriteLiteral("\n        </div>\n");
            EndContext();
#line 54 "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml"
    }

#line default
#line hidden
            BeginContext(2439, 48, true);
            WriteLiteral("    <div class=\"row\" id=\"categoryIndexContent\">\n");
            EndContext();
#line 56 "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml"
         if (Model.Foods.Any())
        {

#line default
#line hidden
            BeginContext(2529, 109, true);
            WriteLiteral("            <table class=\"table table-hover table-bordered\" id=\"categoryIndexTable\">\n                <tbody>\n");
            EndContext();
#line 60 "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml"
                     foreach (var food in Model.Foods)
                    {

#line default
#line hidden
            BeginContext(2715, 93, true);
            WriteLiteral("                        <tr>\n                            <td>\n                               ");
            EndContext();
            BeginContext(2809, 32, false);
#line 64 "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml"
                          Write(Html.Partial("FoodSummary",food));

#line default
#line hidden
            EndContext();
            BeginContext(2841, 66, true);
            WriteLiteral(" \n                            </td>\n                        </tr>\n");
            EndContext();
#line 67 "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml"
                    }

#line default
#line hidden
            BeginContext(2929, 46, true);
            WriteLiteral("                </tbody>\n            </table>\n");
            EndContext();
#line 70 "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml"
        }
        else if (string.IsNullOrEmpty(@Model.SearchQuery) || string.IsNullOrWhiteSpace(Model.SearchQuery))
        {

#line default
#line hidden
            BeginContext(3102, 171, true);
            WriteLiteral("            <div class=\"noFoods\">\n                <i class=\"material-icons md-72\">question_answer</i>\n                <h3>\n                    No search results found for ");
            EndContext();
            BeginContext(3274, 17, false);
#line 76 "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml"
                                           Write(Model.SearchQuery);

#line default
#line hidden
            EndContext();
            BeginContext(3291, 50, true);
            WriteLiteral("! <br />\n                </h3>\n            </div>\n");
            EndContext();
#line 79 "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml"

        }

        else if (!@Model.Foods.Any())
        {

#line default
#line hidden
            BeginContext(3401, 170, true);
            WriteLiteral("            <div class=\"noFoods\">\n                <i class=\"material-icons md-72\">question_answer</i>\n                <h3>\n                    It looks like there are no ");
            EndContext();
            BeginContext(3572, 19, false);
#line 87 "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml"
                                          Write(Model.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3591, 63, true);
            WriteLiteral(" products yet. <br />\n                </h3>\n            </div>\n");
            EndContext();
#line 90 "C:\CoffeeFoodStore\Shop.Web\Views\Category\Topic.cshtml"
        }

#line default
#line hidden
            BeginContext(3664, 19, true);
            WriteLiteral("    </div>\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3701, 106, true);
                WriteLiteral("\n    <script>\n        function clearThis(target) {\n            target.value = \"\";\n        }\n    </script>\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.Web.Models.Category.CategoryTopicModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
