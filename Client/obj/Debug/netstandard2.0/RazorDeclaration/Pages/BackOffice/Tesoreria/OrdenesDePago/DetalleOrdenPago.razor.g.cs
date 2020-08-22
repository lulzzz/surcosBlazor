#pragma checksum "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\OrdenesDePago\DetalleOrdenPago.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7815af90fb5840e00a446d667e0e1aba5371bef"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SurcosBlazor.Client.Pages.BackOffice.Tesoreria.OrdenesDePago
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\agust\source\repos\SurcosBlazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\agust\source\repos\SurcosBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\agust\source\repos\SurcosBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\agust\source\repos\SurcosBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\agust\source\repos\SurcosBlazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\agust\source\repos\SurcosBlazor\Client\_Imports.razor"
using SurcosBlazor.Client;

#line default
#line hidden
#line 7 "C:\Users\agust\source\repos\SurcosBlazor\Client\_Imports.razor"
using SurcosBlazor.Client.Shared;

#line default
#line hidden
#line 9 "C:\Users\agust\source\repos\SurcosBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 10 "C:\Users\agust\source\repos\SurcosBlazor\Client\_Imports.razor"
using SurcosBlazor.Client.Helpers;

#line default
#line hidden
#line 11 "C:\Users\agust\source\repos\SurcosBlazor\Client\_Imports.razor"
using SurcosBlazor.Shared.Entidades;

#line default
#line hidden
#line 12 "C:\Users\agust\source\repos\SurcosBlazor\Client\_Imports.razor"
using SurcosBlazor.Shared;

#line default
#line hidden
#line 13 "C:\Users\agust\source\repos\SurcosBlazor\Client\_Imports.razor"
using SurcosBlazor.Client.Repositorio;

#line default
#line hidden
#line 14 "C:\Users\agust\source\repos\SurcosBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 15 "C:\Users\agust\source\repos\SurcosBlazor\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#line 16 "C:\Users\agust\source\repos\SurcosBlazor\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#line 9 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\OrdenesDePago\DetalleOrdenPago.razor"
           [Authorize(Roles = "Admin, Tesoreria")]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(BackOfficeLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/BackOffice/Tesoreria/DetalleOrdenPago/{Id:int}")]
    public partial class DetalleOrdenPago : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 133 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\OrdenesDePago\DetalleOrdenPago.razor"
       
    public OrdenPago ordenPago { get; set; }
    [Parameter] public int Id { get; set; }
    public bool cargando { get; set; }
    protected override async Task OnInitializedAsync()
    {
        if (Id != 0)
        {
            ordenPago = await http.GetJsonAsync<OrdenPago>($"api/ordenpago/{Id}");
        }
        else
        {
            ordenPago = await http.GetJsonAsync<OrdenPago>($"api/ordenpago/0");
        }

    }

    public async Task eliminar()
    {

        var respuesta = await repositorio.Delete($"api/OrdenPago/{ordenPago.Id}");
        cargando = false;
        await ToggleModal("eliminarConfirm");
        

#line default
#line hidden
#line 156 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\OrdenesDePago\DetalleOrdenPago.razor"
         if (!respuesta.Error)
        {

            uri.NavigateTo("/BackOffice/Tesoreria");
            toastService.ShowSuccess("Se eliminó correctamente");
        }
        else
        {

            toastService.ShowError(respuesta.HttpResponseMessage.Content.ReadAsStringAsync().Result);

        }

#line default
#line hidden
#line 167 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\OrdenesDePago\DetalleOrdenPago.razor"
         

    }


    public async Task ToggleModal(string id)
    {
        await js.InvokeVoidAsync("ModalToggle", id);
    }



#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uri { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
