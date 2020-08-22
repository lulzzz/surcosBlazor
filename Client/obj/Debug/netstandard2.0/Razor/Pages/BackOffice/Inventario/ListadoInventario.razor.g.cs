#pragma checksum "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c1ec3d95375479e4178c442178dc78f95cbc39e"
// <auto-generated/>
#pragma warning disable 1591
namespace SurcosBlazor.Client.Pages.BackOffice.Inventario
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
#line 4 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"
           [Authorize(Roles = "Admin, Inventario")]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(BackOfficeLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/BackOffice/Inventario/Listado")]
    public partial class ListadoInventario : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "aria-label", "breadcrumb");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenElement(3, "ol");
            __builder.AddAttribute(4, "class", "breadcrumb");
            __builder.AddMarkupContent(5, "\r\n            ");
            __builder.OpenElement(6, "li");
            __builder.AddAttribute(7, "class", "breadcrumb-item");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 11 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"
                                                    ()=>uri.NavigateTo("/BackOffice/Inventario")

#line default
#line hidden
            ));
            __builder.AddContent(9, "Invetario");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "li");
            __builder.AddAttribute(12, "class", "breadcrumb-item active");
            __builder.AddAttribute(13, "aria-current", "page");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 12 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"
                                                                               ()=>uri.NavigateTo("/BackOffice/Inventario/Listado")

#line default
#line hidden
            ));
            __builder.AddContent(15, "Listado Inventarios");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.AddMarkupContent(19, "<h3>Listado Inventario</h3>\r\n\r\n");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "mt-2 d-flex row col-md-12 mx-0 p-3 my-3 align-items-center justify-content-between");
            __builder.AddAttribute(22, "style", "box-shadow:1px 1px 3px #323232");
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-md-3");
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenComponent<SurcosBlazor.Client.Shared.SelectGenerico<Deposito>>(27);
            __builder.AddAttribute(28, "TList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Deposito>>(
#line 19 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"
                               depositos

#line default
#line hidden
            ));
            __builder.AddAttribute(29, "Label", "Deposito");
            __builder.AddAttribute(30, "TItemActual", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Deposito>(
#line 19 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"
                                                                                                        deposito

#line default
#line hidden
            ));
            __builder.AddAttribute(31, "SelectItem", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Deposito>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Deposito>(this, 
#line 20 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"
                                      async(Deposito deposito)=> { this.deposito = deposito; await ListarInventarios(1); }

#line default
#line hidden
            )));
            __builder.AddAttribute(32, "TTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Deposito>)((Deposito) => (__builder2) => {
                __builder2.AddContent(33, 
#line 21 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"
                        Deposito.nombre

#line default
#line hidden
                );
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "col-md-3");
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.AddMarkupContent(39, "<label class=\"col-md-12 mx-0 px-0\"><strong>Nombre Producto</strong></label>\r\n        ");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "class", "form-control");
            __builder.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 26 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"
                                           filtro

#line default
#line hidden
            ));
            __builder.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filtro = __value, filtro));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col-md-2 mx-0 px-0");
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "btn btn-sm btn-info");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 29 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"
                                                     async ()=> await ListarInventarios(1)

