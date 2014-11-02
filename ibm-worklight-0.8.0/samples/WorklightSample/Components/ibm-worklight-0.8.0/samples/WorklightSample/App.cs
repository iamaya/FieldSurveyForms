using System;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WorklightSample
{
	public class App
	{
		/// <summary>
		/// Gets or sets the worklight sample client.
		/// </summary>
		/// <value>The worklight client.</value>
		public static SampleClient WorklightClient {get; set;}

		public static Page GetMainPage ()
		{	
			var navigationPage = new NavigationPage (new HomePage ());
			navigationPage.BarBackgroundColor = Color.XamarinBlue.ToFormsColor ();
			navigationPage.BarTextColor = Xamarin.Forms.Color.White; 

			return navigationPage;
		}
	}


}

