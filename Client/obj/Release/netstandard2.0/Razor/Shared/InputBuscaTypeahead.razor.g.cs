#pragma checksum "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\InputBuscaTypeahead.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1a3bc3790daeef0283db09547547133b3b64df8"
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
    public partial class InputBuscaTypeahead<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.SurcosBlazor.Client.Shared.InputBuscaTypeahead.TypeInference.CreateCustomTypeahead_0(__builder, 0, 1, 
#line 3 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\InputBuscaTypeahead.razor"
                                 (string value) => SearchMethod(value)

#line default
#line hidden
            , 2, 
#line 4 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\InputBuscaTypeahead.razor"
                         sampleItem

#line default
#line hidden
            , 3, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 5 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\InputBuscaTypeahead.razor"
                                 (T item) => ElementoSeleccionado(item)

#line default
#line hidden
            ), 4, (context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.AddContent(6, 
#line 7 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\InputBuscaTypeahead.razor"
         MyResultTemplate(context)

#line default
#line hidden
                );
                __builder2.AddMarkupContent(7, "\r\n    ");
            }
            );
        }
        #pragma warning restore 1998
#line 13 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\InputBuscaTypeahead.razor"
       
    [Parameter] public Func<T,T> ElementoSeleccionado { get; set; }
    [Parameter] public Func<string, Task<IEnumerable<T>>> SearchMethod { get; set; }
    [Parameter] public RenderFragment<T> MyResultTemplate { get; set; }
    T sampleItem = default(T);

   

#line default
#line hidden
    }
}
namespace __Blazor.SurcosBlazor.Client.Shared.InputBuscaTypeahead
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCustomTypeahead_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<TItem>>> __arg0, int __seq1, TItem __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TItem> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg3)
        {
        __builder.OpenComponent<global::SurcosBlazor.Client.Shared.CustomTypeahead<TItem>>(seq);
        __builder.AddAttribute(__seq0, "SearchMethod", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ResultTemplate", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591