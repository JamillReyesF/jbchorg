#pragma checksum "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf165910e4d92171afff64fab924acf0dfa5344f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf165910e4d92171afff64fab924acf0dfa5344f", @"/Views/Asociado/Asociados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b89e584924fbd26fb54ceba122ba44003e3a6676", @"/Views/_ViewImports.cshtml")]
    public class Views_Asociado_Asociados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<jbchorg.Models.Asociado>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Asociado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Asociado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Asociados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97a328110aa943a896d273a8dd5a8867", async() => {
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
            BeginContext(176, 292, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8efb6aa48dc344c09300c3b8843a90c2", async() => {
                BeginContext(231, 230, true);
                WriteLiteral("\r\n    <div class=\"col-lg-7\">\r\n    <input value=\"\" type=\"text\" name=\"fNom\"  class=\"form-search form-control\" placeholder=\"Búsqueda por Nombre\"><br />\r\n    <button type=\"submit\" class=\"btn btn-primary\">Filtrar</button>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(468, 432, true);
            WriteLiteral(@"
</div><br/>
<div class=""row"">
<table class=""table table-bordered table-responsive table-hover"">
    <thead>
        <tr>
            <th>N°</th>
            <th>Nombre y Apellido</th>
            <th>Genero</th>
            <th>Email</th>
            <th>Tipo de Asociado</th>
             <th>Grado Academico</th>
            <th>Áreas de Interés</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 30 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(949, 39, true);
            WriteLiteral("            <tr>\r\n                 <td>");
            EndContext();
            BeginContext(989, 37, false);
#line 33 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 47, true);
            WriteLiteral("\r\n                 </td>\r\n                 <td>");
            EndContext();
            BeginContext(1074, 41, false);
#line 35 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1115, 23, true);
            WriteLiteral("\r\n                     ");
            EndContext();
            BeginContext(1139, 43, false);
#line 36 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.APaterno));

#line default
#line hidden
            EndContext();
            BeginContext(1182, 23, true);
            WriteLiteral("\r\n                     ");
            EndContext();
            BeginContext(1206, 43, false);
#line 37 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.AMaterno));

#line default
#line hidden
            EndContext();
            BeginContext(1249, 70, true);
            WriteLiteral("\r\n                 </td>\r\n                 <td>\r\n                     ");
            EndContext();
            BeginContext(1320, 41, false);
#line 40 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.Genero));

#line default
#line hidden
            EndContext();
            BeginContext(1361, 47, true);
            WriteLiteral("\r\n                 </td>\r\n                 <td>");
            EndContext();
            BeginContext(1409, 41, false);
#line 42 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.Correo));

#line default
#line hidden
            EndContext();
            BeginContext(1450, 47, true);
            WriteLiteral("\r\n                 </td>\r\n                 <td>");
            EndContext();
            BeginContext(1498, 44, false);
#line 44 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.TAsociado));

#line default
#line hidden
            EndContext();
            BeginContext(1542, 47, true);
            WriteLiteral("\r\n                 </td>\r\n                 <td>");
            EndContext();
            BeginContext(1590, 45, false);
#line 46 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
                Write(Html.DisplayFor(modelItem => item.GAcademico));

#line default
#line hidden
            EndContext();
            BeginContext(1635, 48, true);
            WriteLiteral("\r\n                 </td>\r\n                  <td>");
            EndContext();
            BeginContext(1684, 39, false);
#line 48 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
                 Write(Html.DisplayFor(modelItem => item.Area));

#line default
#line hidden
            EndContext();
            BeginContext(1723, 70, true);
            WriteLiteral("\r\n                 </td>\r\n                 <td>\r\n                     ");
            EndContext();
            BeginContext(1793, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b247260c26b44abd8e5c2c47e835ce84", async() => {
                BeginContext(1843, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
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
            BeginContext(1854, 45, true);
            WriteLiteral("\r\n                 </td>\r\n            </tr>\r\n");
            EndContext();
#line 54 "C:\Users\Usuario\Desktop\jbchorg\jbchorg\Views\Asociado\Asociados.cshtml"
           
        }

#line default
#line hidden
            BeginContext(1923, 32, true);
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
