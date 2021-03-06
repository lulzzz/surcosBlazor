#pragma checksum "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19940701d9b695334a16a400c5a697e9afced60b"
// <auto-generated/>
#pragma warning disable 1591
namespace SurcosBlazor.Client.Shared
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
#line 1 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
using SurcosBlazor.Client.Repositorio;

#line default
#line hidden
    public partial class TablaGenerica<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<SurcosBlazor.Client.Shared.ListadoGenerico<T>>(0);
            __builder.AddAttribute(1, "listado", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<T>>(
#line 8 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                listado

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "HayRegistros", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenElement(4, "table");
                __builder2.AddAttribute(5, "class", "table table-sm d-xs-block");
                __builder2.AddAttribute(6, "style", "overflow-x:auto;");
                __builder2.AddMarkupContent(7, "\r\n            ");
                __builder2.OpenElement(8, "thead");
                __builder2.AddMarkupContent(9, "\r\n                ");
                __builder2.OpenElement(10, "tr");
                __builder2.AddAttribute(11, "class", true);
                __builder2.AddMarkupContent(12, "\r\n");
#line 13 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                     foreach (var encabezado in elementosAmostrar)
                    {

#line default
#line hidden
                __builder2.AddContent(13, "                        ");
                __builder2.OpenElement(14, "th");
                __builder2.AddAttribute(15, "scope", "col");
                __builder2.AddContent(16, 
#line 15 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                         encabezado[0]

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n");
#line 16 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                    }

#line default
#line hidden
                __builder2.AddMarkupContent(18, "\r\n");
#line 18 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                     if (acciones)
                    {

#line default
#line hidden
                __builder2.AddContent(19, "                        ");
                __builder2.AddMarkupContent(20, "<th scope=\"col\">Acciones</th>\r\n");
#line 21 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                    }

#line default
#line hidden
                __builder2.AddContent(21, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.OpenElement(24, "tbody");
                __builder2.AddMarkupContent(25, "\r\n");
#line 25 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                 foreach (T item in listado)
                {

#line default
#line hidden
                __builder2.AddContent(26, "                    ");
                __builder2.OpenElement(27, "tr");
                __builder2.AddMarkupContent(28, "\r\n");
#line 28 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                         foreach (var valor in elementosAmostrar)
                        {

#line default
#line hidden
                __builder2.AddContent(29, "                            ");
                __builder2.OpenElement(30, "td");
                __builder2.AddMarkupContent(31, "\r\n\r\n\r\n");
#line 33 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                 if (valor[2] == "Checkbox")
                                {

#line default
#line hidden
                __builder2.AddContent(32, "                                    ");
                __builder2.OpenElement(33, "input");
                __builder2.AddAttribute(34, "type", "checkbox");
                __builder2.AddAttribute(35, "disabled", true);
                __builder2.AddAttribute(36, "checked", 
#line 35 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                                                              GetPropertyValue(item, valor[1])

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                                    ");
                __builder2.OpenElement(38, "span");
                __builder2.AddContent(39, 
#line 36 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                            @GetPropertyValue(item, valor[1]).ToString() == "True" ? " On" : " Off"

#line default
#line hidden
                );
                __builder2.AddContent(40, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n");
#line 37 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                }
                                else if (valor[2] == "Imagen")
                                {

#line default
#line hidden
                __builder2.AddContent(42, "                                    ");
                __builder2.OpenElement(43, "img");
                __builder2.AddAttribute(44, "style", "width: 3rem; height:3rem; border-radius:50%;");
                __builder2.AddAttribute(45, "src", 
#line 40 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                                                                                    GetPropertyValue(item, valor[1])

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n");
#line 41 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"

                                }

                                else if (valor[2] == "Fecha")
                                {
                                    

#line default
#line hidden
                __builder2.AddContent(47, 
#line 46 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                      $"{@GetPropertyValue(item, valor[1]).ToString()}"

#line default
#line hidden
                );
#line 46 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                                                                        

                                }
                                else
                                {
                                    

#line default
#line hidden
                __builder2.AddContent(48, 
#line 51 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                      $"{@GetPropertyValue(item, valor[1])}"

#line default
#line hidden
                );
#line 51 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                                                             
                                }

#line default
#line hidden
                __builder2.AddContent(49, "                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n");
#line 54 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"

                        }

#line default
#line hidden
                __builder2.AddMarkupContent(51, "\r\n");
#line 57 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                         if (acciones)
                        {

#line default
#line hidden
                __builder2.AddContent(52, "                            ");
                __builder2.OpenElement(53, "td");
                __builder2.AddMarkupContent(54, "\r\n");
#line 60 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                 if (detalle)
                                {

#line default
#line hidden
                __builder2.AddContent(55, "                                    ");
                __builder2.OpenElement(56, "a");
                __builder2.AddAttribute(57, "class", "btn btn-sm p-1");
                __builder2.AddAttribute(58, "href", 
#line 62 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                                                      $"{detalleUrl}/{item.GetType().GetProperty("Id").GetValue(item, null)}"

#line default
#line hidden
                );
                __builder2.AddMarkupContent(59, " <i class=\"far fa-eye\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n");
#line 63 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                }

#line default
#line hidden
#line 64 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                 if (editar)
                                {

#line default
#line hidden
                __builder2.AddContent(61, "                                    ");
                __builder2.OpenElement(62, "button");
                __builder2.AddAttribute(63, "class", "btn btn-sm p-1");
                __builder2.AddAttribute(64, "title", "Editar");
                __builder2.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 66 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                                                                              ()=>click_boton_editar(item)

#line default
#line hidden
                ));
                __builder2.AddMarkupContent(66, "\r\n                                        <i class=\"fas fa-edit text-warning\"></i>\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n");
#line 69 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                }

#line default
#line hidden
#line 70 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                 if (eliminar)
                                {

#line default
#line hidden
                __builder2.AddContent(68, "                                    ");
                __builder2.OpenElement(69, "button");
                __builder2.AddAttribute(70, "class", "btn btn-sm p-1");
                __builder2.AddAttribute(71, "title", "Eliminar");
                __builder2.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 72 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                                                                                ()=>click_boton_eliminar(item)

#line default
#line hidden
                ));
                __builder2.AddMarkupContent(73, "\r\n                                        <i class=\"far fa-trash-alt text-danger\"></i>\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n");
#line 75 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                }

#line default
#line hidden
                __builder2.AddMarkupContent(75, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n");
#line 78 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"

                        }

#line default
#line hidden
                __builder2.AddContent(77, "                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n");
#line 81 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                }

#line default
#line hidden
                __builder2.AddContent(79, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n");
#line 84 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
         if (consultaApi.paginacion)
        {

#line default
#line hidden
                __builder2.AddContent(82, "            ");
                __builder2.OpenComponent<SurcosBlazor.Client.Shared.PaginacionComp>(83);
                __builder2.AddAttribute(84, "PaginaActual", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 86 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                          paginaActual

#line default
#line hidden
                ));
                __builder2.AddAttribute(85, "PaginaSeleccionada", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#line 86 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                                                            paginaSeleccionada

#line default
#line hidden
                )));
                __builder2.AddAttribute(86, "PaginasTotales", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 86 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                                                                                                paginasTotales

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\r\n");
#line 87 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
        }

#line default
#line hidden
                __builder2.AddContent(88, "    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(89, "\r\n\r\n");
#line 91 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
 if (editar && listado != null && listado.Count >= 0)
{

#line default
#line hidden
            __builder.AddContent(90, "    ");
            __builder.OpenComponent<SurcosBlazor.Client.Shared.Modal>(91);
            __builder.AddAttribute(92, "modalTitulo", "Editar");
            __builder.AddAttribute(93, "modalId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 93 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                          modalIdEditar

#line default
#line hidden
            ));
            __builder.AddAttribute(94, "modalTamaño", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 93 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                                                       tamañoModal

#line default
#line hidden
            ));
            __builder.AddAttribute(95, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(96, "\r\n        ");
                __builder2.AddContent(97, 
#line 94 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
         modalContentEditar

#line default
#line hidden
                );
                __builder2.AddMarkupContent(98, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(99, "\r\n");
#line 96 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
}

#line default
#line hidden
#line 97 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
 if (eliminar && listado != null && listado.Count >= 0)
{

#line default
#line hidden
            __builder.AddContent(100, "    ");
            __builder.OpenComponent<SurcosBlazor.Client.Shared.ModalConfirm>(101);
            __builder.AddAttribute(102, "modalId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 99 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                            modalIdEliminar

#line default
#line hidden
            ));
            __builder.AddAttribute(103, "confirmFunc", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 99 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
                                                          (async () => { await eliminarFunc.InvokeAsync(new Object()); await ListarItemsApi(); toastService.ShowInfo("Se elimino correctamente");})

#line default
#line hidden
            )));
            __builder.AddAttribute(104, "childContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(105, "\r\n            ");
                __builder2.AddMarkupContent(106, "<p>¿Estas seguro que desear realizar esta eliminación? Una vez hecho no habrá vuelta atrás</p>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(107, "\r\n");
#line 104 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 105 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor"
       
    [Parameter] public List<string> encabezados { get; set; }
    [Parameter] public EventCallback<T> selectTitem { get; set; }

    public List<T> listado { get; set; }

    [Parameter] public List<string[]> elementosAmostrar { get; set; }

    [Parameter] public ConsultarApi consultaApi { get; set; } = new ConsultarApi();

    [Parameter] public bool acciones { get; set; } = false;

    [Parameter] public bool detalle { get; set; } = false;
    [Parameter] public string detalleUrl { get; set; } = "/";

    [Parameter] public bool editar { get; set; } = false;
    [Parameter] public bool eliminar { get; set; } = false;
    [Parameter] public string tamañoModal { get; set; } = "modal-md";

    [Parameter] public EventCallback eliminarFunc { get; set; }

    [Parameter] public RenderFragment modalContentEditar { get; set; }
    [Parameter] public string modalIdEditar { get; set; } = "modalEditarTablaGenerica";
    [Parameter] public string modalIdEliminar { get; set; } = "modalEliminarTablaGenerica";
    public T item { get; set; }
    private int paginaActual = 1;
    private int paginasTotales;
    private HttpResponseWrapper<List<T>> responseHttp;

    public class ConsultarApi
    {
        public bool consultaApi { get; set; }
        public string baseUrl { get; set; }
        public bool paginacion { get; set; }
        public int cantidadDeRegistrosAMostrar { get; set; }
        public ConsultarApi(bool consultaApi = false, string baseUrl = "", bool paginacion = false, int cantidadDeRegistrosAMostrar = 10)
        {
            this.consultaApi = consultaApi;
            this.baseUrl = baseUrl;
            this.paginacion = paginacion;
            this.cantidadDeRegistrosAMostrar = cantidadDeRegistrosAMostrar;
        }

    }

    public async Task ListarItemsApi(int pagina = 1)
    {
        responseHttp = await repositorio.Get<List<T>>($"{consultaApi.baseUrl}pagina={pagina}&cantidadDeRegistros={consultaApi.cantidadDeRegistrosAMostrar}");
        if (!responseHttp.Error)
        {
            listado = responseHttp.Response;

            var conteo = responseHttp.HttpResponseMessage.Headers.GetValues("conteo").FirstOrDefault();

            paginasTotales = int.Parse(responseHttp.HttpResponseMessage.Headers.GetValues("totalPaginas").FirstOrDefault());

        }



    }

    private async Task paginaSeleccionada(int pagina)
    {
        paginaActual = pagina;
        await ListarItemsApi(pagina);
    }
    protected override async Task OnInitializedAsync()
    {
        await ListarItemsApi();
    }
    //protected override async Task OnAfterRenderAsync(bool firstRender)
    //{
    //    await ListarItemsApi();
    //}

    //protected override async Task OnParametersSetAsync()
    //{
    //    await ListarItemsApi();
    //}


    public async Task click_boton_editar(T item)
    {
        await selectTitem.InvokeAsync(item);
        await ToggleModal(modalIdEditar);
    }
    public async Task click_boton_eliminar(T item)
    {
        await selectTitem.InvokeAsync(item);
        await ToggleModal(modalIdEliminar);
    }



    public async Task ToggleModal(string id)
    {

        await js.InvokeAsync<object>("ModalToggle", id);
    }

    public static object GetPropertyValue(object src, string propName)
    {
        if (src == null) return "-";
        if (propName == null) throw new ArgumentException("Value cannot be null.", "propName");

        if(propName.Contains("."))//complex type nested
        {
            var temp = propName.Split(new char[] { '.' }, 2);
            Console.WriteLine(temp);
            return GetPropertyValue(GetPropertyValue(src, temp[0]), temp[1]);
        }
        else
        {
            var prop = src.GetType().GetProperty(propName);
            return prop != null ? prop.GetValue(src, null) : "-";
        }
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
