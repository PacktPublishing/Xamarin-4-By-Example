using Newtonsoft.Json;
using System.Collections.Generic;

namespace XamarinByExample.Weather
{
	public class WeatherConditions : BaseEntity<int>
	{
		[JsonProperty (PropertyName = "coord")]
		public Coordinates Coordinates { get; set; }

		[JsonProperty (PropertyName = "sys")]
		public Sys Sys { get; set; }

		[JsonProperty (PropertyName = "weather")]
		public List<Weather> Weather { get; set; }

		[JsonProperty (PropertyName = "base")]
		public string Base { get; set; }

		[JsonProperty (PropertyName = "main")]
		public Main Main { get; set; }

		[JsonProperty (PropertyName = "wind")]
		public Wind Wind { get; set; }

		[JsonProperty (PropertyName = "clouds")]
		public Clouds Clouds { get; set; }

		[JsonProperty (PropertyName = "dt")]
		public int Dt { get; set; }

		[JsonProperty (PropertyName = "id")]
		public int Id { get; set; }

		[JsonProperty (PropertyName = "name")]
		public string Name { get; set; }

		[JsonProperty (PropertyName = "cod")]
		public int Cod { get; set; }
	}
}

