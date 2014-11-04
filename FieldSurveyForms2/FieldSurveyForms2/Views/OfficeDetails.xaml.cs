using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace FieldSurveyForms2.Views
{	
	public partial class OfficeDetails : ContentPage
	{	
		public OfficeDetails ()
		{
			InitializeComponent ();
			listProducts.ItemTemplate = new DataTemplate(typeof(ProductCell));
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			var getOfficeDetails = new GetOfficeDetails();
			var result = Task.Factory.StartNew(() => getOfficeDetails.InvokeAPIAsync(""));
			this.BindingContext = result.Result.Result;
			listProducts.ItemsSource = result.Result.Result.ProductDetails;
		}
	}
}

