using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace XamarinByExample.Weather
{

	public class Main
	{
		[JsonProperty(PropertyName = "temp")]
		public double Temperature { get; set; }

		[JsonProperty(PropertyName = "temp_min")]
		public double TemperatureMin { get; set; }

		[JsonProperty(PropertyName = "temp_max")]
		public double TemperatureMax { get; set; }

		[JsonProperty(PropertyName = "pressure")]
		public double Pressure { get; set; }

		[JsonProperty(PropertyName = "sea_level")]
		public double SeaLevel { get; set; }

		[JsonProperty(PropertyName = "grnd_level")]
		public double GroundLevel { get; set; }

		[JsonProperty(PropertyName = "humidity")]
		public int Humidity { get; set; }
	}
	
}
