using Microsoft.AspNetCore.Components;
using Radzen;

namespace JeffPatterson.dev.Client.Shared;
public partial class MainLayout
{
  [Inject] private NotificationService NotificationService { get; set; }

  private void ButtonClick(string clickedText)
  {
    NotificationService.Notify(new NotificationMessage
    {
      Severity = NotificationSeverity.Info,
      Summary = "This Button Clicked",
      Detail = clickedText
    });
  }

  private void AnotherButtonClick()
  {
    NotificationService.Notify(new NotificationMessage
    {
      Severity = NotificationSeverity.Info,
      Summary = "Another Button Clicked",
      Detail = "Some string"
    });
  }
}
