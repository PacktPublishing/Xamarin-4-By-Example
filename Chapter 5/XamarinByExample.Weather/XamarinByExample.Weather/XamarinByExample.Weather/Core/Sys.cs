using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace XamarinByExample.Weather
{

	public class Sys
	{
		[JsonProperty(PropertyName = "message")]
		public double Message { get; set; }

		[JsonProperty(PropertyName = "country")]
		public string Country { get; set; }

		[JsonProperty(PropertyName = "sunrise")]
		public int Sunrise { get; set; }

		[JsonProperty(PropertyName = "sunset")]
		public int Sunset { get; set; }
	}
	
}
