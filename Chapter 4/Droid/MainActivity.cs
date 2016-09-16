using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;

namespace XamarinByExample.MonkeysCatalogue.Droid
{
	[Activity (Label = "XamarinByExample.MonkeysCatalogue.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			var path = System.Environment.GetFolderPath (System.Environment.SpecialFolder.ApplicationData);
			if (!System.IO.Directory.Exists (path)) {
				System.IO.Directory.CreateDirectory (path);
			}
			var filename = Path.Combine (path, "monkey.db");
			if (!System.IO.File.Exists (filename)) {
				System.IO.File.Create (filename);
			}
			Configuration.DatabasePath = filename;

			LoadApplication (new App ());
		}
	}
}

