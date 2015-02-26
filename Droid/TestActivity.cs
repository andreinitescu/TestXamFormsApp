
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Content.PM;
using Android.Util;

namespace TestXamFormsApp.Droid
{
	//[Activity (Label = "TestXamFormsApp.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class TestActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.TestActivity);
			// Create your application here
		}
	}

	public class MyView : FrameLayout
	{
		public MyView(Context context) : base(context)
		{
		}

		public MyView(Context context, IAttributeSet attrs) : base(context, attrs)
		{

			SetBackgroundResource (Resource.Drawable.shape);
		}
	}
}

