using Xamarin.Forms;

namespace XamarinByExample.Weather
{
	public class WeatherNavigationPage : NavigationPage
	{
		public WeatherNavigationPage ()
			: base (new WeatherSearchPage ())
		{
		}
	}
}

