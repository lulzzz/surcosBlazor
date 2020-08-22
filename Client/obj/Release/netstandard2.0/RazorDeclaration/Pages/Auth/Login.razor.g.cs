#pragma checksum "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\Auth\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec6f8cb3cebad1dd76009c5c4ff143e07b2c0660"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
