using Microsoft.AspNetCore.Components;
using Radzen;

namespace JeffPatterson.dev.Client.Shared;
public partial class NavMenu
{
  [Inject] protected TooltipService toolTipService { get; set; }


  private bool collapseNavMenu = true;

  private string? NavMenuCssClass => collapseNavMenu ? "collapse" : null;


  private void ToggleNavMenu()
  {
    collapseNavMenu = !collapseNavMenu;
  }

  void ShowTooltip(ElementReference elementReference, TooltipOptions options = null) => toolTipService.Open(elementReference, "Some content", options);

}
