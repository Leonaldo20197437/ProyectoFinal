#pragma checksum "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d582bb1e9df6158fbbe6b227204e2cd2baa205e4"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea6_7.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\_Imports.razor"
using Tarea6_7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\_Imports.razor"
using Tarea6_7.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>Tarea 6 y 7</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(14);
            __builder.AddAttribute(15, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenElement(17, "ul");
                __builder2.AddAttribute(18, "class", "nav flex-column");
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenElement(20, "li");
                __builder2.AddAttribute(21, "class", "nav-item px-3");
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(23);
                __builder2.AddAttribute(24, "class", "nav-link");
                __builder2.AddAttribute(25, "href", "");
                __builder2.AddAttribute(26, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 14 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(28, "\r\n                <span class=\"oi oi-cog\" aria-hidden=\"true\"></span> Gestionar tesoros\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenElement(31, "li");
                __builder2.AddAttribute(32, "class", "nav-item px-3");
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(34);
                __builder2.AddAttribute(35, "class", "nav-link");
                __builder2.AddAttribute(36, "href", "mapa");
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(38, "\r\n                <span class=\"oi oi-map\" aria-hidden=\"true\"></span> Mapa\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\r\n    \r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
