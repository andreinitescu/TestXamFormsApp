using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using TestXamFormsApp.Controls;
using TestXamFormsApp.Droid.Renderers;
using Android.Views;
using Android.Graphics.Drawables;
using Android.Graphics;
using Android.Widget;

[assembly:ExportRendererAttribute(typeof(Border), typeof(BorderRenderer))]

namespace TestXamFormsApp.Droid.Renderers
{
	public class BorderRenderer : VisualElementRenderer<Border>
	{
		public BorderRenderer()
		{
			this.SetBackgroundColor (Android.Graphics.Color.Red);
			//this.SetBackgroundResource(Resource.Drawable.shape);
			this.SetPadding (200, 70, 70, 70);
		}
	}
}

