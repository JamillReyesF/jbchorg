#pragma checksum "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Asociado/Asociados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d17f1f0796973618458f9fef7fd192b3e5f058d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Asociado_Asociados), @"mvc.1.0.view", @"/Views/Asociado/Asociados.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Asociado/Asociados.cshtml", typeof(AspNetCore.Views_Asociado_Asociados))]
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
#line 1 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/_ViewImports.cshtml"
using jbchorg;

#line default
#line hidden
#line 2 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/_ViewImports.cshtml"
using jbchorg.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d17f1f0796973618458f9fef7fd192b3e5f058d", @"/Views/Asociado/Asociados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b89e584924fbd26fb54ceba122ba44003e3a6676", @"/Views/_ViewImports.cshtml")]
    public class Views_Asociado_Asociados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<jbchorg.Models.Asociado>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Asociado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "asociados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Asociado/Asociados.cshtml"
  
    ViewData["Title"] = "Publicaciones";

#line default
#line hidden
            BeginContext(90, 15, true);
            WriteLiteral("<div><br/>\n    ");
            EndContext();
            BeginContext(105, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cee9da3a0c74eae87c8d5ea35cb3a59", async() => {
                BeginContext(130, 5, true);
                WriteLiteral("Crear");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(139, 30, true);
            WriteLiteral("</div><br/>\n<div class=\"row\">\n");
            EndContext();
            BeginContext(169, 199, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c7cf9bbdf9a4f908cf143f3c66eda5a", async() => {
                BeginContext(211, 58, true);
                WriteLiteral("\n    <input type=\"text\" name=\"buscar\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 269, "\"", 292, 1);
#line 9 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Asociado/Asociados.cshtml"
WriteAttributeValue("", 277, ViewBag.buscar, 277, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(293, 68, true);
                WriteLiteral(">\n    <button type=\"submit\" class=\"btn btn-primary\">buscar</button>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(368, 415, true);
            WriteLiteral(@"
</div><br/>
<div class=""row"">
<table class=""table table-bordered table-responsive table-hover"">
    <thead>
        <tr>
            <th>N°</th>
            <th>Nombre y Apellido</th>
            <th>Email</th>
            <th>Genero</th>
            <th>Tipo de Asociado</th>
             <th>Grado Academico</th>
            <th>Áreas de Interés</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 28 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Asociado/Asociados.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(830, 38, true);
            WriteLiteral("            <tr>\n                 <td>");
            EndContext();
            BeginContext(869, 37, false);
#line 31 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Asociado/Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(906, 45, true);
            WriteLiteral("\n                 </td>\n                 <td>");
            EndContext();
            BeginContext(952, 41, false);
#line 33 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Asociado/Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(993, 22, true);
            WriteLiteral("\n                     ");
            EndContext();
            BeginContext(1016, 43, false);
#line 34 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Asociado/Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.APaterno));

#line default
#line hidden
            EndContext();
            BeginContext(1059, 22, true);
            WriteLiteral("\n                     ");
            EndContext();
            BeginContext(1082, 43, false);
#line 35 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Asociado/Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.AMaterno));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 45, true);
            WriteLiteral("\n                 </td>\n                 <td>");
            EndContext();
            BeginContext(1171, 40, false);
#line 37 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Asociado/Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1211, 89, true);
            WriteLiteral("\n                     \n                 </td>\n                 <td>\n                     ");
            EndContext();
            BeginContext(1301, 41, false);
#line 41 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Asociado/Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.Genero));

#line default
#line hidden
            EndContext();
            BeginContext(1342, 46, true);
            WriteLiteral("\n                 </td> \n                 <td>");
            EndContext();
            BeginContext(1389, 51, false);
#line 43 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Asociado/Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.TAsociado.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1440, 45, true);
            WriteLiteral("\n                 </td>\n                 <td>");
            EndContext();
            BeginContext(1486, 45, false);
#line 45 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Asociado/Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.GAcademico));

#line default
#line hidden
            EndContext();
            BeginContext(1531, 46, true);
            WriteLiteral("\n                 </td>\n                  <td>");
            EndContext();
            BeginContext(1578, 39, false);
#line 47 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Asociado/Asociados.cshtml"
                 Write(Html.DisplayFor(modelItem => item.Area));

#line default
#line hidden
            EndContext();
            BeginContext(1617, 67, true);
            WriteLiteral("\n                 </td>\n                 <td>\n                     ");
            EndContext();
            BeginContext(1684, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b23acbbf1b7b42a9b877395ef7e37ab3", async() => {
                BeginContext(1733, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Asociado/Asociados.cshtml"
                                                WriteLiteral(item.Id);

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
            BeginContext(1744, 42, true);
            WriteLiteral("\n                 </td>\n            </tr>\n");
            EndContext();
#line 53 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Asociado/Asociados.cshtml"
           
        }

#line default
#line hidden
            BeginContext(1808, 29, true);
            WriteLiteral("    </tbody>\n</table>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<jbchorg.Models.Asociado>> Html { get; private set; }
    }
}
#pragma warning restore 1591
