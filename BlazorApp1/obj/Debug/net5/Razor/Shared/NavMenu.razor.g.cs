#pragma checksum "C:\Users\nawam01\Documents\blackhole\Tailwind\myapp\myapp\BlazorApp1\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61d4e04679af6698d01008e4cee6a40a3762a1c3"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nawam01\Documents\blackhole\Tailwind\myapp\myapp\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nawam01\Documents\blackhole\Tailwind\myapp\myapp\BlazorApp1\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nawam01\Documents\blackhole\Tailwind\myapp\myapp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nawam01\Documents\blackhole\Tailwind\myapp\myapp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nawam01\Documents\blackhole\Tailwind\myapp\myapp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nawam01\Documents\blackhole\Tailwind\myapp\myapp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nawam01\Documents\blackhole\Tailwind\myapp\myapp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nawam01\Documents\blackhole\Tailwind\myapp\myapp\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nawam01\Documents\blackhole\Tailwind\myapp\myapp\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nawam01\Documents\blackhole\Tailwind\myapp\myapp\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nawam01\Documents\blackhole\Tailwind\myapp\myapp\BlazorApp1\_Imports.razor"
using Blazorise.Sidebar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\nawam01\Documents\blackhole\Tailwind\myapp\myapp\BlazorApp1\_Imports.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "bg-gray-800");
            __builder.AddAttribute(2, "b-b5wscdn8ts");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "max-w-7xl mx-auto px-2 sm:px-6 lg:px-8");
            __builder.AddAttribute(5, "b-b5wscdn8ts");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "relative flex items-center justify-between h-16");
            __builder.AddAttribute(8, "b-b5wscdn8ts");
            __builder.AddMarkupContent(9, @"<div class=""absolute inset-y-0 left-0 flex items-center sm:hidden"" b-b5wscdn8ts><button type=""button"" class=""inline-flex items-center justify-center p-2 rounded-md text-gray-400 hover:text-white hover:bg-gray-700 focus:outline-none focus:ring-2 focus:ring-inset focus:ring-white"" aria-controls=""mobile-menu"" aria-expanded=""false"" b-b5wscdn8ts><span class=""sr-only"" b-b5wscdn8ts>Open main menu</span>
          
          <svg class=""block h-6 w-6"" xmlns=""http://www.w3.org/2000/svg"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"" aria-hidden=""true"" b-b5wscdn8ts><path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M4 6h16M4 12h16M4 18h16"" b-b5wscdn8ts></path></svg>
          
          <svg class=""hidden h-6 w-6"" xmlns=""http://www.w3.org/2000/svg"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"" aria-hidden=""true"" b-b5wscdn8ts><path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M6 18L18 6M6 6l12 12"" b-b5wscdn8ts></path></svg></button></div>
      ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "flex-1 flex items-center justify-center sm:items-stretch sm:justify-start");
            __builder.AddAttribute(12, "b-b5wscdn8ts");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "flex-shrink-0 flex items-center");
            __builder.AddAttribute(15, "b-b5wscdn8ts");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(16);
            __builder.AddAttribute(17, "class", "text-white font-sans");
            __builder.AddAttribute(18, "href", "#");
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(20, " Nawa Mumbwe ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "hidden sm:block sm:ml-6");
            __builder.AddAttribute(24, "b-b5wscdn8ts");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "flex space-x-4 group ");
            __builder.AddAttribute(27, "b-b5wscdn8ts");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(28);
            __builder.AddAttribute(29, "href", "#");
            __builder.AddAttribute(30, "class", "group-focus:ring-2 focus:ring-white-500 hover:bg-gray-700 text-gray-300 text-white px-3 py-2 rounded-md text-sm font-medium");
            __builder.AddAttribute(31, "aria-current", "page");
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(33, "Home");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(35);
            __builder.AddAttribute(36, "href", "about");
            __builder.AddAttribute(37, "class", "group-focus:ring-2 focus:ring-white-500 hover:bg-gray-700 text-gray-300 hover:bg-gray-700 hover:text-white px-3 py-2 rounded-md text-sm font-medium");
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(39, "About");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(40, "\r\n\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(41);
            __builder.AddAttribute(42, "href", "projects");
            __builder.AddAttribute(43, "class", "group-focus:ring-2 focus:ring-white-500 hover:bg-gray-700 text-gray-300 hover:bg-gray-700 hover:text-white px-3 py-2 rounded-md text-sm font-medium");
            __builder.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(45, "Projects\r\n                ");
                __builder2.AddMarkupContent(46, "<div class=\"ribbon bg-red-500 text-sm whitespace-no-wrap px-4\" b-b5wscdn8ts>coming soon</div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n  \r\n  ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "sm:hidden");
            __builder.AddAttribute(50, "id", "mobile-menu");
            __builder.AddAttribute(51, "b-b5wscdn8ts");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "px-2 pt-2 pb-3 space-y-1");
            __builder.AddAttribute(54, "b-b5wscdn8ts");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(55);
            __builder.AddAttribute(56, "onclick", 
#nullable restore
#line 59 "C:\Users\nawam01\Documents\blackhole\Tailwind\myapp\myapp\BlazorApp1\Shared\NavMenu.razor"
                        HandleClick

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(57, "href", "/");
            __builder.AddAttribute(58, "class", "text-gray-300 text-white block px-3 py-2 rounded-md text-base font-medium");
            __builder.AddAttribute(59, "aria-current", "page");
            __builder.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(61, "Home");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(62, "\r\n      ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(63);
            __builder.AddAttribute(64, "href", "about");
            __builder.AddAttribute(65, "class", "text-gray-300 hover:bg-gray-700 hover:text-white block px-3 py-2 rounded-md text-base font-medium");
            __builder.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(67, "About");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(68, "\r\n      ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(69);
            __builder.AddAttribute(70, "href", "projects");
            __builder.AddAttribute(71, "class", "text-gray-300 hover:bg-gray-700 hover:text-white block px-3 py-2 rounded-md text-base font-medium");
            __builder.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(73, "Projects");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\nawam01\Documents\blackhole\Tailwind\myapp\myapp\BlazorApp1\Shared\NavMenu.razor"
       
    private void HandleClick()
    {
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591