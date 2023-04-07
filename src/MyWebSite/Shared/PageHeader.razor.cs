using Microsoft.AspNetCore.Components;
using Microsoft.Fast.Components.FluentUI;
using Microsoft.Fast.Components.FluentUI.Utilities;

namespace MyWebSite.Shared;

public partial class PageHeader : FluentComponentBase
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}