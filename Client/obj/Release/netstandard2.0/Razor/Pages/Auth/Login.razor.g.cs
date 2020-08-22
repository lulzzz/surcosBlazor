#pragma checksum "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\Auth\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec6f8cb3cebad1dd76009c5c4ff143e07b2c0660"
// <auto-generated/>
#pragma warning disable 1591
namespace SurcosBlazor.Client.Pages.Auth
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
#line 10 "C:\Users\agust\source\repos\SurcosBlazor\Client\_Imports.razor"
using SurcosBlazor.Client.Helpers;

#line default
#line hidden
#line 11 "C:\Users\agust\source\repos\SurcosBlazor\Client\_Imports.razor"
using SurcosBlazor.Shared.Entidades;

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
#line 6 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\Auth\Login.razor"
using SurcosBlazor.Shared;

#line default
#line hidden
#line 7 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\Auth\Login.razor"
using SurcosBlazor.Client.Auth;

#line default
#line hidden
#line 9 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\Auth\Login.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style type=\"text/css\">\r\n    .formLogin {\r\n        margin: 0;\r\n        padding: 0;\r\n        background-color: #323232;\r\n        height: 100vh;\r\n        position: relative;\r\n        width: 100vw;\r\n        background-image: url(\'img/imglogin.jpg\');\r\n        background-size: cover;\r\n        background-repeat: no-repeat;\r\n    }\r\n\r\n        .formLogin .formContent {\r\n            display: block;\r\n            padding: 20px;\r\n            position: absolute;\r\n            top: 50%;\r\n            left: 50%;\r\n            transform: translate(-50%,-50%);\r\n            background: rgba(30,30,30,.6);\r\n            width: 25vw;\r\n            height: 50vh;\r\n            min-width: 768px;\r\n            min-height: 400px;\r\n            text-align: center;\r\n            animation-delay:3s;\r\n            animation: initLogin 1s linear;\r\n        }\r\n\r\n            .formLogin .formContent h2 {\r\n                margin-bottom: 5vh;\r\n                margin-top: 3vh;\r\n                color: white;\r\n            }\r\n\r\n            .formLogin .formContent input {\r\n                width: 50%;\r\n                margin: 15px auto;\r\n                padding: 10px;\r\n                border: none;\r\n                background: transparent;\r\n                display: block;\r\n                color: white;\r\n                outline: none;\r\n                border-bottom: 2px solid #f3743d;\r\n            }\r\n\r\n    ::placeholder {\r\n        color: white;\r\n        font-weight: bold;\r\n    }\r\n\r\n    .formLogin .formContent button {\r\n        width: 50%;\r\n        padding: 10px 35px;\r\n        margin: 50px auto;\r\n        border: 1px solid white;\r\n        border-radius: 0;\r\n        display: block;\r\n        background: transparent;\r\n        color: white;\r\n    }\r\n\r\n        .formLogin .formContent button:hover {\r\n            background: #f3743d;\r\n            color: white;\r\n            border: 1px solid #f3743d;\r\n        }\r\n\r\n</style>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "formLogin");
            __builder.AddMarkupContent(3, "\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "formContent");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<h2>\r\n            <strong><span class>SURCOS</span></strong>\r\n        </h2>\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 92 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\Auth\Login.razor"
                         userInfo

#line default
#line hidden
            ));
            __builder.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 92 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\Auth\Login.razor"
                                                  LoginUsuario

#line default
#line hidden
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n\r\n            ");
                __builder2.OpenElement(13, "input");
                __builder2.AddAttribute(14, "type", "text");
                __builder2.AddAttribute(15, "class", "");
                __builder2.AddAttribute(16, "placeholder", "Usuario");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 94 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\Auth\Login.razor"
                                                userInfo.username

#line default
#line hidden
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userInfo.username = __value, userInfo.username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n\r\n\r\n\r\n            ");
                __builder2.OpenElement(20, "input");
                __builder2.AddAttribute(21, "type", "password");
                __builder2.AddAttribute(22, "Class", "");
                __builder2.AddAttribute(23, "autocomplete", "off");
                __builder2.AddAttribute(24, "placeholder", "Contraseña");
                __builder2.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 98 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\Auth\Login.razor"
                                                    userInfo.Password

#line default
#line hidden
                ));
                __builder2.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userInfo.Password = __value, userInfo.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n\r\n            ");
                __builder2.AddMarkupContent(28, "<button type=\"submit\" class>INGRESAR</button>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n\r\n\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 113 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\Auth\Login.razor"
       
    private UserInfo userInfo = new UserInfo();


    private async Task LoginUsuario()
    {
        if (userInfo.username != "" && userInfo.username != null && userInfo.Password != "" && userInfo.Password != null)
        {
            var result = await http.PostJsonAsync<UserToken>($"api/account/login/", userInfo);
            Console.WriteLine(result);
            await loginService.Login(result.Token);
            uriHelper.NavigateTo("/");
            
        }
        else
        {
            await Alerta("top-end", "error", "Usuario o contraseña Incorrectos");

        }


    }



    public async Task Alerta(string posicion = "top-end", string icono = "success", string mensaje = "Se creó el producto con éxito")
    {
        await js.InvokeAsync<object>("alerta", posicion, icono, mensaje);
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginService loginService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
