#pragma checksum "C:\Projects\Cold\May\05162022\TextAreaMessageToPdf\TextAreaMessageToPdf\Views\Home\MultiTabInSingle2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65ad89febf7c697d5f1a13cf00fc507eb5562a19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MultiTabInSingle2), @"mvc.1.0.view", @"/Views/Home/MultiTabInSingle2.cshtml")]
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
#line 1 "C:\Projects\Cold\May\05162022\TextAreaMessageToPdf\TextAreaMessageToPdf\Views\_ViewImports.cshtml"
using TextAreaMessageToPdf;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Cold\May\05162022\TextAreaMessageToPdf\TextAreaMessageToPdf\Views\_ViewImports.cshtml"
using TextAreaMessageToPdf.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65ad89febf7c697d5f1a13cf00fc507eb5562a19", @"/Views/Home/MultiTabInSingle2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7813c775e848b2a0628eaa5700c5a962eeba155", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_MultiTabInSingle2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script src=""../js/jquery.PrintArea.js"" type=""text/javascript""></script>

<script type=""text/javascript"">
    $(document).ready(function () {
        $(""#tabs"").tabs();
        $(""#print_button"").click(function () {
            $(""div.PrintArea"").printArea();
        });
</script>


<div id=""tabs"">
    <ul>
        <li><a href=""#tabs-1"">TAB1</a></li>
        <li><a href=""#tabs-2"">TAB2</a></li>
        <li><a href=""#tabs-3"">TAB3</a></li>
    </ul>
    <div id=""tabs-1""></div>
    <div id=""tabs-2""></div>
    <div id=""tabs-3""></div>
</div>
<button type=""submit"" id=""print_button"">
    <img src=""../images/printer.png""
         alt=""print icon"" style=""vertical-align:text-bottom;"" /> PRINT PAGE
</button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
