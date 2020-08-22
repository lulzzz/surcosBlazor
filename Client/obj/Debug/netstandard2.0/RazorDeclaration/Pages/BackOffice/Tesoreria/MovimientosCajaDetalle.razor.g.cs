#pragma checksum "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\MovimientosCajaDetalle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c054c30bbd5d4e5002dcf83b1bb8d1d265bc361"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SurcosBlazor.Client.Pages.BackOffice.Tesoreria
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
#line 6 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\MovimientosCajaDetalle.razor"
           [Authorize(Roles = "Admin, Logistica, Administrativo")]

#line default
#line hidden
#line 8 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\MovimientosCajaDetalle.razor"
           [Authorize(Roles = "Admin, Tesoreria")]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(BackOfficeLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/BackOffice/Tesoreria/MovimientosCaja/{cajaId:int}")]
    public partial class MovimientosCajaDetalle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 105 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\MovimientosCajaDetalle.razor"
       
    [Parameter] public int? cajaId { get; set; }

    public List<Deposito> depositos { get; set; }
    public List<ProductoPresentacion> productosPresentacion { get; set; }
    public Deposito deposito { get; set; }
    public ProductoPresentacion productoPresentacion { get; set; }
    public Caja caja { get; set; }
    public MovimientoCaja movimientoCaja { get; set; }
    private int paginaActual = 1;
    private int paginasTotales;
    private HttpResponseWrapper<List<MovimientoCaja>> responseHttp;
    public System.Security.Claims.ClaimsPrincipal User { get; set; }
    public string userName { get; set; }

    private async Task paginaSeleccionada(int pagina)
    {
        paginaActual = pagina;
        await ListarMovimientosCaja(pagina);
    }
    public async Task ListarMovimientosCaja(int pagina = 1)
    {
        responseHttp = await repositorio.Get<List<MovimientoCaja>>($"api/movimientoCaja?cajaId={caja.Id}&pagina={pagina}&cantidadDeRegistros=30");
        if (!responseHttp.Error)
        {
            caja.MovimientosCaja = responseHttp.Response;

            var conteo = responseHttp.HttpResponseMessage.Headers.GetValues("conteo").FirstOrDefault();

            paginasTotales = int.Parse(responseHttp.HttpResponseMessage.Headers.GetValues("totalPaginas").FirstOrDefault());

        }



    }

    protected override async Task OnParametersSetAsync()
    {
        var authState = await authStateProvider.GetAuthenticationStateAsync();
        User = authState.User;
        userName = User.Identity.Name;

        await BuscarCaja();

    }


    public async Task BuscarCaja()
    {
        if (cajaId != 0 && cajaId != null)
        {

            caja = await http.GetJsonAsync<Caja>($"api/caja/{cajaId}");
            paginaActual = 1;
            await ListarMovimientosCaja(paginaActual);
            movimientoCaja = new MovimientoCaja { Caja = caja, CajaId = caja.Id };
        }
    }


    public async Task ToggleModal(string id)
    {

        await js.InvokeAsync<object>("ModalToggle", id);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uri { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591