#pragma checksum "E:\LearnBlazor\AShoppingCart\AShoppingCart\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddf99d6fcb4552853c306d36aaac124bef5ee67e"
// <auto-generated/>
#pragma warning disable 1591
namespace AShoppingCart.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\LearnBlazor\AShoppingCart\AShoppingCart\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\LearnBlazor\AShoppingCart\AShoppingCart\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\LearnBlazor\AShoppingCart\AShoppingCart\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\LearnBlazor\AShoppingCart\AShoppingCart\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\LearnBlazor\AShoppingCart\AShoppingCart\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\LearnBlazor\AShoppingCart\AShoppingCart\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\LearnBlazor\AShoppingCart\AShoppingCart\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\LearnBlazor\AShoppingCart\AShoppingCart\_Imports.razor"
using AShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\LearnBlazor\AShoppingCart\AShoppingCart\_Imports.razor"
using AShoppingCart.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\LearnBlazor\AShoppingCart\AShoppingCart\Pages\Index.razor"
using AShoppingCart.Pages.Cart;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "class", "btn btn-primary");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "E:\LearnBlazor\AShoppingCart\AShoppingCart\Pages\Index.razor"
                                            ()=>_change=!_change

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, 
#nullable restore
#line 4 "E:\LearnBlazor\AShoppingCart\AShoppingCart\Pages\Index.razor"
                                                                     _status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 5 "E:\LearnBlazor\AShoppingCart\AShoppingCart\Pages\Index.razor"
 if (_change)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenComponent<AShoppingCart.Pages.Cart.View>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 8 "E:\LearnBlazor\AShoppingCart\AShoppingCart\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "    ");
            __builder.OpenComponent<AShoppingCart.Pages.Cart.Add>(9);
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 12 "E:\LearnBlazor\AShoppingCart\AShoppingCart\Pages\Index.razor"
} 

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "E:\LearnBlazor\AShoppingCart\AShoppingCart\Pages\Index.razor"
        
    private bool _change { get; set; } = true;
    private string _status => _change ? "Thêm" : "Quay lại"; 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
