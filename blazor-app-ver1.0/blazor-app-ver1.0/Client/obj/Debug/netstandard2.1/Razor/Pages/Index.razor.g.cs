#pragma checksum "/Users/git-repo/Blazor-app/blazor-app-ver1.0/blazor-app-ver1.0/Client/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9630f4be7cb243a9f25f75df692826d497e98211"
// <auto-generated/>
#pragma warning disable 1591
namespace blazor_app_ver1._0.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/git-repo/Blazor-app/blazor-app-ver1.0/blazor-app-ver1.0/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/git-repo/Blazor-app/blazor-app-ver1.0/blazor-app-ver1.0/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/git-repo/Blazor-app/blazor-app-ver1.0/blazor-app-ver1.0/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/git-repo/Blazor-app/blazor-app-ver1.0/blazor-app-ver1.0/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/git-repo/Blazor-app/blazor-app-ver1.0/blazor-app-ver1.0/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/git-repo/Blazor-app/blazor-app-ver1.0/blazor-app-ver1.0/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/git-repo/Blazor-app/blazor-app-ver1.0/blazor-app-ver1.0/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/git-repo/Blazor-app/blazor-app-ver1.0/blazor-app-ver1.0/Client/_Imports.razor"
using blazor_app_ver1._0.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/git-repo/Blazor-app/blazor-app-ver1.0/blazor-app-ver1.0/Client/_Imports.razor"
using blazor_app_ver1._0.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\n\nWelcome to your new app.\n");
            __builder.AddMarkupContent(1, "<p>クライアント側のINDEX.razorファイルです</p>\n");
            __builder.AddMarkupContent(2, "<p>基本的にはサーバー側のディレクトリで共通ファイルを書いていて、個別のページについてはクライアント側でPagesのディレクトリで管理している</p>\n\n");
            __builder.OpenElement(3, "div");
            __builder.AddMarkupContent(4, "\n    ");
            __builder.OpenElement(5, "textarea");
            __builder.AddAttribute(6, "class", "form-control mt-3");
            __builder.AddAttribute(7, "rows", "3");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "/Users/git-repo/Blazor-app/blazor-app-ver1.0/blazor-app-ver1.0/Client/Pages/Index.razor"
                      TextValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TextValue = __value, TextValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n        ");
            __builder.AddMarkupContent(11, "<button class=\"btn btn-primary mt-4\">日記を保存する</button>\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n\n");
            __builder.OpenComponent<blazor_app_ver1._0.Client.Shared.SurveyPrompt>(13);
            __builder.AddAttribute(14, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\n\n");
            __builder.AddContent(16, 
#nullable restore
#line 16 "/Users/git-repo/Blazor-app/blazor-app-ver1.0/blazor-app-ver1.0/Client/Pages/Index.razor"
 TextValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "\n\n");
            __builder.OpenComponent<blazor_app_ver1._0.Client.Pages.Calendar>(18);
            __builder.AddAttribute(19, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime>(this, 
#nullable restore
#line 18 "/Users/git-repo/Blazor-app/blazor-app-ver1.0/blazor-app-ver1.0/Client/Pages/Index.razor"
                   ClickHandler

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "/Users/git-repo/Blazor-app/blazor-app-ver1.0/blazor-app-ver1.0/Client/Pages/Index.razor"
      
    string TextValue { get; set; }
    void ClickHandler(DateTime dt) { }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
