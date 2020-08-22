#pragma checksum "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5f84de8a662dc876c8bbfdacdbb2e8011ee5ad4"
// <auto-generated/>
#pragma warning disable 1591
namespace SurcosBlazor.Client.Pages.BackOffice.Configuracion.ProductoC.ProductoPresentacionC
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
#line 4 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
           [Authorize(Roles = "Admin, Configuracion")]

#line default
#line hidden
    public partial class ProductoPresentacionForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 6 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
 if (cargando)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<SurcosBlazor.Client.Shared.Loading>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
#line 9 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
}

#line default
#line hidden
            __builder.AddMarkupContent(3, "\r\n");
#line 11 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
 if (productoPresentacion != null)
{

#line default
#line hidden
            __builder.AddContent(4, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 13 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
                     productoPresentacion

#line default
#line hidden
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 13 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
                                                            async()=> {cargando = true; await Confirmar(); }

#line default
#line hidden
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.AddMarkupContent(13, "<label>Proveedor</label>\r\n");
#line 16 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
             if (productoPresentacion.Proveedor == null || productoPresentacion.ProveedorId == 0)
            {

#line default
#line hidden
                __builder2.AddContent(14, "                ");
                __Blazor.SurcosBlazor.Client.Pages.BackOffice.Configuracion.ProductoC.ProductoPresentacionC.ProductoPresentacionForm.TypeInference.CreateInputBuscaTypeahead_0(__builder2, 15, 16, 
#line 18 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
                                                           ((Proveedor proveedor) => { proveedorSeleccionado(proveedor); return proveedor; })

#line default
#line hidden
                , 17, 
#line 19 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
                                                   (async (string name) => await buscarProveedores(name))

#line default
#line hidden
                , 18, (proveedor) => (__builder3) => {
                    __builder3.AddMarkupContent(19, "\r\n                        ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddContent(21, "#");
                    __builder3.AddContent(22, 
#line 21 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
                               proveedor.Id

#line default
#line hidden
                    );
                    __builder3.AddContent(23, " ");
                    __builder3.AddContent(24, 
#line 21 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
                                             proveedor.razonSocial

#line default
#line hidden
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(25, "\r\n                    ");
                }
                );
                __builder2.AddMarkupContent(26, "\r\n");
#line 24 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
            }
            else
            {

#line default
#line hidden
                __builder2.AddContent(27, "                ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "badge badge-light");
                __builder2.AddContent(30, "#");
                __builder2.AddContent(31, 
#line 27 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
                                                 productoPresentacion.ProveedorId

#line default
#line hidden
                );
                __builder2.AddContent(32, " ");
                __builder2.AddContent(33, 
#line 27 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
                                                                                   productoPresentacion.Proveedor.razonSocial

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.OpenElement(34, "i");
                __builder2.AddAttribute(35, "class", "fa fas-time text-danger");
                __builder2.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 27 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
                                                                                                                                                                                (() => { productoPresentacion.Proveedor = null; productoPresentacion.ProveedorId = null; })

#line default
#line hidden
                ));
                __builder2.AddMarkupContent(37, "<i class=\"fas fa-times text-danger\" style=\"cursor:pointer\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n");
#line 28 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
            }

#line default
#line hidden
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\r\n        ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.AddMarkupContent(44, "<div><label>Presentacion</label></div>\r\n\r\n\r\n            ");
                __Blazor.SurcosBlazor.Client.Pages.BackOffice.Configuracion.ProductoC.ProductoPresentacionC.ProductoPresentacionForm.TypeInference.CreateListadoGenerico_1(__builder2, 45, 46, 
#line 36 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
                                      presentacionProductos

#line default
#line hidden
                , 47, (__builder3) => {
                    __builder3.AddMarkupContent(48, "\r\n                    ");
                    __builder3.OpenElement(49, "div");
                    __builder3.AddMarkupContent(50, "\r\n                        ");
                    __builder3.OpenElement(51, "select");
                    __builder3.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 39 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
                                             (ChangeEventArgs e)=> {
                         productoPresentacion.PresentacionProducto = presentacionProductos.Where(x => x.Id == Convert.ToInt32(e.Value.ToString())).Single();
    productoPresentacion.PresentacionProductoId = Convert.ToInt32(e.Value.ToString());
                     }

#line default
#line hidden
                    ));
                    __builder3.AddMarkupContent(53, "\r\n\r\n                            ");
                    __builder3.OpenElement(54, "option");
                    __builder3.AddAttribute(55, "selected", true);
                    __builder3.AddAttribute(56, "disabled", true);
                    __builder3.AddMarkupContent(57, "-- Seleccione una presentación --");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\r\n");
#line 45 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
                             foreach (PresentacionProducto presentacionProducto in presentacionProductos)
                            {

#line default
#line hidden
                    __builder3.AddContent(59, "                                ");
                    __builder3.OpenElement(60, "option");
                    __builder3.AddAttribute(61, "selected", 
#line 47 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
                                                    productoPresentacion.PresentacionProducto != null ? (presentacionProducto.Id == productoPresentacion.PresentacionProductoId) : false

#line default
#line hidden
                    );
                    __builder3.AddAttribute(62, "value", 
#line 48 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
                                                presentacionProducto.Id

#line default
#line hidden
                    );
                    __builder3.AddMarkupContent(63, "\r\n                                    ");
                    __builder3.AddContent(64, 
#line 49 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
                                     presentacionProducto.nombre

#line default
#line hidden
                    );
                    __builder3.AddMarkupContent(65, "\r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(66, "\r\n");
#line 51 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
                            }

#line default
#line hidden
                    __builder3.AddContent(67, "                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(68, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(69, "\r\n                ");
                }
                );
                __builder2.AddMarkupContent(70, "\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n        ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group");
                __builder2.AddMarkupContent(74, "\r\n            ");
                __builder2.AddMarkupContent(75, "<label>Alerta de Stock</label>\r\n            ");
                __builder2.OpenElement(76, "input");
                __builder2.AddAttribute(77, "type", "number");
                __builder2.AddAttribute(78, "min", "0");
                __builder2.AddAttribute(79, "step", "1");
                __builder2.AddAttribute(80, "class", "form-control");
                __builder2.AddAttribute(81, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 60 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
                                                                              productoPresentacion.cantidadStockMinima

#line default
#line hidden
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(82, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => productoPresentacion.cantidadStockMinima = __value, productoPresentacion.cantidadStockMinima, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n        ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "form-group");
                __builder2.AddMarkupContent(87, "\r\n            ");
                __builder2.AddMarkupContent(88, "<label>Descripcion</label>\r\n            ");
                __builder2.OpenElement(89, "textarea");
                __builder2.AddAttribute(90, "class", "form-control");
                __builder2.AddAttribute(91, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 64 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
                                                  productoPresentacion.descripcion

#line default
#line hidden
                ));
                __builder2.AddAttribute(92, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => productoPresentacion.descripcion = __value, productoPresentacion.descripcion));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n        ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "form-group");
                __builder2.AddMarkupContent(97, "\r\n            ");
                __builder2.AddMarkupContent(98, "<label>Formulado</label>\r\n            ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "d-flex");
                __builder2.AddContent(101, " ");
                __builder2.OpenElement(102, "input");
                __builder2.AddAttribute(103, "type", "checkbox");
                __builder2.AddAttribute(104, "class", "form-control");
                __builder2.AddAttribute(105, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 68 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
                                                                                     productoPresentacion.esFormulado

#line default
#line hidden
                ));
                __builder2.AddAttribute(106, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => productoPresentacion.esFormulado = __value, productoPresentacion.esFormulado));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.OpenElement(107, "span");
                __builder2.AddContent(108, 
#line 68 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
                                                                                                                                 productoPresentacion.esFormulado ? " On" : " Off"

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n\r\n\r\n");
#line 72 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
         if (!productoPresentacion.esFormulado)
        {

#line default
#line hidden
                __builder2.AddContent(111, "            ");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "form-group");
                __builder2.AddMarkupContent(114, "\r\n                ");
                __builder2.AddMarkupContent(115, "<label>Costo</label>\r\n                ");
                __builder2.OpenElement(116, "input");
                __builder2.AddAttribute(117, "class", "form-control");
                __builder2.AddAttribute(118, "type", "number");
                __builder2.AddAttribute(119, "step", "0.001");
                __builder2.AddAttribute(120, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 76 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
                                                                              productoPresentacion.costo

#line default
#line hidden
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(121, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => productoPresentacion.costo = __value, productoPresentacion.costo, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n");
#line 78 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
        }

#line default
#line hidden
                __builder2.AddMarkupContent(124, "\r\n        ");
                __builder2.OpenElement(125, "button");
                __builder2.AddAttribute(126, "class", "btn-outline-olive btn-block");
                __builder2.AddAttribute(127, "type", "submit");
                __builder2.AddContent(128, 
#line 80 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
                                                                   accion

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(130, "\r\n");
#line 83 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 84 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\BackOffice\Configuracion\ProductoC\ProductoPresentacionC\ProductoPresentacionForm.razor"
       
    [Parameter] public ProductoPresentacion productoPresentacion { get; set; }
    [Parameter] public Producto producto { get; set; }
    public List<PresentacionProducto> presentacionProductos { get; set; }
    [Parameter] public string accion { get; set; }
    [Parameter] public EventCallback callback { get; set; }
    public bool cargando { get; set; }
    public async Task Confirmar()
    {
        try
        {
            productoPresentacion.Proveedor = null;
            if (accion == "Crear")
            {
                productoPresentacion.ProductoId = producto.Id;
                productoPresentacion.PresentacionProducto = null;
                productoPresentacion.Proveedor = null;

                await http.PostJsonAsync("api/ProductoPresentacion", productoPresentacion);
                await CloseAllModals();

                await callback.InvokeAsync(new Object());
                cargando = false;

                toastService.ShowSuccess($"Se creo correctamente la Presentacion del producto");

            }
            if (accion == "Editar")
            {
                productoPresentacion.Proveedor = null;
                productoPresentacion.Producto = null;
                productoPresentacion.PresentacionProducto = null;
                productoPresentacion.FormulaProducto = null;

                await http.PutJsonAsync($"api/ProductoPresentacion/{productoPresentacion.Id}", productoPresentacion);
                await CloseAllModals();

                await callback.InvokeAsync(new Object());

                cargando = false;
                toastService.ShowSuccess($"Se editó correctamente Presentacion del producto");

            }
        }
        catch (Exception ex)
        {
            await CloseAllModals();

            await callback.InvokeAsync(new Object());
            cargando = false;
            toastService.ShowError($"Ocurrió un error al intentar crear el pructo {ex.Message}");

        }

    }
    public async Task CloseAllModals()
    {

        await js.InvokeAsync<object>("CloseAllModals");
    }
    protected override async Task OnInitializedAsync()
    {
        await ListarPresentacionesProducto();
    }
    public async Task<List<Proveedor>> buscarProveedores(string proveedorName)
    {

        return await http.GetJsonAsync<List<Proveedor>>($"api/Proveedor?filtro={proveedorName}&cantidadDeRegistros=50");

    }
    public async Task ListarPresentacionesProducto()
    {
        presentacionProductos = await http.GetJsonAsync<List<PresentacionProducto>>("api/PresentacionProducto?cantidadDeRegistros=50");
    }
    public async Task<Proveedor> proveedorSeleccionado(Proveedor proveedor)
    {
        productoPresentacion.Proveedor = proveedor;
        productoPresentacion.ProveedorId = proveedor.Id;


        this.StateHasChanged();
        return proveedor;
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.SurcosBlazor.Client.Pages.BackOffice.Configuracion.ProductoC.ProductoPresentacionC.ProductoPresentacionForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputBuscaTypeahead_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<T, T> __arg0, int __seq1, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<T>>> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg2)
        {
        __builder.OpenComponent<global::SurcosBlazor.Client.Shared.InputBuscaTypeahead<T>>(seq);
        __builder.AddAttribute(__seq0, "ElementoSeleccionado", __arg0);
        __builder.AddAttribute(__seq1, "SearchMethod", __arg1);
        __builder.AddAttribute(__seq2, "MyResultTemplate", __arg2);
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
