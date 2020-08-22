#pragma checksum "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6044e1506d87951392768c24eb72050394a3c93d"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand d-flex\" href=\"BackOffice/\"><img src=\"/img/surcosLogoNuevo.jpg\" class=\"mx-2\" width=\"25\" height=\"25\" style=\"border-radius:50%;margin-right:5px;\"> Surcos</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 3 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#line 8 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 8 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
            ));
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(17);
            __builder.AddAttribute(18, "Roles", "Admin, Ventas");
            __builder.AddAttribute(19, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(20, "\r\n\r\n                ");
                __builder2.OpenElement(21, "li");
                __builder2.AddAttribute(22, "class", "nav-item px-3");
                __builder2.AddMarkupContent(23, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(24);
                __builder2.AddAttribute(25, "class", "nav-link");
                __builder2.AddAttribute(26, "href", "BackOffice/Ventas");
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(28, "\r\n                        <i class=\"fas fa-cart-arrow-down mr-2\" style=\"font-size:1.1rem;\"></i> Ventas\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(32);
            __builder.AddAttribute(33, "Roles", "Admin, Compras");
            __builder.AddAttribute(34, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n                ");
                __builder2.OpenElement(36, "li");
                __builder2.AddAttribute(37, "class", "nav-item px-3");
                __builder2.AddMarkupContent(38, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(39);
                __builder2.AddAttribute(40, "class", "nav-link");
                __builder2.AddAttribute(41, "href", "BackOffice/Compras");
                __builder2.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(43, "\r\n                        <i class=\"fas fa-shopping-basket mr-2\" style=\"font-size:1.1rem;\"></i> Compras\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(47);
            __builder.AddAttribute(48, "Roles", "Admin, Inventario");
            __builder.AddAttribute(49, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(50, "\r\n                ");
                __builder2.OpenElement(51, "li");
                __builder2.AddAttribute(52, "class", "nav-item px-3");
                __builder2.AddMarkupContent(53, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(54);
                __builder2.AddAttribute(55, "class", "nav-link");
                __builder2.AddAttribute(56, "href", "BackOffice/Inventario");
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(58, "\r\n                        <i class=\"fas fa-truck-moving mr-2\" style=\"font-size:1.1rem;\"></i> Inventario\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(62);
            __builder.AddAttribute(63, "Roles", "Admin, Produccion");
            __builder.AddAttribute(64, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(65, "\r\n                ");
                __builder2.OpenElement(66, "li");
                __builder2.AddAttribute(67, "class", "nav-item px-3");
                __builder2.AddMarkupContent(68, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(69);
                __builder2.AddAttribute(70, "class", "nav-link");
                __builder2.AddAttribute(71, "href", "BackOffice/Produccion");
                __builder2.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(73, "\r\n                        <i class=\"fas fa-cubes mr-2\" style=\"font-size:1.1rem;\"></i> Produccion\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(76, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(77);
            __builder.AddAttribute(78, "Roles", "Admin");
            __builder.AddAttribute(79, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(80, "\r\n                ");
                __builder2.OpenElement(81, "li");
                __builder2.AddAttribute(82, "class", "nav-item px-3");
                __builder2.AddMarkupContent(83, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(84);
                __builder2.AddAttribute(85, "class", "nav-link");
                __builder2.AddAttribute(86, "href", "BackOffice/Gerencia");
                __builder2.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(88, "\r\n                        <i class=\"fas fa-user-shield mr-2\" style=\"font-size:1.1rem;\"></i> Gerencia\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(89, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(91, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(92);
            __builder.AddAttribute(93, "Roles", "Admin, Tesoreria");
            __builder.AddAttribute(94, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(95, "\r\n                ");
                __builder2.OpenElement(96, "li");
                __builder2.AddAttribute(97, "class", "nav-item px-3");
                __builder2.AddMarkupContent(98, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(99);
                __builder2.AddAttribute(100, "class", "nav-link");
                __builder2.AddAttribute(101, "href", "BackOffice/Tesoreria");
                __builder2.AddAttribute(102, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(103, "\r\n                        <i class=\"fas fa-money-check-alt mr-2\" style=\"font-size:1.1rem;\"></i> Tesoreria\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(106, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(107);
            __builder.AddAttribute(108, "Roles", "Admin, Configuracion");
            __builder.AddAttribute(109, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(110, "\r\n                ");
                __builder2.OpenElement(111, "li");
                __builder2.AddAttribute(112, "class", "nav-item px-3");
                __builder2.AddMarkupContent(113, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(114);
                __builder2.AddAttribute(115, "class", "nav-link");
                __builder2.AddAttribute(116, "href", "BackOffice/Configuraciones");
                __builder2.AddAttribute(117, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(118, "\r\n                        <i class=\"fas fa-cogs mr-2\" style=\"font-size:1.1rem;\"></i> Configuracion\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(119, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(121, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(122);
            __builder.AddAttribute(123, "Roles", "Admin");
            __builder.AddAttribute(124, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(125, "\r\n                ");
                __builder2.OpenElement(126, "li");
                __builder2.AddAttribute(127, "class", "nav-item px-3");
                __builder2.AddMarkupContent(128, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(129);
                __builder2.AddAttribute(130, "class", "nav-link");
                __builder2.AddAttribute(131, "href", "BackOffice/Seguridad");
                __builder2.AddAttribute(132, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(133, "\r\n                        <i class=\"fas fa-lock mr-2\" style=\"font-size:1.1rem;\"></i> Seguridad\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(134, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(135, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(136, "\r\n\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 101 "C:\Users\agust\source\repos\SurcosBlazor\Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
