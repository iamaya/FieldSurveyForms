using FieldSurveyForms2.DataAccess;
using FieldSurveyForms2.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FieldSurveyForms2.Views
{
    public partial class Manifests : ContentPage
    {
        public Manifests()
        {
            InitializeComponent();
            listView.ItemTemplate = new DataTemplate(typeof(ManifestCell));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var getManifests = new GetManifests();
            var result = Task.Factory.StartNew(() => getManifests.InvokeAPIAsync(""));
            listView.ItemsSource = result.Result.Result.manifestMasterview;
        }

        public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var eachManifest = e.SelectedItem as ManifestMasterViewModel;
            var officePage = new Offices();
            //todoPage.BindingContext = eachManifest;
            Navigation.PushAsync(officePage);
        }
    }
}
