using System;
using System.Threading.Tasks;

namespace XamarinByExample.Weather
{
	public class WeatherConditionsService : BaseService<WeatherConditions,int>
	{
		public WeatherConditionsService ()
		{
			
		}

public async Task<WeatherConditions> SearchWeather (string query)
{
	string url = "http://api.openweathermap.org/data/2.5/weather?q=" + query;
	WeatherConditions item = await GET (url);
	return item;
}
	}
}

