using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace XamarinByExample.Weather
{

	public class Weather
	{
		[JsonProperty(PropertyName = "id")]
		public int Id { get; set; }

		[JsonProperty(PropertyName = "main")]
		public string Main { get; set; }

		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		[JsonProperty(PropertyName = "icon")]
		public string Icon { get; set; }
	}
	
}
