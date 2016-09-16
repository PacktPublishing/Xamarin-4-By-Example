using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using CustomRenderers;
using CustomRenderers.Droid;
using System;
using Android.Graphics;

[assembly: ExportRenderer (typeof(RoundedImage), typeof(RoundedImageRenderer))]
namespace CustomRenderers.Droid
{
	public class RoundedImageRenderer : ImageRenderer
	{
protected override void OnElementChanged (ElementChangedEventArgs<Image> e)
{
	base.OnElementChanged (e);
	this.Invalidate ();
}

protected override bool DrawChild (Canvas canvas, Android.Views.View child, long drawingTime)
{
	var radius = Math.Min (Width, Height) / 2;

	var strokeWidth = 10;
	radius -= strokeWidth / 2;

	Path path = new Path ();
	path.AddCircle (Width / 2, Height / 2, radius, Path.Direction.Ccw);
	canvas.Save ();
	canvas.ClipPath (path);

	var result = base.DrawChild(canvas, child, drawingTime);

	canvas.Restore ();

	path = new Path ();
	path.AddCircle (Width / 2, Height / 2, radius, Path.Direction.Ccw);

	var paint = new Paint ();
	paint.AntiAlias = true;
	paint.StrokeWidth = 10;
	paint.SetStyle (Paint.Style.Stroke);
	paint.Color = Android.Graphics.Color.Yellow;

	canvas.DrawPath (path, paint);

	paint.Dispose ();
	path.Dispose ();

	return result;
}

	}
}

