#pragma checksum "C:\Projects\Cold\May\05162022\TextAreaMessageToPdf\TextAreaMessageToPdf\Views\Home\Pdf1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1aa0e07c6f0b12a1fb60274fca277bd13fe2aff7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Pdf1), @"mvc.1.0.view", @"/Views/Home/Pdf1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1aa0e07c6f0b12a1fb60274fca277bd13fe2aff7", @"/Views/Home/Pdf1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7813c775e848b2a0628eaa5700c5a962eeba155", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Pdf1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
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
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1aa0e07c6f0b12a1fb60274fca277bd13fe2aff73349", async() => {
                WriteLiteral(@"
    <title>Online Test (Sample)</title>

    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/webcamjs/1.0.25/webcam.js""></script>
    <style>
        * {
            font-family: 'Calibri Light';
            color: #17293c;
            box-sizing: border-box;
        }

        h1, h2 {
            margin: 0 auto;
            padding: 0;
            text-align: center;
            color: #17293c;
            font-size: 18px;
        }

        input[type=button] {
            font-size: 15px;
            display: block;
            display: inline-block;
            vertical-align: middle;
            text-align: center;
            cursor: pointer;
        }

        ::placeholder {
            color: #999;
            text-transform: lowercase;
        }

        ul {
            display: inline-block;
            list-style: none;
            margin: 0;
            padding: 0;
            width: 97%;
        }

            ul > li {
    ");
                WriteLiteral(@"            margin-left: 2%;
            }

                ul > li > input[type=text] {
                    width: 99%;
                }

        #container ul > li {
            width: 94%;
            color: #000;
            font-size: 18px;
        }

        #container_data_entry {
            border: solid 1px #ccc;
            border-radius: 4px;
            margin: 5px 5px 5px 0;
            padding: 10px 5px;
            background-color: #f5f5f5;
            overflow: auto;
            height: 100%;
        }

        #student_details {
            padding: 10px 0;
            background-color: #f5f5f5;
            color: #3d3d3d;
            border: solid 1px #ccc;
            border-radius: 4px;
            margin: 5px 0 5px 5px;
            width: 25%;
            float: right;
        }

        input[type=text], textarea {
            font-size: 16px;
            font-weight: 500;
            text-align: left;
            width: auto;
            padding");
                WriteLiteral(@": 9px;
            border: none;
            border-bottom: 1px solid #ccc;
            margin: 5px 0;
        }

        textarea {
            height: 3em;
            width: 100%;
        }

        /* 		Popup window. */
        #picturebox {
            display: none;
            position: fixed;
            border: 0;
            top: 0;
            right: 0;
            left: 0;
            overflow-x: auto;
            overflow-y: hidden;
            z-index: 9999;
            background-color: rgba(239,239,239,.9);
            width: 100%;
            height: 100%;
            padding-top: 10px;
            text-align: center;
            cursor: pointer;
            -webkit-box-align: center;
            -webkit-box-orient: vertical;
            -webkit-box-pack: center;
            -webkit-transition: .2s opacity;
            -webkit-perspective: 1000;
        }

        .revdivshowimg {
            display: block;
            width: 300px;
            top: 20%;");
                WriteLiteral(@"
            text-align: center;
            margin: 0 auto;
            padding: 0;
            position: relative;
            background-color: #fff;
            webkit-box-shadow: 6px 0 10px rgba(0,0,0,.2),-6px 0 10px rgba(0,0,0,.2);
            -moz-box-shadow: 6px 0 10px rgba(0,0,0,.2),-6px 0 10px rgba(0,0,0,.2);
            box-shadow: 6px 0 10px rgba(0,0,0,.2),-6px 0 10px rgba(0,0,0,.2);
            overflow: hidden;
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1aa0e07c6f0b12a1fb60274fca277bd13fe2aff77964", async() => {
                WriteLiteral(@"
    <div style=""padding: 10px 0;"">
        <h1>Online Test (Sample)</h1>
    </div>

    <div id=""student_details"">
        <h2>Student Details</h2>
        <ul>
            <li>
                <label>Name:</label>
                <input type=""text"" id=""txtStudentName""
                       placeholder=""enter your name"" />
            </li>
            <li>
                <label>Class:</label>
                <input type=""text"" id=""txtClass""
                       placeholder=""enter your class"" />
            </li>
            <li>
                <label>Picture:</label>
                <p id=""snapShot""
                   style=""width:125px;height:107px;border:solid 1px #888;margin-left:2%;"">
                </p>

                <input type=""button"" id=""btTakeSnap"" onclick=""onlineTestApp.takeSnapshot(this)""
                       value=""Take a Snapshot"" />
            </li>
        </ul>
    </div>

    <!--Data entry section.-->
    <div id=""container_data_entry"">
       ");
                WriteLiteral(@" <h2 id=""subject""><b>Subject - Computer Science</b></h2> <br />

        <div id=""container"" style=""width:100%;overflow:auto;"">
            <ul>
                <li>
                    <b>Q No. 1:</b>
                    What are Binary Operators? Give examples of arithmatic binary operators.
                </li>
                <li><textarea id=""a1""></textarea></li>
            </ul>
            <ul>
                <li>
                    <b>Q No. 2:</b>
                    What is type conversion? What is meant by implicit and explicit type conversion?
                </li>
                <li><textarea id=""a2""></textarea></li>
            </ul>
            <ul>
                <li><b>Q No. 3:</b> What do you mean by dynamic initialization of a variable? Give an example.</li>
                <li><textarea id=""a3""></textarea></li>
            </ul>
        </div>

        <div id=""picturebox"" style=""width:100%;height:100%;"">
            <div class=""revdivshowimg"">
               ");
                WriteLiteral(@" <div id=""camera""
                     style=""height:auto;text-align:center;margin:0 auto;"">
                </div>
                <p>
                    <input type=""button"" value=""Ok"" id=""btAddPicture"" onclick=""onlineTestApp.addCamPicture()"" />
                    <input type=""button"" value=""Cancel"" onclick=""document.getElementById('picturebox').style.display = 'none';"" />
                </p>

                <input type=""hidden"" id=""dataurl"" />
            </div>
        </div>

        <div style=""text-align:center;"">
            <input type=""button""");
                BeginWriteAttribute("style", " style=\"", 6208, "\"", 6216, 0);
                EndWriteAttribute();
                WriteLiteral(" value=\"Print to PDF\" id=\"btPrint\" onclick=\"onlineTestApp.printPage();\" />\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral(@"

<script>
    // Camera Settings.
    Webcam.set({
        width: 220,
        height: 190,
        image_format: 'jpeg',
        jpeg_quality: 100
    });

    Webcam.attach('#camera');

    let onlineTestApp = new function () {

        // Show container to capture picture.
        this.takeSnapshot = function (oButton) {
            document.getElementById('picturebox').style.display = 'block';
        }

        // Get the picture's data uri and provide it the image source.
        let dataURI = '';

        this.addCamPicture = function () {
            Webcam.snap(function (data_uri) {
                dataURI = data_uri;
                document.getElementById('snapShot').innerHTML =
                    '<img src=""' + data_uri + '"" width=""120px"" height=""100px"" id=""studentPic"" />';
            });
            document.getElementById('picturebox').style.display = 'none';
        }

        this.printPage = function () {

            //Add some style to the print.
      ");
            WriteLiteral(@"      // ref: https://www.encodedna.com/javascript/print-html-table-with-image-using-javascript.htm
            let style = ""<style>"";
            style = style + ""h2 {text-align:center; font:22px Times New Roman; font-weight:bold;}"";
            style = style + "".subject {text-align:center;}"";
            style = style + ""ul {font:18px Calibri; display:inline-block; list-style:none; margin:0; padding:20px 0;}"";
            style = style + "".answers {font:18px Calibri; padding:10px 0;}"";
            style = style + "".picture {float:right; padding:10px 0;}"";
            style = style + ""</style>"";

            // Add date and time (to avoid any any ambiguity concerning submission of paper).
            let oDt = new Date();

            // Get full date.
            let sDate = oDt.getDate() + '/' + (oDt.getMonth() + 1) + '/' + oDt.getFullYear();

            // Get full time.
            let hrs = oDt.getHours();
            let min = oDt.getMinutes();
            let sec = oDt.getSeconds();");
            WriteLiteral(@"

            let sTime = hrs + ':' + min + ':' + sec;

            let header = '<h2>Online Test</h2>' +
                '<div class=""subject"">' + document.getElementById(""subject"").innerHTML + '</div>' +
                '<ul><li><b>Name of Student</b>: ' + document.getElementById('txtStudentName').value + '</li> ' +
                '<li><b>Class</b>: ' + document.getElementById('txtClass').value + '</li> ' +
                '<li><b>Date & Time</b>: ' + sDate + ' (' + sTime + ')</li>' +
                '</ul>';

            let theBody = '';

            // attach the image.
            if (dataURI != '') {
                theBody = '<p class=""picture""><img src = ""' + document.getElementById('studentPic').src + '"" width=""90px"" height=""70px"" /></p>';
            }

            // get all textarea (anwsers).
            let ele_tArea = document.getElementsByTagName('textarea');

            for (let i = 0; i <= ele_tArea.length - 1; i++) {
                if (theBody === '') {
          ");
            WriteLiteral(@"          if (ele_tArea[i].value != '') {
                        theBody = '<p class=""answers""> <b>Answer ' + (i + 1) + '</b> - ' + ele_tArea[i].value + '</p>';
                    }
                }
                else {
                    if (ele_tArea[i].value != '') {
                        theBody = theBody + '<p class=""answers""> <b>Answer ' + (i + 1) + '</b> - ' + ele_tArea[i].value + '</p>';
                    }
                }
            }

            theBody = header + theBody;

            // Create window object and print the data.
            let newWin = window.open('', '', 'height=700,width=700');

            newWin.document.write(style);
            newWin.document.write(theBody);
            newWin.print();
            newWin.close();
        }
    }
</script>
</html>");
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
