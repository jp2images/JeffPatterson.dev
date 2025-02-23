using Microsoft.AspNetCore.Components;
using Radzen;

namespace JeffPatterson.dev.Client.Shared;
public partial class NavMenu
{
  [Inject] protected TooltipService ToolTipService { get; set; }


  private bool _collapseNavMenu = true;

  public NavMenu(TooltipService toolTipService)
  {
    this.ToolTipService = toolTipService;
  }

  private string? NavMenuCssClass => _collapseNavMenu ? "collapse" : null;


  private void ToggleNavMenu()
  {
    _collapseNavMenu = !_collapseNavMenu;
  }

  void ShowTooltip(ElementReference elementReference, TooltipOptions? options = null) => ToolTipService.Open(elementReference, "Some content", options);

}
