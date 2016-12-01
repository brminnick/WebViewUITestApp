using Xamarin.UITest;

namespace WebViewUITestApp.UITest
{
	public class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
			return ConfigureApp
				.iOS
				.PreferIdeSettings()
				.StartApp();
		}
	}
}

