using System;

using Xamarin.Forms;

namespace XamarinByExample.MonkeysCatalogue
{
	public class App : Application
	{
		public App ()
		{
			MonkeyBusiness targetMonkey = new MonkeyBusiness ();
			Monkey monkeyToSave = new Monkey () { 
				Key = 0,
				Name = "Xamarin Monkey",
				Gender = "Male",
				ScientificClassificationKey = 10,
				Birthdate = DateTime.Parse ("11/11/1980")
			};

			targetMonkey.Create (monkeyToSave);

			Monkey fromDatabase = targetMonkey.Read (0);
			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = fromDatabase.ToString ()
						}
					}
				}
			};
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

