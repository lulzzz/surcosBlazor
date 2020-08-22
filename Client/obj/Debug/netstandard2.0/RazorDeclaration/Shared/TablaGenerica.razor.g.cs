#pragma checksum "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\TablaGenerica.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19940701d9b695334a16a400c5a697e9afced60b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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