using Newtonsoft.Json;
using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace PeopleAroundMe
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var client = new HttpClient();
            var data = client.GetAsync("http://localhost:24626/api/location").Result.Content.ReadAsStringAsync().Result;

            foreach (var item in JsonConvert.DeserializeObject<dynamic>(data))
            {

            }
        }

        private async void GetMyLocationAndAddToTheMapButtonClicked(object sender, EventArgs e)
        {
            var position = await CrossGeolocator.Current.GetPositionAsync();

            var param = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("fullName", FirstName.Text + " " + LastName.Text),
                new KeyValuePair<string, string>("latitude", position.Latitude.ToString()),
                new KeyValuePair<string, string>("longitude", position.Longitude.ToString())
            });

            var client = new HttpClient();
            var isSuccess = (await client.PostAsync("http://localhost:24626/api/location", param)).IsSuccessStatusCode;

            if (isSuccess)
            {
                var mapPosition = new Position(position.Latitude, position.Longitude);

                PeopleMap.MoveToRegion(MapSpan.FromCenterAndRadius(mapPosition, Distance.FromKilometers(1)));
                PeopleMap.Pins.Add(new Pin() { Position = mapPosition, Label = "Me", Type = PinType.SearchResult });
            }
        }
    }
}
