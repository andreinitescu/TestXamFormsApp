using System;
using Xamarin.Forms;

namespace TestXamFormsApp.Controls
{
	public class Border : ContentView	
	{
		/*public static readonly BindableProperty StrokeProperty = 
			BindableProperty.Create<Border,Color>(p => p.Stroke, Color.Transparent);

		public Color Stroke {
			get { return (Color)GetValue(StrokeProperty); }
			set { SetValue(StrokeProperty, value); }
		}*/

		public static readonly BindableProperty StrokeThicknessProperty = 
			BindableProperty.Create<Border,double>(p => p.StrokeThickness, default(double));

		public double StrokeThickness {
			get { return (double)GetValue (StrokeThicknessProperty); }
			set { SetValue (StrokeThicknessProperty, value); }
		}
	}
}

