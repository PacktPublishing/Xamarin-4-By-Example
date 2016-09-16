using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace XamarinByExample.Weather
{

	public class Wind
	{
		[JsonProperty(PropertyName = "speed")]
		public double Speed { get; set; }

		[JsonProperty(PropertyName = "deg")]
		public double Degrees { get; set; }
	}
	
}
