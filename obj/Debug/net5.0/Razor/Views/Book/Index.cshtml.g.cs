#pragma checksum "C:\Users\MSI\Desktop\1\BookManeger\BookManeger\Views\Book\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1da2af62c1a05c6462033ed86b0ff065430527bcff705873046b431d9105cde9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\MSI\Desktop\1\BookManeger\BookManeger\Views\_ViewImports.cshtml"
using BookManeger;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MSI\Desktop\1\BookManeger\BookManeger\Views\_ViewImports.cshtml"
using BookManeger.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1da2af62c1a05c6462033ed86b0ff065430527bcff705873046b431d9105cde9", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ceed0b63b700fd403c8d839fce1008d2a286481c0633a060f6813339f02d433d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Book>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Book List</h1>

<p><a href=""/Book/Create"">Add New Book</a></p>

<table class=""table"">
    <thead>
        <tr>
            <th>Title</th>
            <th>Author</th>
            <th>Year</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 17 "C:\Users\MSI\Desktop\1\BookManeger\BookManeger\Views\Book\Index.cshtml"
         foreach (var book in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\MSI\Desktop\1\BookManeger\BookManeger\Views\Book\Index.cshtml"
               Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\MSI\Desktop\1\BookManeger\BookManeger\Views\Book\Index.cshtml"
               Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\MSI\Desktop\1\BookManeger\BookManeger\Views\Book\Index.cshtml"
               Write(book.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 531, "\"", 557, 2);
            WriteAttributeValue("", 538, "/Book/Edit/", 538, 11, true);
#nullable restore
#line 24 "C:\Users\MSI\Desktop\1\BookManeger\BookManeger\Views\Book\Index.cshtml"
WriteAttributeValue("", 549, book.Id, 549, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 615, "\"", 643, 2);
            WriteAttributeValue("", 622, "/Book/Delete/", 622, 13, true);
#nullable restore
#line 25 "C:\Users\MSI\Desktop\1\BookManeger\BookManeger\Views\Book\Index.cshtml"
WriteAttributeValue("", 635, book.Id, 635, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\MSI\Desktop\1\BookManeger\BookManeger\Views\Book\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Book>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591