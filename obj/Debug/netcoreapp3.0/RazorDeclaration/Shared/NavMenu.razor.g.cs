#pragma checksum "d:\Repositorios\Pruebas\Blazor\BlazorTest\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f69f085bbfab54db8017b13ecd74dd5b04092aea"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorTest.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "d:\Repositorios\Pruebas\Blazor\BlazorTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "d:\Repositorios\Pruebas\Blazor\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "d:\Repositorios\Pruebas\Blazor\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "d:\Repositorios\Pruebas\Blazor\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 5 "d:\Repositorios\Pruebas\Blazor\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "d:\Repositorios\Pruebas\Blazor\BlazorTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "d:\Repositorios\Pruebas\Blazor\BlazorTest\_Imports.razor"
using BlazorTest;

#line default
#line hidden
#line 8 "d:\Repositorios\Pruebas\Blazor\BlazorTest\_Imports.razor"
using BlazorTest.Shared;

#line default
#line hidden
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 28 "d:\Repositorios\Pruebas\Blazor\BlazorTest\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
