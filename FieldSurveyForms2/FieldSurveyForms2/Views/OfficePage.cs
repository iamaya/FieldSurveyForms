using FieldSurveyForms2.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FieldSurveyForms2.Models;
using FieldSurveyForms2.Models.ViewModels.SimplifiedViewModels;

namespace FieldSurveyForms2.Views
{
    public class OfficePage : ContentPage
    {
        ListView listView;
        RelativeLayout layout;

        public OfficePage()
        {
            Label header = new Label
            {
                Text = "Offices",
                Font = Font.SystemFontOfSize(35),
                HorizontalOptions = LayoutOptions.Center
            };

            listView = new ListView();
            listView.ItemTemplate = new DataTemplate(typeof(OfficeCells));

            var getOffices = new GetOffices();

            var result = Task.Factory.StartNew(() => getOffices.InvokeAPIAsync(""));
            try
            {
                var results = result.Result.Result.manifestdetails;

                var officePageManifestDetails = new List<OfficePageManifestDetails>();
                foreach (var item in results)
                {
                    officePageManifestDetails.Add(new OfficePageManifestDetails
                    {
                        Address1 = item.Address1,
                        Address2 = item.Address2,
                        City = item.City,
                        Company = item.Company,
                        ContactFirstName = item.ContactFirstName,
                        ContactLastName = item.ContactLastName,
                        IDAccount = item.IDAccount
                    });
                }

                listView.ItemsSource = officePageManifestDetails;
            }
            catch (Exception ex)
            {
                throw;
            }

            layout = new RelativeLayout();
            layout.Children.Add(
                listView,
                xConstraint: Constraint.Constant(0),
                yConstraint: Constraint.Constant(0),
                widthConstraint: Constraint.RelativeToParent((parent) => { return parent.Width; }),
                heightConstraint: Constraint.RelativeToParent((parent) => { return parent.Height; }));

            var stack = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { 
                    header,
                    layout
                }
            };

            Content = stack;
            Padding = new Thickness(40, 0, 0, 0);
        }
    }
}
