#pragma checksum "C:\Users\seaoi\OneDrive\Desktop\DKIT3\program2022\CA2ArtGallery1\Views\Galleries\Greeting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4fb67dd1f0963132fef25599e302e5a10781164"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Galleries_Greeting), @"mvc.1.0.view", @"/Views/Galleries/Greeting.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4fb67dd1f0963132fef25599e302e5a10781164", @"/Views/Galleries/Greeting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bb3b1324da55f606332454f752792d1e5dbaa70", @"/Views/_ViewImports.cshtml")]
    public class Views_Galleries_Greeting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CA2ArtGallery1.ViewModels.PaintingArtistViewModel>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\seaoi\OneDrive\Desktop\DKIT3\program2022\CA2ArtGallery1\Views\Galleries\Greeting.cshtml"
  ViewData["Title"] = "Gallery";


#line default
#line hidden
#nullable disable
            WriteLiteral("<!Doctype html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4fb67dd1f0963132fef25599e302e5a107811643792", async() => {
                WriteLiteral("\r\n\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 154, "\"", 194, 1);
#nullable restore
#line 9 "C:\Users\seaoi\OneDrive\Desktop\DKIT3\program2022\CA2ArtGallery1\Views\Galleries\Greeting.cshtml"
WriteAttributeValue("", 161, Url.Content("~/css/Gallery.css"), 161, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4fb67dd1f0963132fef25599e302e5a107811645227", async() => {
                WriteLiteral("\r\n    <h1> Welcome to our gallery</h1><br><br>\r\n\r\n\r\n    <div>\r\n        ");
#nullable restore
#line 17 "C:\Users\seaoi\OneDrive\Desktop\DKIT3\program2022\CA2ArtGallery1\Views\Galleries\Greeting.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("  enjoy your Tour.<br><br>\r\n    </div>\r\n    <table>\r\n");
#nullable restore
#line 20 "C:\Users\seaoi\OneDrive\Desktop\DKIT3\program2022\CA2ArtGallery1\Views\Galleries\Greeting.cshtml"
         foreach (CA2ArtGallery1.ViewModels.PaintingArtistViewModel item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("         <tr>\r\n\r\n             <td>src=\"");
#nullable restore
#line 24 "C:\Users\seaoi\OneDrive\Desktop\DKIT3\program2022\CA2ArtGallery1\Views\Galleries\Greeting.cshtml"
                 Write(Url.Content(item.thisPainting.Image));

#line default
#line hidden
#nullable disable
                WriteLiteral("\" alt=\"");
#nullable restore
#line 24 "C:\Users\seaoi\OneDrive\Desktop\DKIT3\program2022\CA2ArtGallery1\Views\Galleries\Greeting.cshtml"
                                                             Write(item.thisPainting.AlternateText);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" /></td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\seaoi\OneDrive\Desktop\DKIT3\program2022\CA2ArtGallery1\Views\Galleries\Greeting.cshtml"
           Write(item.thisPainting.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\seaoi\OneDrive\Desktop\DKIT3\program2022\CA2ArtGallery1\Views\Galleries\Greeting.cshtml"
           Write(item.thisArtist.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 26 "C:\Users\seaoi\OneDrive\Desktop\DKIT3\program2022\CA2ArtGallery1\Views\Galleries\Greeting.cshtml"
                                      Write(item.thisArtist.SurName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\seaoi\OneDrive\Desktop\DKIT3\program2022\CA2ArtGallery1\Views\Galleries\Greeting.cshtml"
           Write(item.thisPainting.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n           </tr>\r\n");
#nullable restore
#line 29 "C:\Users\seaoi\OneDrive\Desktop\DKIT3\program2022\CA2ArtGallery1\Views\Galleries\Greeting.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n    </table>\r\n");
                WriteLiteral("    \r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CA2ArtGallery1.ViewModels.PaintingArtistViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591