#pragma checksum "D:\reps\site\VCardSite\VCardSite\Views\Shared\MetaTagPartical.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "919f3c5169385c67f17b4c0bacd933e50bdcb3bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MetaTagPartical), @"mvc.1.0.view", @"/Views/Shared/MetaTagPartical.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"919f3c5169385c67f17b4c0bacd933e50bdcb3bb", @"/Views/Shared/MetaTagPartical.cshtml")]
    public class Views_Shared_MetaTagPartical : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<meta charset=\"utf-8\" />\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1, user-scalable=no\" />\r\n");
#nullable restore
#line 4 "D:\reps\site\VCardSite\VCardSite\Views\Shared\MetaTagPartical.cshtml"
 if (ViewBag.Title != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 6 "D:\reps\site\VCardSite\VCardSite\Views\Shared\MetaTagPartical.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 7 "D:\reps\site\VCardSite\VCardSite\Views\Shared\MetaTagPartical.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>Wood Logo</title>\r\n");
#nullable restore
#line 11 "D:\reps\site\VCardSite\VCardSite\Views\Shared\MetaTagPartical.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\reps\site\VCardSite\VCardSite\Views\Shared\MetaTagPartical.cshtml"
 if (ViewBag.Description != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"description\"");
            BeginWriteAttribute("content", " content=\"", 296, "\"", 326, 1);
#nullable restore
#line 14 "D:\reps\site\VCardSite\VCardSite\Views\Shared\MetaTagPartical.cshtml"
WriteAttributeValue("", 306, ViewBag.Description, 306, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 15 "D:\reps\site\VCardSite\VCardSite\Views\Shared\MetaTagPartical.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\reps\site\VCardSite\VCardSite\Views\Shared\MetaTagPartical.cshtml"
 if (ViewBag.Keywords != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"keywords\"");
            BeginWriteAttribute("content", " content=\"", 395, "\"", 422, 1);
#nullable restore
#line 18 "D:\reps\site\VCardSite\VCardSite\Views\Shared\MetaTagPartical.cshtml"
WriteAttributeValue("", 405, ViewBag.Keywords, 405, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 19 "D:\reps\site\VCardSite\VCardSite\Views\Shared\MetaTagPartical.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
