using System;
using System.Threading.Tasks;
using MonoTouch.UIKit;
using Xamarin.Forms.Labs.Services.Media;
using  FieldSurveyForms2.iOS.MediaServices.Delegates;

namespace FieldSurveyForms2.iOS.MediaServices
{
	public sealed class MediaPickerController
		: UIImagePickerController
	{
		internal MediaPickerController (MediaPickerDelegate mpDelegate)
		{
			base.Delegate = mpDelegate;
		}

		public override MonoTouch.Foundation.NSObject Delegate
		{
			get { return base.Delegate; }
			set { throw new NotSupportedException(); }
		}

		public Task<MediaFile> GetResultAsync()
		{
			return ((MediaPickerDelegate)Delegate).Task;
		}
	}
}
