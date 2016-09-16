using Xamarin.Forms;

namespace CustomRenderers
{
	public class RoundedImage : Image
	{
		public RoundedImage ()
		{
		}
	}
}

//public class ImageCircle : Image
//{
//	public Action Tapped { get; set; }
//
//	public static readonly BindableProperty ShouldDisposeImageProperty =
//		BindableProperty.Create<TappableImage, bool> (
//			p => p.ShouldDisposeImage, false);
//
//	public bool ShouldDisposeImage {
//		get {
//			return (bool)GetValue (ShouldDisposeImageProperty);
//		}
//
//		set {
//			this.SetValue (ShouldDisposeImageProperty, value);
//		}
//	}
//
//	//Bindable property for the border width
//	public static readonly BindableProperty BorderWidthProperty =
//		BindableProperty.Create<ImageCircle,double> (p => p.BorderWidth, 4);
//	//Gets or sets the color of the progress bar
//	public double BorderWidth {
//		get { return (double)GetValue (BorderWidthProperty); }
//		set { SetValue (BorderWidthProperty, value); }
//	}
//
//	public ImageCircle ()
//	{
//
//	}
//}