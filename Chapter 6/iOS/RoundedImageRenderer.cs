using System;

using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;

using CustomRenderers.iOS;
using CustomRenderers;

[assembly: ExportRenderer (typeof(RoundedImage), typeof(RoundedImageRenderer))]

namespace CustomRenderers.iOS
{
	public class RoundedImageRenderer : ImageRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Image> e)
		{
			base.OnElementChanged (e);

			CreateCircle ();
		}

		private void CreateCircle ()
		{
			double min = Math.Min (Element.WidthRequest, Element.HeightRequest);
			Control.Layer.CornerRadius = (float)(min / 2.0);
			Control.Layer.MasksToBounds = false;
			Control.Layer.BorderColor = UIKit.UIColor.Blue.CGColor;
			Control.Layer.BorderWidth = 4;
			Control.ClipsToBounds = true;
		}
	}
}

