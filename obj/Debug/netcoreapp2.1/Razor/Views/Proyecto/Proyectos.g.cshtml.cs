#pragma checksum "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Proyecto/Proyectos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c621c048946c23caea39e0008731832718bc0f60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Proyecto_Proyectos), @"mvc.1.0.view", @"/Views/Proyecto/Proyectos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Proyecto/Proyectos.cshtml", typeof(AspNetCore.Views_Proyecto_Proyectos))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c621c048946c23caea39e0008731832718bc0f60", @"/Views/Proyecto/Proyectos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b89e584924fbd26fb54ceba122ba44003e3a6676", @"/Views/_ViewImports.cshtml")]
    public class Views_Proyecto_Proyectos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<jbchorg.Models.Proyecto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Proyecto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Proyectos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Proyecto/Proyectos.cshtml"
  
    ViewData["Title"] = "Proyectos";

#line default
#line hidden
            BeginContext(86, 19, true);
            WriteLiteral("\n<div class=\"row\">\n");
            EndContext();
            BeginContext(105, 376, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a131066c3be94976952f0319f6120af1", async() => {
                BeginContext(160, 314, true);
                WriteLiteral(@"
    <div class=""col-lg-7"">
    <h3>Listado de Proyectos</h3>
    <input value="""" type=""text"" name=""fNom""  class=""form-search form-control"" placeholder=""Búsqueda por Nombre""><br />
    <button type=""submit"" class=""btn btn-primary"">Filtar</button>
    </div>
    <div class=""col-lg-5"">
        
        
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(481, 310, true);
            WriteLiteral(@"
</div><br/>
<div class=""row"">
<table class=""table table-bordered table-responsive table-hover"">
    <thead>
        <tr>
            <th>N°</th>
            <th>Nombre de Proyecto</th>
            <th>Duración</th>
            <th>Descripción</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 31 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Proyecto/Proyectos.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(838, 38, true);
            WriteLiteral("            <tr>\n                 <td>");
            EndContext();
            BeginContext(877, 37, false);
#line 34 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Proyecto/Proyectos.cshtml"
                Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(914, 45, true);
            WriteLiteral("\n                 </td>\n                 <td>");
            EndContext();
            BeginContext(960, 41, false);
#line 36 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Proyecto/Proyectos.cshtml"
                Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1001, 45, true);
            WriteLiteral("\n                 </td>\n                 <td>");
            EndContext();
            BeginContext(1047, 43, false);
#line 38 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Proyecto/Proyectos.cshtml"
                Write(Html.DisplayFor(modelItem => item.Duracion));

#line default
#line hidden
            EndContext();
            BeginContext(1090, 45, true);
            WriteLiteral("\n                 </td>\n                 <td>");
            EndContext();
            BeginContext(1136, 46, false);
#line 40 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Proyecto/Proyectos.cshtml"
                Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1182, 43, true);
            WriteLiteral("\n                 </td>\n            </tr> \n");
            EndContext();
#line 43 "/Users/jamillreyes/Downloads/jbchorg/jbchorg/Views/Proyecto/Proyectos.cshtml"
        }

#line default
#line hidden
            BeginContext(1235, 30, true);
            WriteLiteral("    </tbody>\n</table>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<jbchorg.Models.Proyecto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
