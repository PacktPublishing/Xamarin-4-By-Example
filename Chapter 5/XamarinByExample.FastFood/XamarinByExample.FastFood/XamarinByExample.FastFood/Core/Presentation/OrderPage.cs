using System;
using System.Linq;
using Xamarin.Forms;
using System.Collections.Generic;

namespace XamarinByExample.FastFood
{
	public class OrderPage : ContentPage
	{
		public OrderPage () : base ()
		{
			Label response = new Label ();
			Button buttonSandwitch = new Button {
				Text = "Order Sandwitch"
			};
			Button buttonSoftdrink = new Button {
				Text = "Order Drink"
			};
			Button buttonShowReceipt = new Button {
				Text = "Show Receipt"
			};

			MenuItemBusiness menuManager = new MenuItemBusiness ();
			MenuItemService service = new MenuItemService ();

			MenuItem sandwitch = new MenuItem {
				Name = "Sandwitch",
				RequiredSeconds = 10,
				Price = 5
			};

			MenuItem softdrink = new MenuItem {
				Name = "Sprite",
				RequiredSeconds = 5,
				Price = 2
			};

			buttonSandwitch.Clicked += (sender, e) => {
				service.GetDelayedResponse (sandwitch, sandwitch.RequiredSeconds);

			};
			buttonSoftdrink.Clicked += (object sender, EventArgs e) => {

				service.GetDelayedResponse (softdrink, softdrink.RequiredSeconds);
			};

			buttonShowReceipt.Clicked += (object sender, EventArgs e) => {

				List<MenuItem> itemlist = menuManager.Read ();
				float total = itemlist.Sum (x => x.Price);
				DisplayAlert ("Receipt", String.Format ("Total:{0}$ ({1} items)", total, itemlist.Count), "OK");
			};

			service.ResponseReceived += (item) => {
				response.Text += String.Format ("\nReceived: {0} ({1}$)", item.Name, item.Price);
				List<MenuItem> itemlist = menuManager.Read ();
				item.Key = itemlist.Count == 0 ? 0 : itemlist.Max (x => x.Key) + 1;
			
				menuManager.Create (item);
			};

			StackLayout fastFoodLayout = new StackLayout {
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					response, buttonSandwitch, buttonSoftdrink, buttonShowReceipt
				}
			};

			Content = fastFoodLayout;
		}
	}
}

