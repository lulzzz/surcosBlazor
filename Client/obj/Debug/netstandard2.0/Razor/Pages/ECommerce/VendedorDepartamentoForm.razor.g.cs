#pragma checksum "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorDepartamentoForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e8074508b2a7ba1a2ae3d0d9b276cfa411b525a"
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
    public partial class VendedorDepartamentoForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 5 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorDepartamentoForm.razor"
 if (vendedorDepartamento != null)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 7 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorDepartamentoForm.razor"
                     vendedorDepartamento

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 7 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorDepartamentoForm.razor"
                                                          Confirmar

#line default
#line hidden
            )));
            __builder.AddAttribute(4, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 7 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorDepartamentoForm.razor"
                                                                                      (() => Console.WriteLine("invalid"))

#line default
#line hidden
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenElement(7, "div");
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.AddMarkupContent(9, "<div class=\"border-bottom border-secondary my-2 bg-light\">\r\n                <h4 class>Departamento</h4>\r\n            </div>\r\n           \r\n                    ");
                __builder2.OpenElement(10, "span");
                __builder2.AddMarkupContent(11, "<strong>Departamento: </strong>");
                __builder2.AddContent(12, 
#line 13 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorDepartamentoForm.razor"
                                                           vendedorDepartamento.departamento.Provincia.nombre

#line default
#line hidden
                );
                __builder2.AddContent(13, ", ");
                __builder2.AddContent(14, 
#line 13 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorDepartamentoForm.razor"
                                                                                                                  vendedorDepartamento.departamento.nombre

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n                \r\n          \r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.AddMarkupContent(17, "<div class=\"border-bottom border-secondary my-2 bg-light\">\r\n            <h4 class>Dias de entrega</h4>\r\n        </div>\r\n        ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "my-2");
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "d-flex col-md-12 col-xs-12 pt-2");
                __builder2.AddMarkupContent(23, "\r\n                ");
                __builder2.AddMarkupContent(24, "<h4 class=\"col-md-2\"> <strong>Lunes: </strong></h4>");
                __builder2.OpenElement(25, "input");
                __builder2.AddAttribute(26, "type", "checkbox");
                __builder2.AddAttribute(27, "class", "");
                __builder2.AddAttribute(28, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 22 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorDepartamentoForm.razor"
                                                                                                  vendedorDepartamento.entregaLunes

#line default
#line hidden
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => vendedorDepartamento.entregaLunes = __value, vendedorDepartamento.entregaLunes));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddContent(30, 
#line 22 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorDepartamentoForm.razor"
                                                                                                                                                vendedorDepartamento.entregaLunes ? "On" : "Off"

#line default
#line hidden
                );
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "d-flex col-md-12 col-xs-12 pt-2");
                __builder2.AddMarkupContent(35, "\r\n                ");
                __builder2.AddMarkupContent(36, "<h4 class=\"col-md-2\"> <strong>Martes: </strong></h4>");
                __builder2.OpenElement(37, "input");
                __builder2.AddAttribute(38, "type", "checkbox");
                __builder2.AddAttribute(39, "class", "");
                __builder2.AddAttribute(40, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 25 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorDepartamentoForm.razor"
                                                                                                   vendedorDepartamento.entregaMartes

#line default
#line hidden
                ));
                __builder2.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => vendedorDepartamento.entregaMartes = __value, vendedorDepartamento.entregaMartes));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddContent(42, 
#line 25 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorDepartamentoForm.razor"
                                                                                                                                                  vendedorDepartamento.entregaMartes ? "On" : "Off"

#line default
#line hidden
                );
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "d-flex col-md-12 col-xs-12 pt-2");
                __builder2.AddMarkupContent(47, "\r\n                ");
                __builder2.AddMarkupContent(48, "<h4 class=\"col-md-2\"> <strong>Miercoles: </strong></h4>");
                __builder2.OpenElement(49, "input");
                __builder2.AddAttribute(50, "type", "checkbox");
                __builder2.AddAttribute(51, "class", "");
                __builder2.AddAttribute(52, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 28 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorDepartamentoForm.razor"
                                                                                                      vendedorDepartamento.entregaMiercoles

#line default
#line hidden
                ));
                __builder2.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => vendedorDepartamento.entregaMiercoles = __value, vendedorDepartamento.entregaMiercoles));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddContent(54, 
#line 28 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorDepartamentoForm.razor"
                                                                                                                                                        vendedorDepartamento.entregaMiercoles ? "On" : "Off"

#line default
#line hidden
                );
                __builder2.AddMarkupContent(55, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n            ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "d-flex col-md-12 col-xs-12 pt-2");
                __builder2.AddMarkupContent(59, "\r\n                ");
                __builder2.AddMarkupContent(60, "<h4 class=\"col-md-2\"> <strong>Jueves: </strong></h4>");
                __builder2.OpenElement(61, "input");
                __builder2.AddAttribute(62, "type", "checkbox");
                __builder2.AddAttribute(63, "class", "");
                __builder2.AddAttribute(64, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 31 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorDepartamentoForm.razor"
                                                                                                   vendedorDepartamento.entregaJueves

#line default
#line hidden
                ));
                __builder2.AddAttribute(65, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => vendedorDepartamento.entregaJueves = __value, vendedorDepartamento.entregaJueves));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddContent(66, 
#line 31 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorDepartamentoForm.razor"
                                                                                                                                                  vendedorDepartamento.entregaJueves ? "On" : "Off"

#line default
#line hidden
                );
                __builder2.AddMarkupContent(67, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n            ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "d-flex col-md-12 col-xs-12 pt-2");
                __builder2.AddMarkupContent(71, "\r\n                ");
                __builder2.AddMarkupContent(72, "<h4 class=\"col-md-2\"> <strong>Viernes: </strong></h4>");
                __builder2.OpenElement(73, "input");
                __builder2.AddAttribute(74, "type", "checkbox");
                __builder2.AddAttribute(75, "class", "");
                __builder2.AddAttribute(76, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 34 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorDepartamentoForm.razor"
                                                                                                    vendedorDepartamento.entregaViernes

#line default
#line hidden
                ));
                __builder2.AddAttribute(77, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => vendedorDepartamento.entregaViernes = __value, vendedorDepartamento.entregaViernes));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddContent(78, 
#line 34 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorDepartamentoForm.razor"
                                                                                                                                                    vendedorDepartamento.entregaViernes ? "On" : "Off"

#line default
#line hidden
                );
                __builder2.AddMarkupContent(79, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n            ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "d-flex col-md-12 col-xs-12 pt-2");
                __builder2.AddMarkupContent(83, "\r\n                ");
                __builder2.AddMarkupContent(84, "<h4 class=\"col-md-2\"> <strong>Sabado: </strong></h4>");
                __builder2.OpenElement(85, "input");
                __builder2.AddAttribute(86, "type", "checkbox");
                __builder2.AddAttribute(87, "class", "");
                __builder2.AddAttribute(88, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 37 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorDepartamentoForm.razor"
                                                                                                   vendedorDepartamento.entregaSabado

#line default
#line hidden
                ));
                __builder2.AddAttribute(89, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => vendedorDepartamento.entregaSabado = __value, vendedorDepartamento.entregaSabado));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddContent(90, 
#line 37 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorDepartamentoForm.razor"
                                                                                                                                                  vendedorDepartamento.entregaSabado ? "On" : "Off"

#line default
#line hidden
                );
                __builder2.AddMarkupContent(91, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n            ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "d-flex col-md-12 col-xs-12 pt-2");
                __builder2.AddMarkupContent(95, "\r\n                ");
                __builder2.AddMarkupContent(96, "<h4 class=\"col-md-2\"> <strong>Domingo: </strong></h4>");
                __builder2.OpenElement(97, "input");
                __builder2.AddAttribute(98, "type", "checkbox");
                __builder2.AddAttribute(99, "class", "");
                __builder2.AddAttribute(100, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 40 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorDepartamentoForm.razor"
                                                                                                    vendedorDepartamento.entregaDomingo

#line default
#line hidden
                ));
                __builder2.AddAttribute(101, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => vendedorDepartamento.entregaDomingo = __value, vendedorDepartamento.entregaDomingo));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddContent(102, 
#line 40 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorDepartamentoForm.razor"
                                                                                                                                                    vendedorDepartamento.entregaDomingo ? "On" : "Off"

#line default
#line hidden
                );
                __builder2.AddMarkupContent(103, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n\r\n        ");
                __builder2.AddMarkupContent(106, "<button type=\"submit\" class=\"btn btn-sm btn-outline-dark btn-block\">Editar</button>\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(107, "\r\n");
#line 46 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorDepartamentoForm.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 47 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\VendedorDepartamentoForm.razor"
       
    [Parameter] public VendedorDepartamento vendedorDepartamento { get; set; }
    [Parameter] public Vendedor vendedor { get; set; }
    [Parameter] public EventCallback callback { get; set; }


    public Departamento departamento { get; set; }


    public async Task<List<Departamento>> searchMethodDeparmantos(string searchText)
    {
        var HttpResponse = await repostorio.Get<List<Departamento>>($"/api/departamento?filtro={searchText}&cantidadDeRegistros=10&includeProvincia=True");
        return HttpResponse.Response;
    }

    public Departamento DepartamentoSeleccionado(Departamento departamento)
    {
        this.vendedorDepartamento.departamento = departamento;
        this.StateHasChanged();
        return departamento;
    }

    public async Task Confirmar()
    {
        try
        {
           
                await http.PutJsonAsync($"api/vendedorDepartamento/{vendedorDepartamento.Id}", vendedorDepartamento);
                toastService.ShowSuccess($"Se editó correctamente");

            
        }
        catch (Exception ex)
        {

            toastService.ShowError($"Ocurrio un error {ex.Message}");
            ;
        }


        await CloseAllModals();

        await callback.InvokeAsync(new Object());

    }
    public async Task CloseAllModals()
    {

        await js.InvokeAsync<object>("CloseAllModals");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repostorio { get; set; }
    }
}
#pragma warning restore 1591
