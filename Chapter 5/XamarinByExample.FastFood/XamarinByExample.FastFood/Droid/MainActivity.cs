using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;

namespace XamarinByExample.FastFood.Droid
{
	[Activity (Label = "XamarinByExample.FastFood.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			var path = System.Environment.GetFolderPath (System.Environment.SpecialFolder.ApplicationData);
			if (!Directory.Exists (path)) {
				Directory.CreateDirectory (path);
			}
			var filename = Path.Combine (path, "fastfood.db");
			if (!File.Exists (filename)) {
				File.Create (filename);
			}
			Configuration.DatabasePath = filename;
			LoadApplication (new App ());
		}
	}
}

