#pragma checksum "C:\Users\Takafumi\Documents\ProgramCodes\C#\Web\CalculatePiWebApp\CalculatePiWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71405992b65a2460abf8802778e68d5ff16f0e04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Takafumi\Documents\ProgramCodes\C#\Web\CalculatePiWebApp\CalculatePiWebApp\Views\_ViewImports.cshtml"
using CalculatePiWebApp;

#line default
#line hidden
#line 2 "C:\Users\Takafumi\Documents\ProgramCodes\C#\Web\CalculatePiWebApp\CalculatePiWebApp\Views\_ViewImports.cshtml"
using CalculatePiWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71405992b65a2460abf8802778e68d5ff16f0e04", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18e2a002c833ad4f3a7c6199ceb3e16004b4b095", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CalculatePiWebApp.Models.CalculatePiModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Takafumi\Documents\ProgramCodes\C#\Web\CalculatePiWebApp\CalculatePiWebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(95, 143, true);
            WriteLiteral("\r\n<h1 class=\"text-center\">Calculate Pi</h1>\r\n<p class=\"text-center\">This application calculates the value of Pi using Monte Carlo method.</p>\r\n");
            EndContext();
            BeginContext(238, 172, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b9809720ec84651913aeac38dddde80", async() => {
                BeginContext(258, 145, true);
                WriteLiteral("\r\n    <input type=\"number\" name=\"points\" min=\"1\" placeholder=\"Enter number of points\" required />\r\n    <button type=\"submit\">Calculate</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(410, 124, true);
            WriteLiteral("\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-sm-6 text-center\" id=\"distribution\">\r\n        <h2>Point Distribution</h2>\r\n");
            EndContext();
            BeginContext(546, 16, true);
            WriteLiteral("            <svg");
            EndContext();
            BeginWriteAttribute("width", " width=\"", 562, "\"", 588, 1);
#line 17 "C:\Users\Takafumi\Documents\ProgramCodes\C#\Web\CalculatePiWebApp\CalculatePiWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 570, Model.Chart.Width, 570, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("height", " height=\"", 589, "\"", 617, 1);
#line 17 "C:\Users\Takafumi\Documents\ProgramCodes\C#\Web\CalculatePiWebApp\CalculatePiWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 598, Model.Chart.Height, 598, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(618, 35, true);
            WriteLiteral(" style=\"border: 1px solid black\">\r\n");
            EndContext();
#line 18 "C:\Users\Takafumi\Documents\ProgramCodes\C#\Web\CalculatePiWebApp\CalculatePiWebApp\Views\Home\Index.cshtml"
                 for (int j = 0; j < Model.Points.Length; j++) {

#line default
#line hidden
            BeginContext(719, 27, true);
            WriteLiteral("                    <circle");
            EndContext();
            BeginWriteAttribute("cx", " cx=\"", 746, "\"", 803, 1);
#line 19 "C:\Users\Takafumi\Documents\ProgramCodes\C#\Web\CalculatePiWebApp\CalculatePiWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 751, Model.Points[j].PointVector.X * Model.Chart.Width, 751, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("cy", " cy=\"", 804, "\"", 868, 1);
#line 19 "C:\Users\Takafumi\Documents\ProgramCodes\C#\Web\CalculatePiWebApp\CalculatePiWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 809, (1 - Model.Points[j].PointVector.Y) * Model.Chart.Height, 809, 59, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("r", " r=\"", 869, "\"", 895, 1);
#line 19 "C:\Users\Takafumi\Documents\ProgramCodes\C#\Web\CalculatePiWebApp\CalculatePiWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 873, Model.Chart.PointSize, 873, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("stroke", "\r\n                            stroke=\"", 896, "\"", 961, 1);
#line 20 "C:\Users\Takafumi\Documents\ProgramCodes\C#\Web\CalculatePiWebApp\CalculatePiWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 934, Model.Points[j].PointColor, 934, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("stroke-width", " stroke-width=\"", 962, "\"", 999, 1);
#line 20 "C:\Users\Takafumi\Documents\ProgramCodes\C#\Web\CalculatePiWebApp\CalculatePiWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 977, Model.Chart.PointSize, 977, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("fill", " fill=\"", 1000, "\"", 1034, 1);
#line 20 "C:\Users\Takafumi\Documents\ProgramCodes\C#\Web\CalculatePiWebApp\CalculatePiWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1007, Model.Points[j].PointColor, 1007, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1035, 12, true);
            WriteLiteral("></circle>\r\n");
            EndContext();
#line 21 "C:\Users\Takafumi\Documents\ProgramCodes\C#\Web\CalculatePiWebApp\CalculatePiWebApp\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1066, 20, true);
            WriteLiteral("            </svg>\r\n");
            EndContext();
            BeginContext(1097, 216, true);
            WriteLiteral("    </div>\r\n    <div class=\"col-sm-6 text-center\" id=\"result\">\r\n        <h2>Result</h2>\r\n        <table class=\"table table-bordered\">\r\n            <tr>\r\n                <td>Number of Points</td>\r\n                <td>");
            EndContext();
            BeginContext(1314, 20, false);
#line 30 "C:\Users\Takafumi\Documents\ProgramCodes\C#\Web\CalculatePiWebApp\CalculatePiWebApp\Views\Home\Index.cshtml"
               Write(Model.NumberOfPoints);

#line default
#line hidden
            EndContext();
            BeginContext(1334, 106, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Points in Range</td>\r\n                <td>");
            EndContext();
            BeginContext(1441, 19, false);
#line 34 "C:\Users\Takafumi\Documents\ProgramCodes\C#\Web\CalculatePiWebApp\CalculatePiWebApp\Views\Home\Index.cshtml"
               Write(Model.PointsInRange);

#line default
#line hidden
            EndContext();
            BeginContext(1460, 107, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Calculated Value</td>\r\n                <td>");
            EndContext();
            BeginContext(1568, 36, false);
#line 38 "C:\Users\Takafumi\Documents\ProgramCodes\C#\Web\CalculatePiWebApp\CalculatePiWebApp\Views\Home\Index.cshtml"
               Write(Model.CalculatedValue.ToString("f4"));

#line default
#line hidden
            EndContext();
            BeginContext(1604, 108, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Pre-Defined Value</td>\r\n                <td>");
            EndContext();
            BeginContext(1713, 22, false);
#line 42 "C:\Users\Takafumi\Documents\ProgramCodes\C#\Web\CalculatePiWebApp\CalculatePiWebApp\Views\Home\Index.cshtml"
               Write(Math.PI.ToString("f4"));

#line default
#line hidden
            EndContext();
            BeginContext(1735, 104, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Percent Error</td>\r\n                <td>");
            EndContext();
            BeginContext(1840, 33, false);
#line 46 "C:\Users\Takafumi\Documents\ProgramCodes\C#\Web\CalculatePiWebApp\CalculatePiWebApp\Views\Home\Index.cshtml"
               Write(Model.PercentError.ToString("f4"));

#line default
#line hidden
            EndContext();
            BeginContext(1873, 65, true);
            WriteLiteral("%</td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CalculatePiWebApp.Models.CalculatePiModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
