using Xamarin.Forms;

namespace WebViewUITestApp
{
	public class App : Application
	{
		public App()
		{
			MainPage = new ContentPage
			{
				Content = new WebView
				{
					Source = "https://www.xamarin.com/"
				}
			};
		}
	}
}
