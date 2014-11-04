using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FieldSurveyForms2.Views
{
    public partial class ManifestItems : ContentView
    {
        public ManifestItems()
        {
            InitializeComponent();
        }
    }


    public class ManifestCell : ViewCell
    {
        public ManifestCell()
        {
            View = new ManifestItems();
        }
    }
}
