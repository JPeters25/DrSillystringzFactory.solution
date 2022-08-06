#pragma checksum "C:\Users\jpete\OneDrive\Desktop\Coding\Factory.Solution\Factory\Views\Engineers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b996fc930479020c909e6906280a68580afb9c8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Engineers_Details), @"mvc.1.0.view", @"/Views/Engineers/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b996fc930479020c909e6906280a68580afb9c8d", @"/Views/Engineers/Details.cshtml")]
    #nullable restore
    public class Views_Engineers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Engineer>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jpete\OneDrive\Desktop\Coding\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<div");
            BeginWriteAttribute("id", " id=", 69, "", 73, 0);
            EndWriteAttribute();
            WriteLiteral(" Header>\r\n  <h1 id=HeaderText>Dr.Sillystringz\'s Factory</h2>\r\n  <h2 id=PageTitle>Engineer Details</h2>\r\n</div>\r\n<hr />\r\n<div id=MainBody>\r\n<h3>");
#nullable restore
#line 12 "C:\Users\jpete\OneDrive\Desktop\Coding\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 12 "C:\Users\jpete\OneDrive\Desktop\Coding\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h4>");
#nullable restore
#line 13 "C:\Users\jpete\OneDrive\Desktop\Coding\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
Write(Html.DisplayNameFor(model => model.License));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 13 "C:\Users\jpete\OneDrive\Desktop\Coding\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
                                             Write(Html.DisplayFor(model => model.License));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 14 "C:\Users\jpete\OneDrive\Desktop\Coding\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
 if(@Model.JoinEntities.Count == 0)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>There are no Machines assigned to this Engineer at this time.</p>\r\n");
#nullable restore
#line 17 "C:\Users\jpete\OneDrive\Desktop\Coding\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
  }else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <h4>Machines assigned to this Engineer:</h4>\r\n      <ul>\r\n");
#nullable restore
#line 21 "C:\Users\jpete\OneDrive\Desktop\Coding\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
         foreach(var join in Model.JoinEntities)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 23 "C:\Users\jpete\OneDrive\Desktop\Coding\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
           Write(join.Machine.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n");
#nullable restore
#line 24 "C:\Users\jpete\OneDrive\Desktop\Coding\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </ul>\r\n");
#nullable restore
#line 26 "C:\Users\jpete\OneDrive\Desktop\Coding\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 27 "C:\Users\jpete\OneDrive\Desktop\Coding\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
Write(Html.ActionLink("Back to Engineers", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 28 "C:\Users\jpete\OneDrive\Desktop\Coding\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
Write(Html.ActionLink("Edit Engineer", "Edit", new { id = Model.EngineerId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 29 "C:\Users\jpete\OneDrive\Desktop\Coding\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
Write(Html.ActionLink("Delete Engineer", "Delete", new {id = Model.EngineerId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 30 "C:\Users\jpete\OneDrive\Desktop\Coding\Factory.Solution\Factory\Views\Engineers\Details.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
</div>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>
  <i></i>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Factory.Models.Engineer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
