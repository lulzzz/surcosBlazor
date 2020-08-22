#pragma checksum "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2b0ede8a643b81f9acfa1aa6f6e1dc3e3269e39"
// <auto-generated/>
#pragma warning disable 1591
namespace SurcosBlazor.Client.Pages.BackOffice.GerenciaC
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
#line 4 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
using SurcosBlazor.Shared.Entidades.Informes.InformesVentas;

#line default
#line hidden
    public partial class InformesVenta : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-light mb-4 col-md-12 mx-0 px-0 py-3");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-12 row d-flex mx-0 px-0");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-2 mx-2 form-group");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<label>Desde</label>\r\n            ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "class", "form-control ");
            __builder.AddAttribute(12, "value", 
#line 10 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                                                 fechaDesde.ToString("yyyy-MM-dd")

#line default
#line hidden
            );
            __builder.AddAttribute(13, "type", "date");
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 10 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                                                                                                             (ChangeEventArgs e)=> { fechaDesde = Convert.ToDateTime(e.Value); this.StateHasChanged(); }

#line default
#line hidden
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-md-2 mx-2  form-group");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.AddMarkupContent(20, "<label>Hasta</label>\r\n            ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "value", 
#line 15 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                                                fechaHasta.ToString("yyyy-MM-dd")

#line default
#line hidden
            );
            __builder.AddAttribute(24, "type", "date");
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 15 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                                                                                                            (ChangeEventArgs e)=> { fechaHasta = Convert.ToDateTime(e.Value);this.StateHasChanged(); }

#line default
#line hidden
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-md-3 mx-2");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col-md-12 row mx-0 px-0 align-items-center");
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-md-10");
            __builder.AddMarkupContent(36, "\r\n                    ");
            __Blazor.SurcosBlazor.Client.Pages.BackOffice.GerenciaC.InformesVenta.TypeInference.CreateSelectGenerico_0(__builder, 37, 38, "Vendedor", 39, 
#line 21 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                                                                               vendedores

#line default
#line hidden
            , 40, 
#line 21 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                                                                                                        vendedor

#line default
#line hidden
            , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 21 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                                                                                                                              (Vendedor vendedor) => { this.vendedor = vendedor; }

#line default
#line hidden
            ), 42, "- Todos los vendedores -", 43, (vendedor) => (__builder2) => {
                __builder2.AddContent(44, 
#line 22 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                                    vendedor.nombre

#line default
#line hidden
                );
            }
            );
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "col-md-1");
            __builder.AddMarkupContent(49, "\r\n");
#line 26 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                     if (vendedor != null)
                    {

#line default
#line hidden
            __builder.AddContent(50, "                        ");
            __builder.OpenElement(51, "div");
            __builder.OpenElement(52, "i");
            __builder.AddAttribute(53, "class", "fas fa-times text-danger");
            __builder.AddAttribute(54, "style", "cursor:pointer");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 28 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                                                                                                    ()=>this.vendedor = null

#line default
#line hidden
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#line 29 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"

                    }

#line default
#line hidden
            __builder.AddContent(57, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "col-md-3 mx-2");
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "col-md-12 row mx-0 px-0 align-items-center");
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "col-md-10");
            __builder.AddMarkupContent(69, "\r\n                    ");
            __Blazor.SurcosBlazor.Client.Pages.BackOffice.GerenciaC.InformesVenta.TypeInference.CreateSelectGenerico_1(__builder, 70, 71, "Provincia", 72, 
#line 39 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                                                                                 provincias

#line default
#line hidden
            , 73, 
#line 39 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                                                                                                          provincia

#line default
#line hidden
            , 74, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 39 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                                                                                                                                 (Provincia provincia) => { this.provincia = provincia; }

#line default
#line hidden
            ), 75, "- Todas las provincias -", 76, (provincia) => (__builder2) => {
                __builder2.AddContent(77, 
#line 40 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                                    provincia.nombre

#line default
#line hidden
                );
            }
            );
            __builder.AddMarkupContent(78, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "col-md-1");
            __builder.AddMarkupContent(82, "\r\n");
#line 44 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                     if (provincia != null)
                    {

#line default
#line hidden
            __builder.AddContent(83, "                        ");
            __builder.OpenElement(84, "div");
            __builder.OpenElement(85, "i");
            __builder.AddAttribute(86, "class", "fas fa-times text-danger");
            __builder.AddAttribute(87, "style", "cursor:pointer");
            __builder.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 46 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                                                                                                    ()=>this.provincia = null

#line default
#line hidden
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n");
#line 47 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"

                    }

#line default
#line hidden
            __builder.AddContent(90, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n\r\n\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n    ");
            __builder.OpenElement(95, "button");
            __builder.AddAttribute(96, "class", "btn btn-info mx-0 btn-block my-2");
            __builder.AddAttribute(97, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 58 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                                                               armarInforme

#line default
#line hidden
            ));
            __builder.AddContent(98, "INICIAR");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n\r\n\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n\r\n");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "col-md-12 row mx-0 px-0");
            __builder.AddMarkupContent(103, "\r\n\r\n    ");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "col-md-5");
            __builder.AddMarkupContent(106, "\r\n");
