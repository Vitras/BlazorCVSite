#pragma checksum "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c906cd15d67b308f82ba6b5dab465339e8bc14c2"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCVSite.Pages
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
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            builder.OpenElement(1, "p");
            builder.AddContent(2, "Current count: ");
            builder.AddContent(3, 
#line 5 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(4, "\r\n\r\n");
            builder.OpenElement(5, "button");
            builder.AddAttribute(6, "class", "btn btn-primary");
            builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 7 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\Pages\Counter.razor"
                                           IncrementCount

#line default
#line hidden
            ));
            builder.AddContent(8, "Click me");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 9 "D:\Projects\C#\C# other stuff\Blazor\BlazorCVSite\Pages\Counter.razor"
       
int currentCount = 0;

[Parameter]
private int IncrementAmount { get; set; } = 1;


void IncrementCount()
{
    currentCount += IncrementAmount;
}

#line default
#line hidden
    }
}
#pragma warning restore 1591
