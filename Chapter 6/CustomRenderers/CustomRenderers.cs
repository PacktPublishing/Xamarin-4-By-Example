using System;

using Xamarin.Forms;

namespace CustomRenderers
{
	public class App : Application
	{
		public App ()
		{
			// first example: RoundedImage
//			MainPage = new ContentPage {
//				Content = new StackLayout {
//					Orientation = StackOrientation.Horizontal,
//					VerticalOptions = LayoutOptions.Center,
//					HorizontalOptions = LayoutOptions.Center,
//					Children = {
//						new RoundedImage () { 
//							Source = "https://bitbucket-assetroot.s3.amazonaws.com/c/photos/2014/Jan/22/matteo_bortolu_novarumdx-avatar-2797296216-0.png", 
//							HorizontalOptions = LayoutOptions.CenterAndExpand,
//							VerticalOptions = LayoutOptions.CenterAndExpand,
//							WidthRequest = 100, 
//							HeightRequest = 100
//						}
//					}
//				}
//			};
			//second example: SkypeCall
			MainPage = new SkypeCallPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

