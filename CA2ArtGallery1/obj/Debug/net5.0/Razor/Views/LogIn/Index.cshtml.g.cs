#pragma checksum "C:\Users\seaoi\OneDrive\Desktop\DKIT3\program2022\CA2ArtGallery1\Views\LogIn\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c88d7cc38b25ce7da49c9cef25bb8f6fecaf21bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LogIn_Index), @"mvc.1.0.view", @"/Views/LogIn/Index.cshtml")]
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
#line 1 "C:\Users\seaoi\OneDrive\Desktop\DKIT3\program2022\CA2ArtGallery1\Views\_ViewImports.cshtml"
using CA2ArtGallery1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\seaoi\OneDrive\Desktop\DKIT3\program2022\CA2ArtGallery1\Views\_ViewImports.cshtml"
using CA2ArtGallery1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\seaoi\OneDrive\Desktop\DKIT3\program2022\CA2ArtGallery1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c88d7cc38b25ce7da49c9cef25bb8f6fecaf21bc", @"/Views/LogIn/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bb3b1324da55f606332454f752792d1e5dbaa70", @"/Views/_ViewImports.cshtml")]
    public class Views_LogIn_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CA2ArtGallery1.Models.Painting>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Abstract.JPG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Comtemporary.JPG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Impressionism.JPG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Drawings.JPG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/IrishScenary.JPG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\seaoi\OneDrive\Desktop\DKIT3\program2022\CA2ArtGallery1\Views\LogIn\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!Doctype html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c88d7cc38b25ce7da49c9cef25bb8f6fecaf21bc5733", async() => {
                WriteLiteral("\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 136, "\"", 174, 1);
#nullable restore
#line 9 "C:\Users\seaoi\OneDrive\Desktop\DKIT3\program2022\CA2ArtGallery1\Views\LogIn\Index.cshtml"
WriteAttributeValue("", 143, Url.Content("~/css/Index.css"), 143, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" rel=""stylesheet"" type=""text/css"" />
    <style>
        .navbar-brand {
            color: white !important;
        }

        .navbar {
            background-color: #7437d3 !important;
        }

        .nav-link {
            color: #fff !important;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c88d7cc38b25ce7da49c9cef25bb8f6fecaf21bc7405", async() => {
                WriteLiteral(@"
    <div class=""text-center"">

        <div class=""text-left"">
            <h1 class=""text-primary"">Login</h1>
            <div class=""card bg-primary text-white"">
                <div class=""card-header"">
                    Young Artists showcase their productions and you have the ability to purchase your favouate works!!
                </div>
                <div class=""card-body"">
                    Buy artwork & support
                    Our community of artists!
                    Established in 2006 Gallery of Ireland IRL online art gallery has grown from one artist with a vision into a community of artists all striving
                    for the same goal-to offer unique original artwork and paintings for sale at affordable prices. When you buy through our gallery you are supporting
                    individual professional artists to fulfil a career in their creative industry and you are buying directly from the artist.

                    Gallery Of Ireland is a marketplace");
                WriteLiteral(@" where people who appreciate fine art can explore and discover art that tells a story.
                    At Gallery of Ireland we make it our business to work with novice and experienced art investors and collectors.

                    The purchase of artwork should be a marriage of an enriching and sophisticated appreciation of contemporary art and the financial
                    satisfaction of investment performance.


                </div>


                <h1>Brouse Your Favourite Style of Art</h1>


                <div class=""grid-container"">
                    <div class=""grid-item"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c88d7cc38b25ce7da49c9cef25bb8f6fecaf21bc9357", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("<figcaption>Abstract</figcaption></div>\r\n                    <div class=\"grid-item\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c88d7cc38b25ce7da49c9cef25bb8f6fecaf21bc10528", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("<figcaption>Comtempory</figcaption></div>\r\n                    <div class=\"grid-item\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c88d7cc38b25ce7da49c9cef25bb8f6fecaf21bc11702", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("<figcaption>Impressionism</figcaption></div>\r\n                    <div class=\"grid-item\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c88d7cc38b25ce7da49c9cef25bb8f6fecaf21bc12878", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("<figcaption>Drawings</figcaption></div>\r\n                    <div class=\"grid-item\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c88d7cc38b25ce7da49c9cef25bb8f6fecaf21bc14050", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"<figcaption>IrishScenary</figcaption></div>
                </div>



            </div>


            <div class=""card bg-warning text-white"">
                <div class=""card-header"">Only Original Art</div>
                <div class=""card-body"">
                    You will find only original art on our site - that???s a promise.

                    From paintings for sale, drawings of pets or breathtaking photography, we have something for everyone.

                    You can search our gallery using our search facility which allows you to narrow down your search by style, medium used, price or just select your favorite artist.
                    It's never been easier to own affordable artwork.
                    At Yield Gallery we make it our business to work with novice and experienced art investors and collectors.

                    The purchase of artwork should be a marriage of an enriching and sophisticated appreciation of contemporary art and the financial satisfaction of ");
                WriteLiteral(@"investment performance.



                </div>

            </div>
            <p></p>
            <div class=""card bg-success text-white"">
                <div class=""card-header"">Buy With Finance</div>
                <div class=""card-body"">
                    Buy with 0% Finance
                    Found a beautiful piece of original artwork in our gallery, but would prefer to spread the cost?. Own Art has made it easy and affordable to
                    buy original artwork. Simply choose our 'own art scheme' at the checkout.
                </div>
            </div>

            <p> Choose your Favourite STYLE of Art</p>






            <div class=""card bg-success text-white"">
                <div class=""card-header"">ArtWork Terminology</div>
                <div class=""card-body"">
                    We know the art market can sometimes be dizzying to navigate through the landscape so we have broken down the terminology in simple terms so you can always
              ");
                WriteLiteral(@"      make an educated purchase.
                    Acrylic ??? A rival to oil paint, coloured pigment is held in a clear plastic solution. It provides bright, long-lasting colour.

                    Canvas ??? The classic substrate for painting, canvas is a heavy fabric stretched over a wooden frame.

                    Condition ??? You would expect a primary market piece to be in perfect condition. Artwork that hasn???t been stored correctly or travelled in bad conditions may be ???poor??? ???damaged??? ???crazed??? ???deteriorated???

                    Conservation ??? A very skilled technique to repair damage and deterioration.

                    What is a print ??? A print is an impression created by any method involving a transfer from one surface to another.

                    What is a screen-print ??? A screen-print is a printmaking technique in which a piece of woven fabric is stretched over a wooden frame in order to create a screen. There is no difference between a silkscreen or screen-print.

         ");
                WriteLiteral(@"           What is a limited edition - A print made in limited quantity, each piece will have an edition number so that, say, 5/100 would be the 5th print of an edition of 100.

                    Originals vs Editions vs Multiples

                    Original prints are produced in a limited number of impressions. These impressions are called editions, say, 26/50, where 50 is the edition amount and 26 is the individual print number.

                    Multiples are still produced in a limited number of editions and can vary in materials. Some prints may be marked or signed with ???AP??? meaning ???artists proof???. Many other proofs may be produced before the ???AP??? such a tester proofs, colour proofs or state proofs.



                </div>

            </div>
        </div>


    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CA2ArtGallery1.Models.Painting>> Html { get; private set; }
    }
}
#pragma warning restore 1591
