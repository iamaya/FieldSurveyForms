using System;
using System.Collections.Generic;
using Xamarin.Forms;
using FieldSurveyForms2.Helpers;
//using Xamarin.Forms.Labs.Services;
//using Xamarin.Forms.Labs.Services.Media;
//using Xamarin.Forms.Labs;
using System.Threading.Tasks;

namespace FieldSurveyForms2.Views
{
	public partial class ProductItems : ContentView
	{
	//	Xamarin.Forms.Labs.Services.Media.IMediaPicker _mediaPicker = DependencyService.Get<Xamarin.Forms.Labs.Services.Media.IMediaPicker> ();

		/// <summary>
		/// The _scheduler.
		/// </summary>
	//	private readonly TaskScheduler scheduler = TaskScheduler.FromCurrentSynchronizationContext();

		/// <summary>
		/// The _picture chooser.
		/// </summary>
	//	private Xamarin.Forms.Labs.Services.Media.IMediaPicker mediaPicker;

		/// <summary>
		/// The _image source.
		/// </summary>
//		private ImageSource imageSource;

		/// <summary>
		/// The _video info.
		/// </summary>
//		private string videoInfo;


		public ProductItems ()
		{
			InitializeComponent ();
		

			//Setup ();
		}


		public void  AddPicture(object sender, EventArgs args)
		{
//			Setup ();
//
//			imageSource = null;
//			try {
//				var mediaFile = await this._mediaPicker.SelectPhotoAsync (new CameraMediaStorageOptions {
//					DefaultCamera = CameraDevice.Front,
//					MaxPixelDimension = 400
//				});
//				imageSource = ImageSource.FromStream(() => mediaFile.Source);
//			} catch (System.Exception ex) {
//
//			}

		//	Xamarin.Forms.Device.BeginInvokeOnMainThread( () => {
		//		Navigation.PushAsync (new PictureManager ());});
//

		}

//		private void Setup()
//		{
//			if (mediaPicker != null)
//			{
//				return;
//			}
//
//			var device = Resolver.Resolve<IDevice>();
//
//			mediaPicker = DependencyService.Get<Xamarin.Forms.Labs.Services.Media.IMediaPicker>();
//			////RM: hack for working on windows phone? 
//			if (mediaPicker == null)
//			{
//				mediaPicker = device.MediaPicker;
//			}
//		}

	}


    public class ProductCell : ViewCell
    {
        public ProductCell()
        {
            View = new ProductItems();
			Height = 220;
        }
    }
}

