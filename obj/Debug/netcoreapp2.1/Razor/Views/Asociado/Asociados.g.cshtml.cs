#pragma checksum "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0da50c1ce301e4579a9f025865782d9535c7ba7"
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
#line 1 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\_ViewImports.cshtml"
using jbchorg;

#line default
#line hidden
#line 2 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\_ViewImports.cshtml"
using jbchorg.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0da50c1ce301e4579a9f025865782d9535c7ba7", @"/Views/Asociado/Asociados.cshtml")]
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
#line 2 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
  
    ViewData["Title"] = "Publicaciones";

#line default
#line hidden
            BeginContext(94, 16, true);
            WriteLiteral("<div><br/>\r\n    ");
            EndContext();
            BeginContext(110, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "883b95fc485a451cbceee28ac3fee317", async() => {
                BeginContext(135, 5, true);
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
            BeginContext(144, 32, true);
            WriteLiteral("</div><br/>\r\n<div class=\"row\">\r\n");
            EndContext();
            BeginContext(176, 202, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71d08b40f26145019235f2c23cd6910f", async() => {
                BeginContext(218, 59, true);
                WriteLiteral("\r\n    <input type=\"text\" name=\"buscar\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 277, "\"", 300, 1);
#line 9 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
WriteAttributeValue("", 285, ViewBag.buscar, 285, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(301, 70, true);
                WriteLiteral(">\r\n    <button type=\"submit\" class=\"btn btn-primary\">buscar</button>\r\n");
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
            BeginContext(378, 432, true);
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
#line 28 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(859, 39, true);
            WriteLiteral("            <tr>\r\n                 <td>");
            EndContext();
            BeginContext(899, 37, false);
#line 31 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(936, 47, true);
            WriteLiteral("\r\n                 </td>\r\n                 <td>");
            EndContext();
            BeginContext(984, 41, false);
#line 33 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 23, true);
            WriteLiteral("\r\n                     ");
            EndContext();
            BeginContext(1049, 43, false);
#line 34 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.APaterno));

#line default
#line hidden
            EndContext();
            BeginContext(1092, 23, true);
            WriteLiteral("\r\n                     ");
            EndContext();
            BeginContext(1116, 43, false);
#line 35 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.AMaterno));

#line default
#line hidden
            EndContext();
            BeginContext(1159, 47, true);
            WriteLiteral("\r\n                 </td>\r\n                 <td>");
            EndContext();
            BeginContext(1207, 40, false);
#line 37 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1247, 93, true);
            WriteLiteral("\r\n                     \r\n                 </td>\r\n                 <td>\r\n                     ");
            EndContext();
            BeginContext(1341, 41, false);
#line 41 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.Genero));

#line default
#line hidden
            EndContext();
            BeginContext(1382, 48, true);
            WriteLiteral("\r\n                 </td> \r\n                 <td>");
            EndContext();
            BeginContext(1431, 51, false);
#line 43 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.TAsociado.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1482, 47, true);
            WriteLiteral("\r\n                 </td>\r\n                 <td>");
            EndContext();
            BeginContext(1530, 45, false);
#line 45 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.GAcademico));

#line default
#line hidden
            EndContext();
            BeginContext(1575, 48, true);
            WriteLiteral("\r\n                 </td>\r\n                  <td>");
            EndContext();
            BeginContext(1624, 39, false);
#line 47 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
                 Write(Html.DisplayFor(modelItem => item.Area));

#line default
#line hidden
            EndContext();
            BeginContext(1663, 70, true);
            WriteLiteral("\r\n                 </td>\r\n                 <td>\r\n                     ");
            EndContext();
            BeginContext(1733, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31791ee4e7534b0e9f69d8ab9fbcba26", async() => {
                BeginContext(1782, 7, true);
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
#line 50 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
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
            BeginContext(1793, 45, true);
            WriteLiteral("\r\n                 </td>\r\n            </tr>\r\n");
            EndContext();
#line 53 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
           
        }

#line default
#line hidden
            BeginContext(1862, 32, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n</div>\r\n");
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
