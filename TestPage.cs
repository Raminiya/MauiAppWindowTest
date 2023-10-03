
namespace MauiAppWindowTest;

public class TestPage : ContentPage
{
    /// <summary>
    /// Most Simple C# Page with a single label to make sure noting within the page is interfering with closing procedure
    /// </summary>
	public TestPage()
	{
        var label1 = new Label()
        {
            Text = "Simple Page to test Second Window!",
            FontSize = 32,
            HorizontalOptions = LayoutOptions.Center
        };
        Content = label1;
    }
}