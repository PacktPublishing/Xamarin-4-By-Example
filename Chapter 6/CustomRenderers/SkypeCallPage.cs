using System;

using Xamarin.Forms;

namespace CustomRenderers
{
public class SkypeCallPage : ContentPage
{
	public event CallHandler Call;

	public delegate void CallHandler (string number);

	public void OnCall (string number)
	{
		if (Call != null) {
			Call (number);
		}
	}

	public SkypeCallPage ()
	{
		Entry phoneNumber = new Entry () { 
			HorizontalOptions = LayoutOptions.FillAndExpand,
			Placeholder = "insert a phone number" 
		};
		Button call = new Button () { 
			HorizontalOptions = LayoutOptions.FillAndExpand,
			Text = "Call"
		};
		call.Clicked += (object sender, EventArgs e) => 
			OnCall(phoneNumber.Text);

		Content = new StackLayout { 
			Orientation = StackOrientation.Vertical,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			Children = {
				phoneNumber, call
			}
		};
	}

}
}


