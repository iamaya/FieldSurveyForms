using FieldSurveyForms2.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FieldSurveyForms2.Views
{
    public partial class Offices : ContentPage
    {
        public Offices()
        {
            InitializeComponent();
            listView.ItemTemplate = new DataTemplate(typeof(OfficeCell));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var getOffices = new GetOffices();
            var result = Task.Factory.StartNew(() => getOffices.InvokeAPIAsync(""));
            listView.ItemsSource = result.Result.Result.manifestdetails;
        }

		public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			//var eachManifest = e.SelectedItem as ManifestMasterViewModel;
			var officeDetailsPage = new OfficeDetails();
			//todoPage.BindingContext = eachManifest;
			Navigation.PushAsync(officeDetailsPage);
		}
    }
}
