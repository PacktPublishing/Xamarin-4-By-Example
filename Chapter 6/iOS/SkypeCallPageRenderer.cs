using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;

using CustomRenderers;
using CustomRenderers.iOS;

using UIKit;

[assembly: ExportRenderer (typeof(SkypeCallPage), typeof(SkypeCallPageRenderer))]

namespace CustomRenderers.iOS
{
	public class SkypeCallPageRenderer : PageRenderer
	{
		protected override void OnElementChanged (VisualElementChangedEventArgs e)
		{
			base.OnElementChanged (e);
			SkypeCallPage page = (Element as SkypeCallPage);
			page.Call += Page_Call;
		}

		void Page_Call (string number)
		{
			Foundation.NSUrl url = new Foundation.NSUrl ("skype:" + number);
			bool installed = UIApplication.SharedApplication.CanOpenUrl (url);
			if (installed) {
				UIApplication.SharedApplication.OpenUrl (url);
			} else {
				UIApplication.SharedApplication.OpenUrl (
					new Foundation.NSUrl ("http://itunes.com/apps/skype/skype"));
			}
		}
	}
}

