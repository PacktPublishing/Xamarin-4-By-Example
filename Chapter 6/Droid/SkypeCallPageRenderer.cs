using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;

using CustomRenderers;
using CustomRenderers.Droid;
using Android.Content;
using Android.Content.PM;
using Android.Net;


[assembly: ExportRenderer (typeof(SkypeCallPage), typeof(SkypeCallPageRenderer))]

namespace CustomRenderers.Droid
{
	public class SkypeCallPageRenderer : PageRenderer
	{
		string packageName = "com.skype.raider";
		string componentMainActivity = "com.skype.raider.Main";

		protected override void OnElementChanged (ElementChangedEventArgs<Page> e)
		{
			base.OnElementChanged (e);
			SkypeCallPage skypeCallPage = (Element as SkypeCallPage);
			skypeCallPage.Call += SkypeCallPage_Call;
		}

		void SkypeCallPage_Call (string number)
		{
			
			// Make sure the Skype for Android client is installed.
			if (!IsSkypeClientInstalled (Context)) {
				GoToMarket (Context);
				return;
			}
			string mySkypeUri = "skype:" + number;

			// Create the Intent from our Skype URI.
			Uri skypeUri = Uri.Parse (mySkypeUri);
			Intent myIntent = new Intent (Intent.ActionView, skypeUri);

			// Restrict the Intent to being handled by the Skype for Android client only.
			myIntent.SetComponent (new ComponentName (packageName, componentMainActivity));
			myIntent.SetFlags (ActivityFlags.NewTask);

			// Initiate the Intent. It should never fail because you've already established the
			// presence of its handler (although there is an extremely minute window where that
			// handler can go away).
			Context.StartActivity (myIntent);

		}

		public bool IsSkypeClientInstalled (Context myContext)
		{
			PackageManager myPackageMgr = myContext.PackageManager;
			try {
				myPackageMgr.GetPackageInfo (packageName, PackageInfoFlags.Activities);
			} catch (PackageManager.NameNotFoundException e) {
				return (false);
			}
			return (true);
		}

		public void GoToMarket (Context myContext)
		{
			Uri marketUri = Uri.Parse ("market://details?id=com.skype.raider");
			Intent myIntent = new Intent (Intent.ActionView, marketUri);
			myIntent.SetFlags (ActivityFlags.NewTask);
			myContext.StartActivity (myIntent);
			return;
		}

	}
}

