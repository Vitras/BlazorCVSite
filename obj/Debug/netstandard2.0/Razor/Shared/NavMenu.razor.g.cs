#pragma checksum "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abdc4bb2a1196d0b141171993896619c1042d974"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCVSite.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\_Imports.razor"
using BlazorCVSite;

#line default
#line hidden
#line 7 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\_Imports.razor"
using BlazorCVSite.Shared;

#line default
#line hidden
#line 8 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\_Imports.razor"
using System.Diagnostics;

#line default
#line hidden
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", 
#line 1 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
            );
            builder.AddMarkupContent(2, "\r\n    ");
            builder.OpenElement(3, "ul");
            builder.AddAttribute(4, "class", "nav flex-row");
            builder.AddMarkupContent(5, "\r\n        ");
            builder.AddMarkupContent(6, "<li>\r\n            <a class=\"navbar-brand\" href>CVSite</a>\r\n            <button class=\"navbar-toggler\">\r\n                <span class=\"navbar-toggler-icon\"></span>\r\n            </button>\r\n        </li>\r\n        ");
            builder.OpenElement(7, "li");
            builder.AddAttribute(8, "class", "nav-item px-3");
            builder.AddMarkupContent(9, "\r\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(10);
            builder.AddAttribute(11, "class", "nav-link");
            builder.AddAttribute(12, "href", "");
            builder.AddAttribute(13, "Match", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#line 10 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
            ));
            builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 11 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\Shared\NavMenu.razor"
                                 () => OnHeaderPress(new List<string>())

#line default
#line hidden
            ));
            builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(16, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(17, "\r\n        ");
            builder.CloseElement();
            builder.AddMarkupContent(18, "\r\n        ");
            builder.OpenElement(19, "li");
            builder.AddAttribute(20, "class", "nav-item px-3");
            builder.AddMarkupContent(21, "\r\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(22);
            builder.AddAttribute(23, "class", "nav-link");
            builder.AddAttribute(24, "href", "About");
            builder.AddAttribute(25, "Match", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#line 16 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\Shared\NavMenu.razor"
                                                          NavLinkMatch.All

#line default
#line hidden
            ));
            builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 16 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\Shared\NavMenu.razor"
                                                                                        () => OnHeaderPress(new List<string>())

#line default
#line hidden
            ));
            builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(28, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> About\r\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(29, "\r\n        ");
            builder.CloseElement();
            builder.AddMarkupContent(30, "\r\n        ");
            builder.OpenElement(31, "li");
            builder.AddAttribute(32, "class", "nav-item px-3");
            builder.AddMarkupContent(33, "\r\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(34);
            builder.AddAttribute(35, "class", "nav-link");
            builder.AddAttribute(36, "href", "Career");
            builder.AddAttribute(37, "Match", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#line 21 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\Shared\NavMenu.razor"
                                                           NavLinkMatch.All

#line default
#line hidden
            ));
            builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 21 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\Shared\NavMenu.razor"
                                                                                          () => OnHeaderPress(new List<string>() { "Education", "Keylane" })

#line default
#line hidden
            ));
            builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(40, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Career\r\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(41, "\r\n        ");
            builder.CloseElement();
            builder.AddMarkupContent(42, "\r\n        ");
            builder.OpenElement(43, "li");
            builder.AddAttribute(44, "class", "nav-item px-3");
            builder.AddMarkupContent(45, "\r\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(46);
            builder.AddAttribute(47, "class", "nav-link");
            builder.AddAttribute(48, "href", "Skills");
            builder.AddAttribute(49, "Match", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#line 26 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\Shared\NavMenu.razor"
                                                           NavLinkMatch.All

#line default
#line hidden
            ));
            builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 26 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\Shared\NavMenu.razor"
                                                                                          () => OnHeaderPress(new List<string>() {"C#", "Blazor", ".NET Core", "Unity3D", "Godot", "Java" })

#line default
#line hidden
            ));
            builder.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(52, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Skills\r\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(53, "\r\n        ");
            builder.CloseElement();
            builder.AddMarkupContent(54, "\r\n        ");
            builder.OpenElement(55, "li");
            builder.AddAttribute(56, "class", "nav-item px-3");
            builder.AddMarkupContent(57, "\r\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(58);
            builder.AddAttribute(59, "class", "nav-link");
            builder.AddAttribute(60, "href", "Achievements");
            builder.AddAttribute(61, "Match", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#line 31 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\Shared\NavMenu.razor"
                                                                 NavLinkMatch.All

#line default
#line hidden
            ));
            builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 31 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\Shared\NavMenu.razor"
                                                                                               () => OnHeaderPress(new List<string>())

#line default
#line hidden
            ));
            builder.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(64, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Achievements\r\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(65, "\r\n        ");
            builder.CloseElement();
            builder.AddMarkupContent(66, "\r\n        ");
            builder.OpenElement(67, "li");
            builder.AddAttribute(68, "class", "nav-item px-3");
            builder.AddMarkupContent(69, "\r\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(70);
            builder.AddAttribute(71, "class", "nav-link");
            builder.AddAttribute(72, "href", "Contact");
            builder.AddAttribute(73, "Match", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#line 36 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\Shared\NavMenu.razor"
                                                            NavLinkMatch.All

#line default
#line hidden
            ));
            builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 36 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\Shared\NavMenu.razor"
                                                                                          () => OnHeaderPress(new List<string>())

#line default
#line hidden
            ));
            builder.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(76, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Contact\r\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(77, "\r\n        ");
            builder.CloseElement();
            builder.AddMarkupContent(78, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(79, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 43 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\Shared\NavMenu.razor"
       
bool collapseNavMenu = true;

string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

[Parameter]
public Action<List<string>> OnHeaderPress { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
