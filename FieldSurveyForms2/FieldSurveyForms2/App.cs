using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using FieldSurveyForms2.Views;
using System.Threading.Tasks;
using FieldSurveyForms2.DataAccess;
using FieldSurveyForms2.Models.ViewModels;

namespace FieldSurveyForms2
{
    public class App
    {
        public static Page GetMainPage()
        {
           // return new ManifestPage();

            var manifests = new Manifests();
            var getManifests = new GetManifests();
            var result = Task.Factory.StartNew(() => getManifests.InvokeAPIAsync(""));
            manifests.BindingContext = result.Result.Result.manifestMasterview;

            //List<ManifestMasterViewModel> data = new List<ManifestMasterViewModel>();

            //data.Add(new ManifestMasterViewModel {
            //UserFirstName = "XYZ", UserLastName ="ABC", ServiceZone_Name = "Some"
            //});

         //   manifests.BindingContext = data;
            var mainNav = new NavigationPage(manifests);

            return mainNav;

           // return manifests;
        }
    }
}