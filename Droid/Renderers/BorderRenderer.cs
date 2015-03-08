using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using TestXamFormsApp.Controls;
using TestXamFormsApp.Droid.Renderers;
using Android.Views;
using Android.Graphics.Drawables;
using Android.Graphics;
using Android.Widget;
using System.Linq;
using System.ComponentModel;

[assembly:ExportRendererAttribute(typeof(Border), typeof(BorderRenderer))]

namespace TestXamFormsApp.Droid.Renderers
{
	public class BorderRenderer : VisualElementRenderer<Border>
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Border> e)
		{
			base.OnElementChanged (e);
			UpdateBackground ();
		}

		void UpdateBackground()
		{
			var d = new GradientDrawable ();

			// set drawable color based on Border's color
			d.SetColor (Element.BackgroundColor.ToAndroid ()); 

			// set drawable stroke thickness and color based on Border's stroke thickiness
			d.SetStroke ((int)Context.ToPixels (Element.StrokeThickness), Android.Graphics.Color.Black); 

			// set padding to take into account the drawable stroke thickiness
			SetPadding ((int)Element.StrokeThickness, (int)Element.StrokeThickness, (int)Element.StrokeThickness, (int)Element.StrokeThickness);

			// set drawable
			SetBackgroundDrawable (d); 
		}
	}
}

