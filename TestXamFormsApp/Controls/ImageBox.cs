using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace TestXamFormsApp.Controls
{
	public class ImageBox : Image
	{
		Size? imageSize;

		/*[TypeConverter(typeof(ImageSourceConverter))]
		public static readonly BindableProperty SourceProperty =
			BindableProperty.Create<ImageBox, ImageSource>(p => p.Source, default(ImageSource));

		public ImageSource Source
		{
			get
			{
				return (ImageSource)base.GetValue(ImageBox.SourceProperty);
			}
			set
			{
				base.SetValue(ImageBox.SourceProperty, value);
			}
		}*/

		protected override void OnPropertyChanged (string propertyName)
		{
			base.OnPropertyChanged (propertyName);
			if (propertyName == "Source") {
				UpdateImageSize ();
			}
		}

		protected override SizeRequest OnSizeRequest(Double widthConstraint, Double heightConstraint)
		{
			if (imageSize == null) {
				return new SizeRequest ();
			}

			if (Double.IsInfinity (heightConstraint)) {
				heightConstraint = widthConstraint * imageSize.Value.Width / imageSize.Value.Height;
			} else {
				widthConstraint = heightConstraint * imageSize.Value.Width / imageSize.Value.Height;
			}
			return new SizeRequest(new Size(widthConstraint, heightConstraint));
		}

		async void UpdateImageSize()
		{
			imageSize = null;
			imageSize = await DependencyService.Get<ImageService> ().Measure (Source);
			InvalidateMeasure ();
		}
	}


	public interface ImageService
	{
		Task<Size> Measure(ImageSource imageSource);
	}
}

