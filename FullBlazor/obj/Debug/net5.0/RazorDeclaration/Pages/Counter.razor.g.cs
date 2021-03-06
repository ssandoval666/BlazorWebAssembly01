// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FullBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Desarrollo\2021\FullBlazor\FullBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Desarrollo\2021\FullBlazor\FullBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Desarrollo\2021\FullBlazor\FullBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Desarrollo\2021\FullBlazor\FullBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Desarrollo\2021\FullBlazor\FullBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Desarrollo\2021\FullBlazor\FullBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Desarrollo\2021\FullBlazor\FullBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Desarrollo\2021\FullBlazor\FullBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Desarrollo\2021\FullBlazor\FullBlazor\_Imports.razor"
using FullBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Desarrollo\2021\FullBlazor\FullBlazor\_Imports.razor"
using FullBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Desarrollo\2021\FullBlazor\FullBlazor\Pages\Counter.razor"
       
    private int currentCount = 0;

    public class Person
    {
        public long? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    private async void IncrementCount()
    {
        await theFactoryDb.Open();

        var people = await theFactoryDb.Employees.GetAll<Person>();


        var newPerson = new Person()
        {
            FirstName = "John",
            LastName = "Doe"
        };

        await theFactoryDb.Employees.Add(newPerson);


        var ConnectionStatus = localStorage.GetItem<string>("ConnectionStatus");

        Connection oCon = new Connection();


        if (Convert.ToBoolean(ConnectionStatus))
            currentCount++;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.TheFactoryDb theFactoryDb { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ISyncLocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
