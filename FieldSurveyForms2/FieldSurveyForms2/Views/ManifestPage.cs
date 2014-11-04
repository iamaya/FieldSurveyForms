using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FieldSurveyForms2.Models;
using FieldSurveyForms2.DataAccess;

namespace FieldSurveyForms2.Views
{
   public class ManifestPage : ContentPage
    {
        ListView listView;
        RelativeLayout layout;

        public ManifestPage()
        {
            //Label header = new Label
            //{
            //    Text = "Manifests",
            //    Font = Font.SystemFontOfSize(35),
            //    HorizontalOptions = LayoutOptions.Center
            //};

            listView = new ListView();
            listView.ItemTemplate = new DataTemplate(typeof(ManifestCells));

            var getManifests = new GetManifests();

            var result = Task.Factory.StartNew(()=> getManifests.InvokeAPIAsync(""));
            listView.ItemsSource = result.Result.Result.manifestMasterview;

            layout = new RelativeLayout();

            layout.Children.Add(
                listView,
                xConstraint: Constraint.Constant(0),
                yConstraint: Constraint.Constant(0),
                widthConstraint: Constraint.RelativeToParent((parent) => { return parent.Width; }),
                heightConstraint: Constraint.RelativeToParent((parent) => { return parent.Height; }));
            
            var stack = new StackLayout
            {
             //   Orientation = StackOrientation.Vertical,
                Children = { 
                   // header
                    layout
                }
            };

            Content = stack;
            Padding = new Thickness(40, 0, 0, 0);
        }
    }
}