#line default
#line hidden
            ));
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.AddMarkupContent(53, "<span><i class=\"fas fa-search mr-1\"></i>BUSCAR</span>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n");
#line 35 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"
 if (deposito != null)
{

#line default
#line hidden
            __builder.AddContent(57, "    ");
            __builder.OpenElement(58, "table");
            __builder.AddAttribute(59, "class", "table table-sm");
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.AddMarkupContent(61, "<thead>\r\n            <tr>\r\n                <td>Producto</td>\r\n                <td>En existencia</td>\r\n                <td>Ver Movimientos</td>\r\n            </tr>\r\n\r\n\r\n        </thead>\r\n        ");
            __builder.OpenElement(62, "tbody");
            __builder.AddMarkupContent(63, "\r\n");
#line 48 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"
             foreach (Inventario inventario in inventarios)
            {

#line default
#line hidden
            __builder.AddContent(64, "                ");
            __builder.OpenElement(65, "tr");
            __builder.AddMarkupContent(66, "\r\n                    ");
            __builder.OpenElement(67, "td");
            __builder.AddMarkupContent(68, "\r\n\r\n                        ");
            __builder.AddContent(69, 
#line 53 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"
                         inventario.ProductoPresentacion?.Producto?.nombre

#line default
#line hidden
            );
            __builder.AddContent(70, ", ");
            __builder.AddContent(71, 
#line 53 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"
                                                                             inventario.ProductoPresentacion?.PresentacionProducto?.nombre

#line default
#line hidden
            );
            __builder.AddMarkupContent(72, "\r\n");
#line 54 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"
                         if (inventario.cantidadUnidadesEnExistencia < inventario.ProductoPresentacion.cantidadStockMinima)
                        {

#line default
#line hidden
            __builder.AddContent(73, "                            ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "badge badge-danger");
            __builder.AddContent(76, "[ALERTA] Stock menor a ");
            __builder.AddContent(77, 
#line 56 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"
                                                                                    inventario.ProductoPresentacion.cantidadStockMinima

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
#line 57 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"
                        }

#line default
#line hidden
            __builder.AddContent(79, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.OpenElement(81, "td");
            __builder.AddContent(82, 
#line 59 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"
                         inventario.cantidadUnidadesEnExistencia

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                    ");
            __builder.OpenElement(84, "td");
            __builder.AddMarkupContent(85, "\r\n                        ");
            __builder.OpenElement(86, "a");
            __builder.AddAttribute(87, "class", "btn");
            __builder.AddAttribute(88, "href", 
#line 61 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"
                                               $"/BackOffice/Inventario/MovimientoInventario/{inventario.Id}"

#line default
#line hidden
            );
            __builder.AddMarkupContent(89, " <i class=\"far fa-eye\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n");
#line 65 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"
            }

#line default
#line hidden
            __builder.AddContent(93, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n    ");
            __builder.OpenComponent<SurcosBlazor.Client.Shared.PaginacionComp>(96);
            __builder.AddAttribute(97, "PaginaActual", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 68 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"
                                  paginaActual

#line default
#line hidden
            ));
            __builder.AddAttribute(98, "PaginaSeleccionada", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#line 68 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"
                                                                    paginaSeleccionada

#line default
#line hidden
            )));
            __builder.AddAttribute(99, "PaginasTotales", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 68 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"
                                                                                                        paginasTotales

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(100, "\r\n");
#line 69 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"

}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 72 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Inventario\ListadoInventario.razor"
       
    public List<Deposito> depositos { get; set; }
    public Deposito deposito { get; set; }
    public List<Inventario> inventarios { get; set; } = new List<Inventario>();
    public TablaGenerica<Inventario> tablaGenerica { get; set; }
    public string filtro { get; set; }
    public string userName { get; set; }
    public System.Security.Claims.ClaimsPrincipal User { get; set; }
    private int paginaActual = 1;
    private int paginasTotales;
    private HttpResponseWrapper<List<Inventario>> responseHttp;

    protected override async Task OnInitializedAsync()
    {
        var authState = await authStateProvider.GetAuthenticationStateAsync();
        User = authState.User;
        userName = User.Identity.Name;
        await ListarDepositos();

    }


    public async Task ListarInventarios(int pagina = 1)
    {
        responseHttp = await repositorio.Get<List<Inventario>>($"api/inventario/InventarioPorDeposito?depositoId={deposito.Id}&filtro={filtro}&pagina={pagina}&cantidadDeRegistros=50");
        if (!responseHttp.Error)
        {
            inventarios = responseHttp.Response;

            var conteo = responseHttp.HttpResponseMessage.Headers.GetValues("conteo").FirstOrDefault();

            paginasTotales = int.Parse(responseHttp.HttpResponseMessage.Headers.GetValues("totalPaginas").FirstOrDefault());

        }



    }

    public async Task ListarDepositos()
    {
        depositos = await http.GetJsonAsync<List<Deposito>>($"api/deposito/depositosHabilitados?userName={userName}");
    }


    private async Task paginaSeleccionada(int pagina)
    {
        paginaActual = pagina;
        await ListarInventarios(pagina);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uri { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
