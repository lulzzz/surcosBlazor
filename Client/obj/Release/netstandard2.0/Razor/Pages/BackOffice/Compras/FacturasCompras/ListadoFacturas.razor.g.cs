#pragma checksum "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69f44d081553eb04c3d6d3e4cf9b504ef534bfc0"
// <auto-generated/>
#pragma warning disable 1591
namespace SurcosBlazor.Client.Pages.BackOffice.Compras.FacturasCompras
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
#line 4 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
           [Authorize(Roles = "Admin, Administrativo")]

#line default
#line hidden
#line 10 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
           [Authorize(Roles = "Admin, Compras")]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(BackOfficeLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/BackOffice/Compras/ListadoComprobantes")]
    public partial class ListadoFacturas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "aria-label", "breadcrumb");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "ol");
            __builder.AddAttribute(4, "class", "breadcrumb");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "li");
            __builder.AddAttribute(7, "class", "breadcrumb-item");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 14 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
                                                ()=>uri.NavigateTo("BackOffice/Compras")

#line default
#line hidden
            ));
            __builder.AddContent(9, "Compras");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "li");
            __builder.AddAttribute(12, "class", "breadcrumb-item active");
            __builder.AddAttribute(13, "aria-current", "page");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 15 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
                                                                           ()=>uri.NavigateTo("BackOffice/Compras/ListadoComprobantes")

#line default
#line hidden
            ));
            __builder.AddContent(15, "Listado Comprobantes");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", true);
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "d-flex justify-content-between");
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "h3");
            __builder.AddContent(26, "Facturas ");
            __builder.AddContent(27, 
#line 20 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
                       facturas != null ? $"({registrosTotales})": ""

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "d-flex");
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "btn btn-sm btn-olive mx-2");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 22 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
                                                             (()=>ModalToggle("filtros"))

#line default
#line hidden
            ));
            __builder.AddMarkupContent(35, "<i class=\"fas fa-filter mr-1\"></i>Filtros");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "btn btn-sm btn-olive");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 23 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
                                                        (()=>uri.NavigateTo("BackOffice/Compras/ComprobanteCompras"))

