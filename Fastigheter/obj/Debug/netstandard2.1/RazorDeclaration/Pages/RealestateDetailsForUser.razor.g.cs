#pragma checksum "C:\Users\Admin\Desktop\skoluppgifter\Fastigheter\Fastigheter\Pages\RealestateDetailsForUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4485d2af645307ee3d08242518558d2552d7e151"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Fastigheter.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Desktop\skoluppgifter\Fastigheter\Fastigheter\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\skoluppgifter\Fastigheter\Fastigheter\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\skoluppgifter\Fastigheter\Fastigheter\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\skoluppgifter\Fastigheter\Fastigheter\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Desktop\skoluppgifter\Fastigheter\Fastigheter\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Desktop\skoluppgifter\Fastigheter\Fastigheter\_Imports.razor"
using Fastigheter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Desktop\skoluppgifter\Fastigheter\Fastigheter\_Imports.razor"
using Fastigheter.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\skoluppgifter\Fastigheter\Fastigheter\Pages\RealestateDetailsForUser.razor"
using Fastigheter.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\skoluppgifter\Fastigheter\Fastigheter\Pages\RealestateDetailsForUser.razor"
using TeamRedzFastigheter.Shared.Models.RealEstateModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\skoluppgifter\Fastigheter\Fastigheter\Pages\RealestateDetailsForUser.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Desktop\skoluppgifter\Fastigheter\Fastigheter\Pages\RealestateDetailsForUser.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/myrealestates/{Id:int}")]
    public partial class RealestateDetailsForUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\Admin\Desktop\skoluppgifter\Fastigheter\Fastigheter\Pages\RealestateDetailsForUser.razor"
       
    [Parameter] public int Id { get; set; }
    RealEstateDto realestate;

    protected override async Task OnInitializedAsync()
    {
        realestate = await Service.GetRealEstateDetailAsync(Id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RealEstateService Service { get; set; }
    }
}
#pragma warning restore 1591
