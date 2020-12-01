#pragma checksum "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\Componentes\Mapa.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c30e80099e02527a7c7b805ed82f1d9013b8db6"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\Componentes\Mapa.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\Componentes\Mapa.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\Componentes\Mapa.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\Componentes\Mapa.razor"
using Servicios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\Componentes\Mapa.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\Componentes\Mapa.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
    public partial class Mapa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Ozuna Taveras\Desktop\Tarea6_7\Componentes\Mapa.razor"
       
    [Parameter]
    public string TID {get; set;}

    List<Coordenadas> coordenadas;
    List<Tesoros> tesoros;
   
    protected override async Task OnAfterRenderAsync(bool firstRender){
        if (firstRender){
            if(TID != null)
            await Load();
        }
    }

    //protected override async void OnParametersSet(){ }

    private async Task Load(){
        if(TID != null && TID != ""){
            coordenadas = await TS.GetAllCoordenadas(Guid.Parse(TID));
            tesoros = await TS.GetAllTesoros(Guid.Parse(TID));
            string json = JsonSerializer.Serialize(coordenadas.ToArray());
            string TJson = JsonSerializer.Serialize(tesoros.ToArray());
            await runtime.InvokeVoidAsync("initMap", json, 8, TJson);
        }else{
            await runtime.InvokeVoidAsync("initMap");
        }

    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime runtime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioTesoros TS { get; set; }
    }
}
#pragma warning restore 1591