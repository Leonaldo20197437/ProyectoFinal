#pragma checksum "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\Componentes\Principal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c708992153d33480becc7efdbd3d3fd29a10287"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea6_7.Componentes
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
#nullable restore
#line 1 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\Componentes\Principal.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\Componentes\Principal.razor"
using Tarea6_7.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\Componentes\Principal.razor"
using Tarea6_7.Componentes;

#line default
#line hidden
#nullable disable
    public partial class Principal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "p-2 w-100");
            __builder.AddAttribute(2, "style", "background-color:" + " " + (
#nullable restore
#line 8 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\Componentes\Principal.razor"
                                                 bColor

#line default
#line hidden
#nullable disable
            ) + ";" + " border-radius:" + " 5px;");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "p-2 d-flex");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-4 mr-3 p-3");
            __builder.AddAttribute(9, "style", "background-color: white;");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenComponent<Tarea6_7.Componentes.AgregarTesoros>(11);
            __builder.AddAttribute(12, "UsuarioId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Guid>(
#nullable restore
#line 11 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\Componentes\Principal.razor"
                                        UsuariosId

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "w-100");
            __builder.AddAttribute(17, "style", "background-color: white;");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenComponent<Tarea6_7.Componentes.VerTesoros>(19);
            __builder.AddAttribute(20, "UsuarioId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Guid>(
#nullable restore
#line 14 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\Componentes\Principal.razor"
                                    UsuariosId

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\Componentes\Principal.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    private string bColor = "#ffffff";
    private Usuario usuario = new Usuario();
    private Guid UsuariosId;

    protected override async Task OnInitializedAsync(){
        var authState = await authenticationStateTask;
        usuario = await UserManager.GetUserAsync(authState.User);
        UsuariosId = usuario.UsuarioId;
        bColor = usuario.Color;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<Usuario> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<Usuario> SignInManager { get; set; }
    }
}
#pragma warning restore 1591
