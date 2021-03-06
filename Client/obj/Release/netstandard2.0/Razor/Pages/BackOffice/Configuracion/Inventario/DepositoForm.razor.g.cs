#pragma checksum "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\Inventario\DepositoForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91c19923495093e31ad9401da2b8c7c9b48889a7"
// <auto-generated/>
#pragma warning disable 1591
namespace SurcosBlazor.Client.Pages.BackOffice.Configuracion.Inventario
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
#line 5 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\Inventario\DepositoForm.razor"
           [Authorize(Roles = "Admin, Configuracion")]

#line default
#line hidden
    public partial class DepositoForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 7 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\Inventario\DepositoForm.razor"
 if (cargando)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<SurcosBlazor.Client.Shared.Loading>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
#line 10 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\Inventario\DepositoForm.razor"
}

#line default
#line hidden
#line 11 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\Inventario\DepositoForm.razor"
 if (deposito != null)
{


#line default
#line hidden
            __builder.AddContent(3, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 14 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\Inventario\DepositoForm.razor"
                      deposito

#line default
#line hidden
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 14 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\Inventario\DepositoForm.razor"
                                                 async()=>{cargando = true; await Confirmar(); }

#line default
#line hidden
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.AddMarkupContent(14, "<label>Nombre</label>\r\n            ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 18 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\Inventario\DepositoForm.razor"
                                                deposito.nombre

#line default
#line hidden
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => deposito.nombre = __value, deposito.nombre));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __Blazor.SurcosBlazor.Client.Pages.BackOffice.Configuracion.Inventario.DepositoForm.TypeInference.CreateValidationMessage_0(__builder2, 20, 21, 
#line 19 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\Inventario\DepositoForm.razor"
                                    (()=>deposito.nombre)

#line default
#line hidden
                );
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n\r\n\r\n        ");
                __builder2.OpenElement(24, "button");
                __builder2.AddAttribute(25, "class", "btn-outline-olive btn-block");
                __builder2.AddAttribute(26, "type", "submit");
                __builder2.AddContent(27, 
#line 23 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\Inventario\DepositoForm.razor"
                                                                   accion

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\r\n");
#line 25 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\Inventario\DepositoForm.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 26 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\Inventario\DepositoForm.razor"
       
    [Parameter]
    public Deposito deposito { get; set; }
    [Parameter]
    public string accion { get; set; }
    [Parameter]
    public EventCallback callback { get; set; }
    public bool cargando { get; set; } = false;
    public List<Provincia> provincias { get; set; } = new List<Provincia>();
    public List<Departamento> departamentos { get; set; } = new List<Departamento>();
    public async Task Confirmar()
    {
        try
        {
            if (accion == "Crear")
            {
                await http.PostJsonAsync("api/deposito", deposito);
                cargando = false;
                toastService.ShowSuccess($"Se creó correctamente la Categoria Cliente {deposito.nombre}");

            }
            if (accion == "Editar")
            {
                await http.PutJsonAsync($"api/deposito/{deposito.Id}", deposito);
                cargando = false;

                toastService.ShowSuccess($"Se editó correctamente la Categoria Cliente {deposito.nombre}");

            }
        }
        catch (Exception ex)
        {
            cargando = false;

            toastService.ShowError($"Ocurrió un error:  {ex.Message}");
        }


        await CloseAllModals();

        await callback.InvokeAsync(new Object());

    }

    public async Task CloseAllModals()
    {

        await js.InvokeAsync<object>("CloseAllModals");
    }

    protected override async Task OnInitializedAsync()
    {
        provincias = await http.GetJsonAsync<List<Provincia>>("api/provincia?cantidadDeRegistros=25");

    }







#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
namespace __Blazor.SurcosBlazor.Client.Pages.BackOffice.Configuracion.Inventario.DepositoForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
