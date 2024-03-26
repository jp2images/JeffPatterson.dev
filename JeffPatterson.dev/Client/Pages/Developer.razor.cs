namespace JeffPatterson.dev.Client.Pages;

public partial class Developer
{
  private const string ButtonText = "hi";

  private int _currentCount = 0;

  private void IncrementCount()
  {
    _currentCount++;
  }

  private void ClickMe()
  {
    _currentCount++;
  }
}
