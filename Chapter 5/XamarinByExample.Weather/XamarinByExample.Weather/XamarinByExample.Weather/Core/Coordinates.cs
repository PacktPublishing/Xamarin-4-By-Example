using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace XamarinByExample.Weather
{
	
public class Coordinates
{
	[JsonProperty(PropertyName = "lon")]
	public double Longitude { get; set; }

	[JsonProperty(PropertyName = "lat")]
	public double Latitude { get; set; }
}
	
}
