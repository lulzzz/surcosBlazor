#pragma checksum "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b6ffe04f0edee5701780ae1caeb682e2ea6faa8"
// <auto-generated/>
#pragma warning disable 1591
namespace SurcosBlazor.Client.Pages.ECommerce
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
#line 3 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorForm.razor"
using SurcosBlazor.Client.Repositorio;

#line default
#line hidden
    public partial class VendedorForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 6 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorForm.razor"
 if (vendedor != null)
{


#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 9 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorForm.razor"
                      vendedor

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 9 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorForm.razor"
                                               Confirmar

#line default
#line hidden
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-md-12 row justify-content-between");
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-6");
                __builder2.AddMarkupContent(13, "\r\n\r\n                ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group col-md-12");
                __builder2.AddMarkupContent(16, "\r\n                    ");
                __builder2.OpenComponent<SurcosBlazor.Client.Shared.InputImg>(17);
                __builder2.AddAttribute(18, "Label", "Foto");
                __builder2.AddAttribute(19, "ImagenSeleccionada", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#line 15 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorForm.razor"
                                                               ImagenSeleccionada

#line default
#line hidden
                )));
                __builder2.AddAttribute(20, "ImagenTemporal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 15 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorForm.razor"
                                                                                                    imagenTemporal

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n\r\n            ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "col-md-6");
                __builder2.AddMarkupContent(26, "\r\n\r\n                ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group col-md-12");
                __builder2.AddMarkupContent(29, "\r\n                    ");
                __builder2.AddMarkupContent(30, "<label>Nombre</label>\r\n                    ");
                __builder2.OpenElement(31, "input");
                __builder2.AddAttribute(32, "class", "form-control");
                __builder2.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 24 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorForm.razor"
                                                        vendedor.nombre

#line default
#line hidden
                ));
                __builder2.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => vendedor.nombre = __value, vendedor.nombre));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                    ");
                __Blazor.SurcosBlazor.Client.Pages.ECommerce.VendedorForm.TypeInference.CreateValidationMessage_0(__builder2, 36, 37, 
#line 25 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorForm.razor"
                                            (()=>vendedor.nombre)

#line default
#line hidden
                );
                __builder2.AddMarkupContent(38, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n\r\n\r\n                ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group col-md-12");
                __builder2.AddMarkupContent(42, "\r\n                    ");
                __builder2.AddMarkupContent(43, "<label>Fecha Nacimiendo</label>\r\n                    ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "d-flex");
                __builder2.AddContent(46, " ");
                __builder2.OpenElement(47, "input");
                __builder2.AddAttribute(48, "type", "date");
                __builder2.AddAttribute(49, "class", "form-control");
                __builder2.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 31 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorForm.razor"
                                                                                         vendedor.FechaNacimiento

#line default
#line hidden
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => vendedor.FechaNacimiento = __value, vendedor.FechaNacimiento, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                    ");
                __Blazor.SurcosBlazor.Client.Pages.ECommerce.VendedorForm.TypeInference.CreateValidationMessage_1(__builder2, 53, 54, 
#line 32 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorForm.razor"
                                            (()=>vendedor.FechaNacimiento)

#line default
#line hidden
                );
                __builder2.AddMarkupContent(55, "\r\n\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group col-md-12");
                __builder2.AddMarkupContent(59, "\r\n                    ");
                __builder2.AddMarkupContent(60, "<label>Celular</label>\r\n                    ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "d-flex");
                __builder2.AddContent(63, " ");
                __builder2.OpenElement(64, "input");
                __builder2.AddAttribute(65, "type", "text");
                __builder2.AddAttribute(66, "class", "form-control");
                __builder2.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 37 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorForm.razor"
                                                                                         vendedor.numeroCelular

#line default
#line hidden
                ));
                __builder2.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => vendedor.numeroCelular = __value, vendedor.numeroCelular));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                    ");
                __Blazor.SurcosBlazor.Client.Pages.ECommerce.VendedorForm.TypeInference.CreateValidationMessage_2(__builder2, 70, 71, 
#line 38 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorForm.razor"
                                            (()=>vendedor.numeroCelular)

#line default
#line hidden
                );
                __builder2.AddMarkupContent(72, "\r\n\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "form-group col-md-12");
                __builder2.AddMarkupContent(76, "\r\n                    ");
                __builder2.AddMarkupContent(77, "<label>Email</label>\r\n                    ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "d-flex");
                __builder2.AddContent(80, " ");
                __builder2.OpenElement(81, "input");
                __builder2.AddAttribute(82, "type", "text");
                __builder2.AddAttribute(83, "class", "form-control");
                __builder2.AddAttribute(84, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 43 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorForm.razor"
                                                                                         vendedor.email

#line default
#line hidden
                ));
                __builder2.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => vendedor.email = __value, vendedor.email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n                    ");
                __Blazor.SurcosBlazor.Client.Pages.ECommerce.VendedorForm.TypeInference.CreateValidationMessage_3(__builder2, 87, 88, 
#line 44 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorForm.razor"
                                            (()=>vendedor.email)

#line default
#line hidden
                );
                __builder2.AddMarkupContent(89, "\r\n\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n                \r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n            ");
                __builder2.AddMarkupContent(92, "<div class=\"col-md-4\">\r\n\r\n            </div>\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n\r\n\r\n\r\n        ");
                __builder2.AddMarkupContent(94, "<button class=\"btn-outline-olive btn-block col-md-12\" type=\"submit\">Editar</button>\r\n\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(95, "\r\n");
#line 68 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorForm.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 69 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorForm.razor"
       
    [Parameter] public Vendedor vendedor { get; set; }
    [Parameter] public EventCallback callback { get; set; }
    public List<VendedorDepartamento> vendedorDepartamentos { get; set; }

    public string imagenTemporal { get; set; }

    public async Task Confirmar()
    {
        try
        {
    
                await http.PutJsonAsync($"api/vendedor/{vendedor.Id}", vendedor);
                toastService.ShowSuccess($"Se editó correctamente el vendedor {vendedor.nombre}");
        }
        catch (Exception ex)
        {

            toastService.ShowError($"Ocurrio un error al intentar crear el vendedor  {ex.Message}");
        }


        await CloseAllModals();

        await callback.InvokeAsync(new Object());

    }
    public async Task CloseAllModals()
    {

        await js.InvokeAsync<object>("CloseAllModals");
    }


    private void ImagenSeleccionada(string imagenBase64)
    {
        vendedor.Foto = imagenBase64;
    }



    protected override void OnParametersSet()
    {
        if (vendedor != null)
        {

            if (!string.IsNullOrWhiteSpace(vendedor.Foto))
            {
                imagenTemporal = vendedor.Foto;
            }


        }

    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.SurcosBlazor.Client.Pages.ECommerce.VendedorForm
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
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
