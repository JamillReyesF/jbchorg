#pragma checksum "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Servicio/Servicios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78ba7ca77cb03332294c09c28782064ae830efd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Servicio_Servicios), @"mvc.1.0.view", @"/Views/Servicio/Servicios.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Servicio/Servicios.cshtml", typeof(AspNetCore.Views_Servicio_Servicios))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78ba7ca77cb03332294c09c28782064ae830efd4", @"/Views/Servicio/Servicios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b89e584924fbd26fb54ceba122ba44003e3a6676", @"/Views/_ViewImports.cshtml")]
    public class Views_Servicio_Servicios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<jbchorg.Models.Servicio>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Servicio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Servicio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Servicios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Servicio/Servicios.cshtml"
  
    ViewData["Title"] = "Servicios";

#line default
#line hidden
            BeginContext(87, 15, true);
            WriteLiteral("<div><br/>\n    ");
            EndContext();
            BeginContext(102, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f46648128be44081b73f034274c6aa7e", async() => {
                BeginContext(127, 5, true);
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
            BeginContext(136, 30, true);
            WriteLiteral("</div><br/>\n<div class=\"row\">\n");
            EndContext();
            BeginContext(166, 287, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a69be4d69b44dcf9190220fbbb64362", async() => {
                BeginContext(221, 225, true);
                WriteLiteral("\n    <div class=\"col-lg-7\">\n    <input value=\"\" type=\"text\" name=\"fNom\"  class=\"form-search form-control\" placeholder=\"Búsqueda por Nombre\"><br />\n    <button type=\"submit\" class=\"btn btn-primary\">Filtrar</button>\n    </div>\n");
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
            BeginContext(453, 332, true);
            WriteLiteral(@"
</div><br/>
<div class=""row"">
<table class=""table table-bordered table-responsive table-hover"">
    <thead>
        <tr>
            <th>N°</th>
            <th>Nombre del Servicio</th>
            <th>Tipo de Servicio</th>
            <th>Descripcion</th>
            
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 28 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Servicio/Servicios.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(832, 38, true);
            WriteLiteral("            <tr>\n                 <td>");
            EndContext();
            BeginContext(871, 37, false);
#line 31 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Servicio/Servicios.cshtml"
                Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(908, 45, true);
            WriteLiteral("\n                 </td>\n                 <td>");
            EndContext();
            BeginContext(954, 45, false);
#line 33 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Servicio/Servicios.cshtml"
                Write(Html.DisplayFor(modelItem => item.NombreServ));

#line default
#line hidden
            EndContext();
            BeginContext(999, 22, true);
            WriteLiteral("\n                     ");
            EndContext();
            BeginContext(1022, 39, false);
#line 34 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Servicio/Servicios.cshtml"
                Write(Html.DisplayFor(modelItem => item.tipo));

#line default
#line hidden
            EndContext();
            BeginContext(1061, 22, true);
            WriteLiteral("\n                     ");
            EndContext();
            BeginContext(1084, 46, false);
#line 35 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Servicio/Servicios.cshtml"
                Write(Html.DisplayFor(modelItem => item.descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 85, true);
            WriteLiteral("\n                 </td>\n                 \n                 <td>\n                     ");
            EndContext();
            BeginContext(1215, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f836ac814d04494f9ba81ba19bcd1690", async() => {
                BeginContext(1265, 7, true);
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
#line 39 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Servicio/Servicios.cshtml"
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
            BeginContext(1276, 42, true);
            WriteLiteral("\n                 </td>\n            </tr>\n");
            EndContext();
#line 42 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Servicio/Servicios.cshtml"
           
        }

#line default
#line hidden
            BeginContext(1340, 29, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<jbchorg.Models.Servicio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
