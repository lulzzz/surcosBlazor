#pragma checksum "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\ListadoCajas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be81e72cecdd0638acd490ac11963b4763a026c6"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\ListadoCajas.razor"
           [Authorize(Roles = "Admin, Tesoreria")]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(BackOfficeLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/BackOffice/Tesoreria/ListadoCajas")]
    public partial class ListadoCajas : Microsoft.AspNetCore.Components.ComponentBase
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
#line 9 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\ListadoCajas.razor"
                                                ()=>uri.NavigateTo("/BackOffice/Tesoreria")

#line default
#line hidden
            ));
            __builder.AddContent(9, "Tesoreria");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "li");
            __builder.AddAttribute(12, "class", "breadcrumb-item active");
            __builder.AddAttribute(13, "aria-current", "page");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 10 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\ListadoCajas.razor"
                                                                           ()=>uri.NavigateTo("/BackOffice/Tesoreria/ListadoCajas")

#line default
#line hidden
            ));
            __builder.AddContent(15, "Listado Cajas");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.OpenElement(19, "div");
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.AddMarkupContent(21, "<div class=\"border-bottom border-secondary my-2\">\r\n        <h2 class>Cajas</h2>\r\n    </div>\r\n    ");
            __builder.OpenComponent<SurcosBlazor.Client.Shared.BotoneraAcciones<Caja>>(22);
            __builder.AddAttribute(23, "agregar", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 17 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\ListadoCajas.razor"
                                        true

#line default
#line hidden
            ));
            __builder.AddAttribute(24, "modalContentAgregar", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n            ");
                __builder2.OpenComponent<SurcosBlazor.Client.Pages.BackOffice.Tesoreria.CajaForm>(26);
                __builder2.AddAttribute(27, "caja", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SurcosBlazor.Shared.Entidades.Caja>(
#line 19 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\ListadoCajas.razor"
                            new Caja()

#line default
#line hidden
                ));
                __builder2.AddAttribute(28, "callback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 19 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\ListadoCajas.razor"
                                                  (async() => {this.StateHasChanged();await tablaGenerica.ListarItemsApi(); })

#line default
#line hidden
                )));
                __builder2.AddAttribute(29, "accion", "Crear");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\r\n    ");
            __Blazor.SurcosBlazor.Client.Pages.BackOffice.Tesoreria.ListadoCajas.TypeInference.CreateTablaGenerica_0(__builder, 32, 33, 
#line 25 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\ListadoCajas.razor"
                                      new List<string[]> {
                                new string[3]{"Id", "Id","Texto" },
                                new string[3]{"Caja", "nombre","Texto" },
                                new string[3]{ "Saldo","saldo","Text" }}

#line default
#line hidden
            , 34, 
#line 29 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\ListadoCajas.razor"
                             true

#line default
#line hidden
            , 35, 
#line 30 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\ListadoCajas.razor"
                            true

#line default
#line hidden
            , 36, "/BackOffice/Tesoreria/MovimientosCaja", 37, 
#line 32 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\ListadoCajas.razor"
                                new TablaGenerica<Caja>.ConsultarApi {  baseUrl=$"api/caja?", consultaApi=true, paginacion=true, cantidadDeRegistrosAMostrar=25}

#line default
#line hidden
            , 38, 
#line 33 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\ListadoCajas.razor"
                           true

#line default
#line hidden
            , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 34 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\ListadoCajas.razor"
                                ((Caja caja)=>ElementoSeleccionado(caja))

#line default
#line hidden
            ), 40, 
#line 35 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\ListadoCajas.razor"
                             true

#line default
#line hidden
            , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 36 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\ListadoCajas.razor"
                                   async ()=>await EliminarCaja(caja)

#line default
#line hidden
            ), 42, (__builder2) => {
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.OpenComponent<SurcosBlazor.Client.Pages.BackOffice.Tesoreria.CajaForm>(44);
                __builder2.AddAttribute(45, "caja", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SurcosBlazor.Shared.Entidades.Caja>(
#line 39 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\ListadoCajas.razor"
                            caja

#line default
#line hidden
                ));
                __builder2.AddAttribute(46, "callback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 39 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\ListadoCajas.razor"
                                            (()=>this.StateHasChanged())

#line default
#line hidden
                )));
                __builder2.AddAttribute(47, "accion", "Editar");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n        ");
            }
            , 49, (__value) => {
#line 24 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\ListadoCajas.razor"
                         tablaGenerica = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(50, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 46 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Tesoreria\ListadoCajas.razor"
       
    public Caja caja { get; set; }
    public TablaGenerica<Caja> tablaGenerica { get; set; }


    public async Task EliminarCaja(Caja caja)
    {
        await http.DeleteAsync($"api/caja/{caja.Id}");
        this.caja = null;

    }


    public Caja ElementoSeleccionado(Caja caja)
    {

        this.caja = caja;
        this.StateHasChanged();
        return caja;
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uri { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.SurcosBlazor.Client.Pages.BackOffice.Tesoreria.ListadoCajas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTablaGenerica_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<global::System.String[]> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.String __arg3, int __seq4, global::SurcosBlazor.Client.Shared.TablaGenerica<T>.ConsultarApi __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6, int __seq7, global::System.Boolean __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment __arg9, int __seq10, global::System.Action<global::SurcosBlazor.Client.Shared.TablaGenerica<T>> __arg10)
        {
        __builder.OpenComponent<global::SurcosBlazor.Client.Shared.TablaGenerica<T>>(seq);
        __builder.AddAttribute(__seq0, "elementosAmostrar", __arg0);
        __builder.AddAttribute(__seq1, "acciones", __arg1);
        __builder.AddAttribute(__seq2, "detalle", __arg2);
        __builder.AddAttribute(__seq3, "detalleUrl", __arg3);
        __builder.AddAttribute(__seq4, "consultaApi", __arg4);
        __builder.AddAttribute(__seq5, "editar", __arg5);
        __builder.AddAttribute(__seq6, "selectTitem", __arg6);
        __builder.AddAttribute(__seq7, "eliminar", __arg7);
        __builder.AddAttribute(__seq8, "eliminarFunc", __arg8);
        __builder.AddAttribute(__seq9, "modalContentEditar", __arg9);
        __builder.AddComponentReferenceCapture(__seq10, (__value) => { __arg10((global::SurcosBlazor.Client.Shared.TablaGenerica<T>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
