#pragma checksum "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Ventas\Pedido\ListadoPedidos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f7add8e7322680dc5a0107f048a485d6be2d079"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SurcosBlazor.Client.Pages.BackOffice.Ventas.Pedido
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
#line 4 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Ventas\Pedido\ListadoPedidos.razor"
           [Authorize(Roles = "Admin, Ventas")]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(BackOfficeLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/BackOffice/Ventas/ListadoPedidos")]
    public partial class ListadoPedidos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 213 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Ventas\Pedido\ListadoPedidos.razor"
       
    public List<Pedido> pedidos { get; set; }
    private int paginaActual = 1;
    private int paginasTotales;
    private HttpResponseWrapper<List<Pedido>> responseHttp;
    public List<Vendedor> vendedores { get; set; }
    public List<Provincia> provincias { get; set; }
    public List<EstadoPedido> estadosPedidoFiltro { get; set; }
    public List<EstadoPedido> estadosPedido { get; set; }
    public bool modoAdmin { get; set; }
    public List<TipoListaPrecio> tiposListaPrecio { get; set; }

    public string userName { get; set; }
    public int vendedorIdFiltro { get; set; }
    public int provinciaIdFiltro { get; set; }
    public int estadoPedidoIdFiltro { get; set; }
    public int tipoListaPrecioIdFiltro { get; set; }
    public int cantidadDeRegistrosAMostrar { get; set; } = 25;
    public int registrosTotales { get; set; }
    protected override async Task OnInitializedAsync()
    {

        var authState = await authStateProvider.GetAuthenticationStateAsync();
        userName = authState.User.Identity.Name;
        await ListarPedidos();
        await ListarVendedores();
        provincias = pedidos.Select(x => x.Domicilio.Provincia).Where(y => y != null && y.nombre != null && y.Id != 0).Distinct().ToList();
        estadosPedidoFiltro = pedidos.Select(x => x.EstadoPedido).Where(y => y != null && y.nombre != null && y.Id != 0).Distinct().ToList();
        estadosPedido = await http.GetJsonAsync<List<EstadoPedido>>("api/estadopedido");
        tiposListaPrecio = pedidos.Select(x => x.ListaPrecios.TipoListaPrecio).Where(y => y != null && y.nombre != null && y.Id != 0).Distinct().ToList();

    }
    public async Task ListarVendedores()
    {
        var respuesta = await repositorio.Get<List<Vendedor>>($"api/pedido/vendedoresHabilitados?userName={userName}");
        if (!respuesta.Error)
        {
            vendedores = respuesta.Response;
        }
        else
        {
            toastService.ShowError(await respuesta.HttpResponseMessage.Content.ReadAsStringAsync());
        }
    }
    public async Task ListarPedidos()
    {
        responseHttp = await repositorio.Get<List<Pedido>>($"api/pedido?pagina={paginaActual}&cantidadDeRegistros={cantidadDeRegistrosAMostrar}&userName={userName}&vendedorId={vendedorIdFiltro}&provinciaId={provinciaIdFiltro}&estadoPedidoId={estadoPedidoIdFiltro}&tipoListaPrecioId={tipoListaPrecioIdFiltro}");
        if (!responseHttp.Error)
        {
            pedidos = responseHttp.Response;

            registrosTotales = int.Parse(responseHttp.HttpResponseMessage.Headers.GetValues("conteo").FirstOrDefault());

            paginasTotales = int.Parse(responseHttp.HttpResponseMessage.Headers.GetValues("totalPaginas").FirstOrDefault());

        }


    }
    private async Task paginaSeleccionada(int pagina)
    {
        paginaActual = pagina;
        pedidos = null;
        await ListarPedidos();
    }

    public async Task ModalToggle(string id)
    {
        await js.InvokeVoidAsync("ModalToggle", id);
    }

    public async Task CambiarEstadoPedido(int pedidoId, int estadoId)
    {

        await http.GetAsync($"api/pedido/CambiarEstadoPedido?pedidoId={pedidoId}&estadoId={estadoId}");
        toastService.ShowSuccess("Se cambió el estado correctamente");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uri { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authStateProvider { get; set; }
    }
}
#pragma warning restore 1591
