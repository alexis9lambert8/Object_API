#pragma checksum "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36086119fda8dcd2e34b1c3035bde311a0ba8fb4"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
using ObjectsApi.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
using ObjectsApi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Alarm Maker</h1>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-primary");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
                                          RequestAlarm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Make An Alarm");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "hidden", 
#nullable restore
#line 14 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
              alarmViewShown

#line default
#line hidden
#nullable disable
            );
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
                      alarm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
                                             HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "id", "name");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
                                          alarm.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => alarm.Name = __value, alarm.Name))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => alarm.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(22);
                __builder2.AddAttribute(23, "id", "active");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
                                                alarm.Active

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => alarm.Active = __value, alarm.Active))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => alarm.Active));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "<br>\r\n        ");
                __Blazor.BlazorApp.Pages.FetchData.TypeInference.CreateInputNumber_0(__builder2, 28, 29, "alarmType", 30, 
#nullable restore
#line 21 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
                                                 alarm.AlarmType

#line default
#line hidden
#nullable disable
                , 31, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => alarm.AlarmType = __value, alarm.AlarmType)), 32, () => alarm.AlarmType);
                __builder2.AddMarkupContent(33, "<br>\r\n        ");
                __builder2.OpenElement(34, "button");
                __builder2.AddAttribute(35, "class", "btn btn-primary");
                __builder2.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
                                                  ShowAffectedEquipment

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(37, "Add Affected Equipment");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "<br>\r\n        ");
                __builder2.OpenElement(39, "p");
                __builder2.AddAttribute(40, "hidden", 
#nullable restore
#line 23 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
                    affectedEquipmentShown

#line default
#line hidden
#nullable disable
                );
                __builder2.OpenElement(41, "table");
                __builder2.AddAttribute(42, "class", "table");
                __builder2.AddMarkupContent(43, "<thead><tr>AffectedEquipment</tr></thead>\r\n                ");
                __builder2.OpenElement(44, "tbody");
#nullable restore
#line 29 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
                     for (int i = 0; i < affectedEquipmentOptions.Count; i++)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(45, "tr");
                __builder2.OpenElement(46, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(47);
                __builder2.AddAttribute(48, "id", 
#nullable restore
#line 32 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
                                                   affectedEquipmentOptions[i].Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
                                                                                                 affectedEquipments[i]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => affectedEquipments[i] = __value, affectedEquipments[i]))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => affectedEquipments[i]));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                            ");
                __builder2.OpenElement(53, "td");
                __builder2.AddContent(54, 
#nullable restore
#line 33 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
                                 affectedEquipmentOptions[i].Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 35 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.AddMarkupContent(56, "<button type=\"submit\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n\r\n");
            __builder.AddMarkupContent(58, "<h1>Alarms</h1>");
#nullable restore
#line 75 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
 if (alarms == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(59, "<p><em>Loading...</em></p>");
#nullable restore
#line 78 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(60, "table");
            __builder.AddAttribute(61, "class", "table");
            __builder.AddMarkupContent(62, "<thead><tr><th>Name</th>\r\n                <th>Active</th>\r\n                <th>Alarm Type</th>\r\n                <th>Affected Equipment</th>\r\n                <th>Time of Failure</th></tr></thead>\r\n        ");
            __builder.OpenElement(63, "tbody");
#nullable restore
#line 92 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
             foreach (var alarm in alarms)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(64, "tr");
            __builder.OpenElement(65, "td");
            __builder.AddContent(66, 
#nullable restore
#line 95 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
                         alarm.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.OpenElement(68, "td");
            __builder.AddContent(69, 
#nullable restore
#line 96 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
                         alarm.Active

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.OpenElement(71, "td");
            __builder.AddContent(72, 
#nullable restore
#line 97 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
                         alarm.AlarmType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                    ");
            __builder.OpenElement(74, "td");
            __builder.AddContent(75, 
#nullable restore
#line 98 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
                         alarm.AffectedEquipment

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.OpenElement(77, "td");
            __builder.AddContent(78, 
#nullable restore
#line 99 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
                         alarm.TimeOfFailure.GetDateTimeFormats().FirstOrDefault()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 101 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 104 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
       
    [Parameter]
    public RenderFragment<BaseObject> RowTemplate { get; set; }

    private Alarm alarm;
    private bool affectedEquipmentShown;
    private bool alarmViewShown;
    private List<BaseObject> affectedEquipmentOptions = new List<BaseObject>();
    private List<bool> affectedEquipments = new List<bool>();

    private void RequestAlarm()
    {
        alarm = new Alarm();
        alarmViewShown = true;
    }

    private void HandleValidSubmit()
    {
        Logger.LogInformation("HandleValidSubmit called");

        // Process the valid form
        AlarmService.Create(alarm);
    }

    private void ShowAffectedEquipment()
    {
        affectedEquipmentShown = !affectedEquipmentShown;
        //affectedEquipmentOptions = EquipmentService.Get();
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\e387641\Documents\New Unity Project\BlazorApp\Pages\FetchData.razor"
       
    private List<Alarm> alarms;

    protected override async Task OnInitializedAsync()
    {
        alarms = AlarmService.Get();
        await Task.Yield();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<FetchData> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AlarmService AlarmService { get; set; }
    }
}
namespace __Blazor.BlazorApp.Pages.FetchData
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
