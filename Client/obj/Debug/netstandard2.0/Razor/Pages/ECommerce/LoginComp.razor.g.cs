#pragma checksum "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\LoginComp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9db1e0e6454589a6377704f81ad1c81148fbf10"
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
#line 1 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\LoginComp.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\LoginComp.razor"
using System.Text;

#line default
#line hidden
#line 3 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\LoginComp.razor"
using System.Text.Json;

#line default
#line hidden
#line 7 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\LoginComp.razor"
using SurcosBlazor.Client.Auth;

#line default
#line hidden
    public partial class LoginComp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>


    .wave {
        display: block;
        animation: waving 3s infinite;
    }



    h2,
    a {
        text-align: center;
    }

    button {
        font-size: 0.8em;
        color: var(--white);
        padding: 1em;
        margin: 0.5em;
        border-radius: 5px;
        border-width: 0px;
        text-transform: uppercase;
    }

    input {
        padding: 1em;
        border-radius: 0px;
        border: 0px;
        border-radius: 5px;
        background-color: hsl(0, 0%, 95%);
    }

    .contenedor {
        display: flex;
        flex-direction: column;
        /*max-width: 350px;*/
        background-color: var(--white);
        padding: 2em;
        border-radius: 5px;
        box-shadow: 0 14px 28px rgba(0, 0, 0, 0.25), 0 10px 10px rgba(0, 0, 0, 0.22);
        border-top: 10px solid var(--accent-color);
    }

    .signup {
        background-color: var(--accent-color);
    }

        .signup:hover {
            background-color: var(--dark-accent-color);
        }

    .login {
        margin-top: 20px;
        background-color: var(--main-color);
    }

        .login:hover {
            background-color: var(--dark-main-color);
        }

    .disclaimer {
        font-size: 0.9em;
    }

    a {
        color: var(--main-color);
    }

        a:hover {
            color: var(--dark-main-color);
        }
</style>


");
#line 85 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\LoginComp.razor"
 if (cargando)
{

#line default
#line hidden
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<SurcosBlazor.Client.Shared.Loading>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
#line 88 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\LoginComp.razor"
}

#line default
#line hidden
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 91 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\LoginComp.razor"
                 userInfo

#line default
#line hidden
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 91 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\LoginComp.razor"
                                            async () => { cargando = true; await LoginUsuario(); }

#line default
#line hidden
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "contenedor");
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-md-12 d-flex justify-content-end");
                __builder2.OpenElement(15, "i");
                __builder2.AddAttribute(16, "class", "fas fa-times mr-2");
                __builder2.AddAttribute(17, "style", "cursor:pointer");
                __builder2.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 94 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\LoginComp.razor"
                                                                                                                          async()=> await ToggleModal("login")

#line default
#line hidden
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n\r\n        ");
                __builder2.AddMarkupContent(20, "<h2>Bienvenido! <span class=\"wave\">👋🏾</span></h2>\r\n\r\n");
#line 98 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\LoginComp.razor"
         if (error)
        {

#line default
#line hidden
                __builder2.AddContent(21, "            ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "my-3");
                __builder2.OpenElement(24, "strong");
                __builder2.AddAttribute(25, "class", "text-danger");
                __builder2.AddContent(26, 
#line 100 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\LoginComp.razor"
                                                           errorMessage

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n");
#line 101 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\LoginComp.razor"
        }

#line default
#line hidden
                __builder2.AddMarkupContent(28, "        Email:\r\n        ");
                __builder2.OpenElement(29, "input");
                __builder2.AddAttribute(30, "type", "text");
                __builder2.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 103 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\LoginComp.razor"
                                  userInfo.username

#line default
#line hidden
                ));
                __builder2.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userInfo.username = __value, userInfo.username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n\r\n        Password:\r\n        ");
                __builder2.OpenElement(34, "input");
                __builder2.AddAttribute(35, "type", "password");
                __builder2.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 106 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\LoginComp.razor"
                                      userInfo.Password

#line default
#line hidden
                ));
                __builder2.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userInfo.Password = __value, userInfo.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n\r\n        ");
                __builder2.AddMarkupContent(39, "<button type=\"submit\" class=\"login\">Ingresar</button>\r\n\r\n        ");
                __builder2.OpenElement(40, "h4");
                __builder2.AddAttribute(41, "class", "mt-4 text-center");
                __builder2.AddAttribute(42, "style", "cursor:pointer");
                __builder2.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 110 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\LoginComp.razor"
                                                                        async() => { await ToggleModal("login");await ToggleModal("recuperarContraseña"); }

#line default
#line hidden
                ));
                __builder2.AddMarkupContent(44, "<a>¿Olvidaste tu contraseña?</a>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 114 "C:\Users\agust\source\repos\SurcosBlazor\Client\Pages\ECommerce\LoginComp.razor"
       
    private UserInfo userInfo = new UserInfo();
    public bool error { get; set; } = false;
    public string errorMessage { get; set; }
    [Parameter] public Func<int, Task> callback { get; set; }
    public bool cargando { get; set; } = false;
    private async Task LoginUsuario()
    {
        if (userInfo.username != "" && userInfo.username != null && userInfo.Password != "" && userInfo.Password != null)
        {
            try
            {
                var enviarJSON = JsonSerializer.Serialize(userInfo);
                var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");

                var result = await http.PostAsync($"api/account/LoginECommerce/", enviarContent);
                if (result.IsSuccessStatusCode)
                {
                    var response = await DeserializarRespuesta<UserClienteInfo>(result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    await loginService.Login(response.userToken.Token);
                    await callback.Invoke(response.ClienteId);
                    cargando = false;
                }
                else
                {
                    cargando = false;

                    error = true;
                    errorMessage = await result.Content.ReadAsStringAsync();

                }
            }
            catch (Exception ex)
            {
            }


        }
        else
        {
            toastService.ShowError("Usuario o contraseña incorrectos");
        }
    }
    private async Task<UserInfo> DeserializarRespuesta<UserInfo>(HttpResponseMessage httpResponse, JsonSerializerOptions jsonSerializerOptions)
    {
        var responseString = await httpResponse.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<UserInfo>(responseString, jsonSerializerOptions);
    }
    public async Task ToggleModal(string id)
    {
        await js.InvokeAsync<object>("ModalToggle", id);
    }




#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginService loginService { get; set; }
    }
}
#pragma warning restore 1591