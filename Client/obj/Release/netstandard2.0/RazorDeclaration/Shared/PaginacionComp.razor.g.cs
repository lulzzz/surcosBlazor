#pragma checksum "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\PaginacionComp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "947442d424ff5c2fff9e4a5e66bb1d8a0e011c8b"
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
    public partial class PaginacionComp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 14 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\PaginacionComp.razor"
       
    [Parameter] public int PaginaActual { get; set; } = 1;
    [Parameter] public int PaginasTotales { get; set; }
    [Parameter] public int Radio { get; set; } = 3;
    [Parameter] public EventCallback<int> PaginaSeleccionada { get; set; }
    List<PaginasModel> Enlaces = new List<PaginasModel>();

    private async Task PaginaSeleccionadaInterno(PaginasModel paginaModel)
    {
        if (paginaModel.Pagina == PaginaActual)
        {
            return;
        }

        if (!paginaModel.Habilitada)
        {
            return;
        }

        await PaginaSeleccionada.InvokeAsync(paginaModel.Pagina);
    }

    protected override void OnParametersSet()
    {
        Enlaces = new List<PaginasModel>();

        var enlaceAnteriorHabilitada = PaginaActual != 1;
        var enlaceAnterior = PaginaActual - 1;
        Enlaces.Add(new PaginasModel(enlaceAnterior, enlaceAnteriorHabilitada, "Anterior"));

        for (int i = 1; i <= PaginasTotales; i++)
        {
            if (i >= PaginaActual - Radio && i <= PaginaActual + Radio)
            {
                Enlaces.Add(new PaginasModel(i) { Activa = PaginaActual == i });
            }
        }

        var enlaceSiguienteHabilitada = PaginaActual != PaginasTotales;
        var enlaceSiguiente = PaginaActual + 1;
        Enlaces.Add(new PaginasModel(enlaceSiguiente, enlaceSiguienteHabilitada, "Siguiente"));
    }


    class PaginasModel
    {

        public PaginasModel(int pagina)
            : this(pagina, true)
        { }

        public PaginasModel(int pagina, bool habilitada)
            : this(pagina, habilitada, pagina.ToString())
        { }

        public PaginasModel(int pagina, bool habilitada, string texto)
        {
            Pagina = pagina;
            Habilitada = habilitada;
            Texto = texto;
        }

        public string Texto { get; set; }
        public int Pagina { get; set; }
        public bool Habilitada { get; set; } = true;
        public bool Activa { get; set; } = false;
    }


#line default
#line hidden
    }
}
#pragma warning restore 1591