#line 67 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
         if (informeVentas != null)
        {

#line default
#line hidden
            __builder.AddContent(107, "            ");
            __builder.AddMarkupContent(108, "<h3>PEDIDOS</h3>\r\n            ");
            __builder.OpenElement(109, "table");
            __builder.AddAttribute(110, "class", "table table-sm");
            __builder.AddMarkupContent(111, "\r\n                ");
            __builder.OpenElement(112, "thead");
            __builder.AddMarkupContent(113, "\r\n                    ");
            __builder.AddMarkupContent(114, @"<tr class=""bg-dark text-white"">
                        <th>PENDIENTES</th>
                        <th>CONFIRMADOS</th>
                        <th>ENTREGADOS</th>
                        <th>CANCELADOS</th>
                    </tr>
                    ");
            __builder.OpenElement(115, "tr");
            __builder.AddMarkupContent(116, "\r\n                        ");
            __builder.OpenElement(117, "th");
            __builder.AddContent(118, 
#line 79 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                             informeVentas.cantidadPEDPEN

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                        ");
            __builder.OpenElement(120, "th");
            __builder.AddContent(121, 
#line 80 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                             informeVentas.cantidadPEDCON

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                        ");
            __builder.OpenElement(123, "th");
            __builder.AddContent(124, 
#line 81 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                             informeVentas.cantidadPEDENT

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n                        ");
            __builder.OpenElement(126, "th");
            __builder.AddContent(127, 
#line 82 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                             informeVentas.cantidadPEDANU

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n            ");
            __builder.AddMarkupContent(132, "<h3>Pedidos por vendedor</h3>\r\n");
#line 88 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
        }

#line default
#line hidden
            __builder.AddMarkupContent(133, "        <div id=\"pedidoPorVendededor\" class style=\"height:500px; width:100%\"></div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n    ");
            __builder.OpenElement(135, "div");
            __builder.AddAttribute(136, "class", "col-md-7");
            __builder.AddMarkupContent(137, "\r\n");
#line 92 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
         if (informeVentas != null)
        {

#line default
#line hidden
            __builder.AddContent(138, "            ");
            __builder.AddMarkupContent(139, "<h3>COMPROBANTES</h3>\r\n");
            __builder.AddContent(140, "            ");
            __builder.OpenElement(141, "table");
            __builder.AddAttribute(142, "class", "table table-sm");
            __builder.AddMarkupContent(143, "\r\n                ");
            __builder.AddMarkupContent(144, @"<thead>
                    <tr class=""bg-dark text-white"">
                        <th>TIPO</th>
                        <th>EMITIDOS</th>
                        <th>TOTAL ($)</th>
                    </tr>
                </thead>
                ");
            __builder.OpenElement(145, "tbody");
            __builder.AddMarkupContent(146, "\r\n                    ");
            __builder.OpenElement(147, "tr");
            __builder.AddMarkupContent(148, "\r\n                        ");
            __builder.AddMarkupContent(149, "<td>FACTURA</td>\r\n                        ");
            __builder.OpenElement(150, "td");
            __builder.AddContent(151, 
#line 107 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                             informeVentas.cantidadFAC

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n                        ");
            __builder.OpenElement(153, "td");
            __builder.AddContent(154, "$");
            __builder.AddContent(155, 
#line 108 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                              informeVentas.totalFAC

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n                    ");
            __builder.OpenElement(158, "tr");
            __builder.AddMarkupContent(159, "\r\n                        ");
            __builder.AddMarkupContent(160, "<td>NOTA DEB.</td>\r\n                        ");
            __builder.OpenElement(161, "td");
            __builder.AddContent(162, 
#line 112 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                             informeVentas.cantidadND

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n                        ");
            __builder.OpenElement(164, "td");
            __builder.AddContent(165, "$");
            __builder.AddContent(166, 
#line 113 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                              informeVentas.totalND

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(167, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n                    ");
            __builder.OpenElement(169, "tr");
            __builder.AddMarkupContent(170, "\r\n                        ");
            __builder.AddMarkupContent(171, "<td>NOTA CRE.</td>\r\n                        ");
            __builder.OpenElement(172, "td");
            __builder.AddContent(173, 
#line 117 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                             informeVentas.cantidadNC

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\r\n                        ");
            __builder.OpenElement(175, "td");
            __builder.AddContent(176, "$");
            __builder.AddContent(177, 
#line 118 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                              informeVentas.totalNC

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(179, "\r\n                    ");
            __builder.OpenElement(180, "tr");
            __builder.AddAttribute(181, "class", "bg-dark text-white");
            __builder.AddMarkupContent(182, "\r\n                        <th colspan=\"2\"></th>\r\n                        ");
            __builder.OpenElement(183, "th");
            __builder.AddContent(184, "TOTAL: $");
            __builder.AddContent(185, 
#line 122 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
                                      informeVentas.totalFAC+ informeVentas.totalND- informeVentas.totalNC

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(187, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(188, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(189, "\r\n");
            __builder.AddContent(190, "            ");
            __builder.AddMarkupContent(191, "<h3>Ventas por Localidad</h3>\r\n");
#line 129 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
        }

#line default
#line hidden
            __builder.AddMarkupContent(192, "        <div id=\"ventasPorZona\" class style=\"height:500px; width:100%\"></div>\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(193, "\r\n\r\n    ");
            __builder.AddMarkupContent(194, @"<div class=""col-md-12 row"">
        <div class=""col-md-6"">
            <h3>Total Vendedido por Lista Precios</h3>

            <div id=""totalVentasPorLista"" class style=""height:500px; width:100%""></div>

        </div>
        <div class=""col-md-6"">
            <h3>Total Ganado por Lista Precios</h3>

            <div id=""totalGanadoPorLista"" class style=""height:500px; width:100%""></div>

        </div>
    </div>
    ");
            __builder.AddMarkupContent(195, "<div class=\"col-md-12\">\r\n        <h3>Evolución Ventas por Lista Precios</h3>\r\n\r\n        <div id=\"ventasPorLista\" class style=\"height:500px; width:100%\"></div>\r\n\r\n    </div>\r\n    ");
            __builder.AddMarkupContent(196, "<div class=\"col-md-12\">\r\n        <h3>Evolución Ganancias por Lista Precios</h3>\r\n\r\n        <div id=\"gananciasPorLista\" class style=\"height:500px; width:100%\"></div>\r\n\r\n    </div>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 162 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\GerenciaC\InformesVenta.razor"
           
        public string userName { get; set; }
        public DateTime fechaDesde { get; set; } = DateTime.Now.AddDays((-1 * DateTime.Now.Day) + 1);
        public DateTime fechaHasta { get; set; } = DateTime.Now;
        public List<Vendedor> vendedores { get; set; } = new List<Vendedor>();
        public List<Provincia> provincias { get; set; } = new List<Provincia>();

        public InformeGeneralVentas informeVentas { get; set; }
        public Provincia provincia { get; set; }
        public Vendedor vendedor { get; set; }
        protected override async Task OnInitializedAsync()
        {

            var authState = await authStateProvider.GetAuthenticationStateAsync();
            userName = authState.User.Identity.Name;
            vendedores = await http.GetJsonAsync<List<Vendedor>>($"api/vendedor");
            provincias = await http.GetJsonAsync<List<Provincia>>($"api/provincia");

        }

        public async Task armarInforme()
        {
            int provinciaId = provincia == null ? 0 : provincia.Id;
            int vendedorId = vendedor == null ? 0 : vendedor.Id;

            informeVentas = await http.GetJsonAsync<InformeGeneralVentas>($"api/pedido/InformeGeneralVentasVenta?userName={userName}&fechaDesde={fechaDesde.ToString("MM/dd/yyyy")}&fechaHasta={fechaHasta.ToString("MM/dd/yyyy")}&provinciaId={provinciaId}&vendedorId={vendedorId}");
            await js.InvokeVoidAsync("graficoVendedores", informeVentas.InformePedidosVendedores, "pedidoPorVendededor");
            await js.InvokeVoidAsync("ventasPorZona", informeVentas.InformeVentasPorLocalidad.OrderBy(x => x.provincia).ThenBy(x => x.localidad).ThenByDescending(x => x.total), "ventasPorZona");
            await js.InvokeVoidAsync("graficoGananciaPorListaPrecios", informeVentas.informeGananciasPorListaPrecios, "gananciasPorLista");
            await js.InvokeVoidAsync("graficoGananciaPorListaPrecios", informeVentas.informeVentasPorListaPrecios, "ventasPorLista");
            await js.InvokeVoidAsync("gananciasPorLista", informeVentas.informeTotalVentasPorListaPrecios, "totalVentasPorLista");
            await js.InvokeVoidAsync("gananciasPorLista", informeVentas.informeTotalGanancias, "totalGanadoPorLista");


        }

    

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
namespace __Blazor.SurcosBlazor.Client.Pages.BackOffice.GerenciaC.InformesVenta
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSelectGenerico_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Collections.Generic.List<T> __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::System.String __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg5)
        {
        __builder.OpenComponent<global::SurcosBlazor.Client.Shared.SelectGenerico<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "TList", __arg1);
        __builder.AddAttribute(__seq2, "TItemActual", __arg2);
        __builder.AddAttribute(__seq3, "SelectItem", __arg3);
        __builder.AddAttribute(__seq4, "MsjDefault", __arg4);
        __builder.AddAttribute(__seq5, "TTemplate", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateSelectGenerico_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Collections.Generic.List<T> __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::System.String __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg5)
        {
        __builder.OpenComponent<global::SurcosBlazor.Client.Shared.SelectGenerico<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "TList", __arg1);
        __builder.AddAttribute(__seq2, "TItemActual", __arg2);
        __builder.AddAttribute(__seq3, "SelectItem", __arg3);
        __builder.AddAttribute(__seq4, "MsjDefault", __arg4);
        __builder.AddAttribute(__seq5, "TTemplate", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
