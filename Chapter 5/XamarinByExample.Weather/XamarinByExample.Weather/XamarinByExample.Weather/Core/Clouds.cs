using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace XamarinByExample.Weather
{

	public class Clouds
	{
		[JsonProperty(PropertyName = "all")]
		public int All { get; set; }
	}
	
}
