using System;

using Xamarin.Forms;

namespace XamarinByExample.Weather
{
	public class WeatherSearchPage : ContentPage
	{
		public WeatherSearchPage () : base ()
		{
			this.Padding = 50;
			Entry inputText = new Entry ();
			Button searchButton = new Button {
				Text = "Search"
			};
			WeatherConditionsService service = new WeatherConditionsService ();
			service.ResponseReceived += (item) => {
				DisplayAlert (
					"Temperature", 
					item.Main.Temperature.ToString (), 
					"OK");
			};
			searchButton.Clicked += (sender, e) => {
				service.SearchWeather (inputText.Text);
			};

			Content = new StackLayout { 
				Children = { inputText, searchButton }
			};
		}
	}
}


