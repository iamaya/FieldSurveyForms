using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Xamarin.Forms;
using Worklight.Xamarin.iOS;

namespace WorklightSample.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			var splashDelay = Task.Delay (2000);

			Forms.Init ();

			App.WorklightClient =  new SampleClient ( WorklightClient.CreateInstance());

			window = new UIWindow (UIScreen.MainScreen.Bounds);
			
			window.RootViewController = App.GetMainPage ().CreateViewController ();
			window.MakeKeyAndVisible ();

			splashDelay.Wait ();
			
			return true;
		}
	}
}