#line default
#line hidden
            ));
            __builder.AddContent(40, "Nuevo Comprobante");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __Blazor.SurcosBlazor.Client.Pages.BackOffice.Compras.FacturasCompras.ListadoFacturas.TypeInference.CreateListadoGenerico_0(__builder, 44, 45, 
#line 27 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
                              facturas

#line default
#line hidden
            , 46, (__builder2) => {
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "facturas my-2");
                __builder2.AddMarkupContent(50, "\r\n                ");
                __builder2.OpenElement(51, "table");
                __builder2.AddAttribute(52, "class", "table table-sm d-xs-block");
                __builder2.AddAttribute(53, "style", "overflow-x:auto;");
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.AddMarkupContent(55, "<tr>\r\n                        <th>Fecha</th>\r\n\r\n                        <th>Comprobante</th>\r\n                        <th>Proveedor</th>\r\n                        <th>Total</th>\r\n                        <th>Estado</th>\r\n                    </tr>\r\n\r\n");
#line 40 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
                     foreach (FacturaCompras factura in facturas)
                    {


#line default
#line hidden
                __builder2.AddContent(56, "                        ");
                __builder2.OpenElement(57, "tr");
                __builder2.AddAttribute(58, "class", "factura trSeleccionable");
                __builder2.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 43 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
                                                                        ()=>uri.NavigateTo($"/BackOffice/Compras/ComprobanteCompras/{factura.Id}")

#line default
#line hidden
                ));
                __builder2.AddMarkupContent(60, "\r\n                            ");
                __builder2.OpenElement(61, "td");
                __builder2.AddAttribute(62, "class", "fecha");
                __builder2.AddContent(63, 
#line 44 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
                                                factura.fecha.ToString("dd/MM HH:mm")

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n\r\n                            ");
                __builder2.OpenElement(65, "td");
                __builder2.AddAttribute(66, "class", "nombre");
                __builder2.AddContent(67, 
#line 46 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
                                                factura.TipoComprobante.nombre

#line default
#line hidden
                );
                __builder2.AddContent(68, " ");
                __builder2.AddContent(69, 
#line 46 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
                                                                                factura.codigo

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n\r\n                            ");
                __builder2.OpenElement(71, "td");
                __builder2.AddAttribute(72, "class", "nombre");
                __builder2.AddContent(73, 
#line 48 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
                                                 factura.Proveedor.razonSocial

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                            ");
                __builder2.OpenElement(75, "td");
                __builder2.AddAttribute(76, "class", "total");
                __builder2.AddContent(77, "$");
                __builder2.AddContent(78, 
#line 49 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
                                                 factura.totalComprobante

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n                            ");
                __builder2.OpenElement(80, "td");
                __builder2.AddAttribute(81, "class", "estado");
                __builder2.OpenElement(82, "strong");
                __builder2.AddContent(83, 
#line 50 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
                                                         factura.EstadoFactura.nombre

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n");
#line 52 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
                    }

#line default
#line hidden
                __builder2.AddContent(86, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                ");
                __builder2.OpenComponent<SurcosBlazor.Client.Shared.PaginacionComp>(88);
                __builder2.AddAttribute(89, "PaginaActual", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 54 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
                                              paginaActual

#line default
#line hidden
                ));
                __builder2.AddAttribute(90, "PaginasTotales", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 55 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
                                                paginasTotales

#line default
#line hidden
                ));
                __builder2.AddAttribute(91, "PaginaSeleccionada", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#line 56 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
                                                    paginaSeleccionada

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n        ");
            }
            );
            __builder.AddMarkupContent(94, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
            __builder.OpenComponent<SurcosBlazor.Client.Shared.Modal>(96);
            __builder.AddAttribute(97, "modalTitulo", "Filtros");
            __builder.AddAttribute(98, "modalTamaño", "modal-md");
            __builder.AddAttribute(99, "modalId", "filtros");
            __builder.AddAttribute(100, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(101, "\r\n    ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "filtros my-3");
                __builder2.AddMarkupContent(104, "\r\n\r\n\r\n\r\n\r\n        ");
                __Blazor.SurcosBlazor.Client.Pages.BackOffice.Compras.FacturasCompras.ListadoFacturas.TypeInference.CreateListadoGenerico_1(__builder2, 105, 106, 
#line 69 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
                                  facturas

#line default
#line hidden
                , 107, (__builder3) => {
                    __builder3.AddMarkupContent(108, "\r\n                ");
                    __builder3.OpenElement(109, "div");
                    __builder3.AddAttribute(110, "class", "col-md-12 mx-0 px-0 my-2");
                    __builder3.AddMarkupContent(111, "\r\n                    ");
                    __builder3.AddMarkupContent(112, "<span class=\"col-md-12 mx-0 px-0\">Cantidad de registros a mostrar</span>\r\n                    ");
                    __builder3.OpenElement(113, "select");
                    __builder3.AddAttribute(114, "class", "col-md-12");
                    __builder3.AddAttribute(115, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 73 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
                                                           async (ChangeEventArgs e)=> { cantidadDeRegistrosAMostrar = Convert.ToInt32(e.Value.ToString());   }

#line default
#line hidden
                    ));
                    __builder3.AddMarkupContent(116, "\r\n                        ");
                    __builder3.OpenElement(117, "option");
                    __builder3.AddAttribute(118, "value", "10");
                    __builder3.AddContent(119, "10");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(120, "\r\n                        ");
                    __builder3.OpenElement(121, "option");
                    __builder3.AddAttribute(122, "selected", true);
                    __builder3.AddAttribute(123, "value", "25");
                    __builder3.AddContent(124, "25");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(125, "\r\n                        ");
                    __builder3.OpenElement(126, "option");
                    __builder3.AddAttribute(127, "value", "50");
                    __builder3.AddContent(128, "50");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(129, "\r\n                        ");
                    __builder3.OpenElement(130, "option");
                    __builder3.AddAttribute(131, "value", "100");
                    __builder3.AddContent(132, "100");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(133, "\r\n\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(134, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(135, "\r\n            ");
                }
                );
                __builder2.AddMarkupContent(136, "\r\n        ");
                __builder2.AddMarkupContent(137, @"<div class=""fechaFactura col-md-12 row mx-0 px-0 border-top"">
            <h6 class=""col-md-12 mx-0 px-0 my-2"">Fecha FacturaCompras <input type=""checkbox""></h6>
            <div class=""col-md-6 ml-0 pl-0"">

                <div class=""col-md-12 row mx-0 px-0"">
                    <span>Desde</span>
                </div>

                <input class=""col-md-12 row mx-0 px-0"" type=""date"">
            </div>

            <div class=""col-md-6 "">
                <div class=""col-md-12 row mx-0 px-0"">
                    <span>Hasta</span>
                </div>
                <input class=""col-md-12 row mx-0 px-0"" type=""date"">
            </div>
        </div>


        ");
                __builder2.AddMarkupContent(138, @"<div class=""fechaEntrega col-md-12 row mx-0 px-0 my-2 border-top"">
            <h6 class=""col-md-12 mx-0 px-0"">Fecha Entrega <input type=""checkbox""></h6>

            <div class=""col-md-6 ml-0 pl-0"">
                <div class=""col-md-12 row mx-0 px-0"">
                    <span>Desde</span>
                </div>
                <input class=""col-md-12 row mx-0 px-0"" type=""date"">
            </div>
            <div class=""col-md-6 "">
                <div class=""col-md-12 row mx-0 px-0"">
                    <span>Hasta</span>
                </div>
                <input class=""col-md-12 row mx-0 px-0"" type=""date"">
            </div>
        </div>
    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n    ");
                __builder2.OpenElement(140, "div");
                __builder2.AddAttribute(141, "class", "btn btn-sm btn-block btn-olive my-4");
                __builder2.AddAttribute(142, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 120 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
                                                                 async()=> { await ListarFacturas(); await ModalToggle("filtros"); }

#line default
#line hidden
                ));
                __builder2.AddContent(143, "Aplicar Filtros");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(144, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 122 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Compras\FacturasCompras\ListadoFacturas.razor"
       
    public List<FacturaCompras> facturas { get; set; }
    private int paginaActual = 1;
    private int paginasTotales;
    private HttpResponseWrapper<List<FacturaCompras>> responseHttp;
    public List<EstadoFactura> estadosFactura { get; set; }

    public int estadoFacturaIdFiltro { get; set; }
    public int depositoIdFiltro { get; set; }
    public int TipoComprobanteIdFiltro { get; set; }

    public int cantidadDeRegistrosAMostrar { get; set; } = 25;
    public int registrosTotales { get; set; }
    protected override async Task OnInitializedAsync()
    {


        await ListarFacturas();
        estadosFactura = facturas.Select(x => x.EstadoFactura).Where(y => y != null && y.nombre != null && y.Id != 0).Distinct().ToList();


    }

    public async Task ListarFacturas()
    {
        responseHttp = await repositorio.Get<List<FacturaCompras>>($"api/facturaCompra?pagina={paginaActual}&cantidadDeRegistros={cantidadDeRegistrosAMostrar}&estadoFacturaId={estadoFacturaIdFiltro}");
        if (!responseHttp.Error)
        {
            facturas = responseHttp.Response;

            registrosTotales = int.Parse(responseHttp.HttpResponseMessage.Headers.GetValues("conteo").FirstOrDefault());

            paginasTotales = int.Parse(responseHttp.HttpResponseMessage.Headers.GetValues("totalPaginas").FirstOrDefault());

        }


    }
    private async Task paginaSeleccionada(int pagina)
    {
        paginaActual = pagina;
        await ListarFacturas();
    }

    public async Task ModalToggle(string id)
    {
        await js.InvokeVoidAsync("ModalToggle", id);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uri { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authStateProvider { get; set; }
    }
}
namespace __Blazor.SurcosBlazor.Client.Pages.BackOffice.Compras.FacturasCompras.ListadoFacturas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateListadoGenerico_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<T> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::SurcosBlazor.Client.Shared.ListadoGenerico<T>>(seq);
        __builder.AddAttribute(__seq0, "listado", __arg0);
        __builder.AddAttribute(__seq1, "HayRegistros", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateListadoGenerico_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<T> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::SurcosBlazor.Client.Shared.ListadoGenerico<T>>(seq);
        __builder.AddAttribute(__seq0, "listado", __arg0);
        __builder.AddAttribute(__seq1, "HayRegistros", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
