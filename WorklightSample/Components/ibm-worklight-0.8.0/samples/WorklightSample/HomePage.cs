using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace WorklightSample
{
	public class HomePage : ContentPage
	{
		#region Fields
		private RelativeLayout indicatorLayout = null;
		private ListView listView = null;
		private ActivityIndicator activityIndicator = null;
		bool busy = false;

		#endregion

		#region Constructors
		public HomePage ()
		{
			BackgroundColor = Color.XamarinLightGray.ToFormsColor ();
			Title = "Worklight Sample";

			var activityIndicatorColor = new Xamarin.Forms.Color (Color.XamarinGray.R, Color.XamarinGray.G, Color.XamarinGray.B, .4);

			activityIndicator = new ActivityIndicator{
				Color = Xamarin.Forms.Color.Black,
				BackgroundColor = new Xamarin.Forms.Color (0, 0, 0, 0),
				IsRunning = false,
				IsVisible = true
			};

			listView = new ListView {
				RowHeight = 40,
				BackgroundColor = Xamarin.Forms.Color.White,
				VerticalOptions = LayoutOptions.Start
			};

			listView.ItemsSource = new [] {
				new CommandItem { Command = "Connect", Image = "connect.png", ItemSelected = OnConnect },
				new CommandItem { Command = "Invoke Procedure", Image = "invoke.png", ItemSelected = OnInvokeProcedure },
				new CommandItem { Command = "Subscribe", Image = "subscribe.png", ItemSelected = OnSubscribe },
				new CommandItem { Command = "Unsubscribe", Image = "unsubscribe.png", ItemSelected = OnUnSubscribe },
				new CommandItem { Command = "Is Subscribed", Image = "issubscribed.png", ItemSelected = OnIsSubscribed },
				new CommandItem { Command = "Is Push Supported", Image = "issubscribed.png", ItemSelected = OnIsPushEnabled },
				new CommandItem { Command = "Log Activity", Image = "logactivity.png", ItemSelected = OnSendActivity },
			};

			listView.ItemTemplate = new DataTemplate (typeof(CommandCell));

			listView.ItemSelected += (sender, e) => {
				if (e.SelectedItem == null) return;

				(e.SelectedItem as CommandItem).ItemSelected ();
				listView.SelectedItem = null; 
			};

			Content = CreateLayout (activityIndicatorColor);
		}

		#endregion

		#region Properties
		private bool Busy {
			get {
				return busy;
			} 
			set {

				if (busy != value) {
					busy = value;
					if (busy) {
						listView.IsVisible = true;
						listView.IsEnabled = false;
						activityIndicator.IsRunning = true;
						indicatorLayout.IsVisible = true;
					} 
					else {
						listView.IsVisible = true;
						listView.IsEnabled = true;
						activityIndicator.IsRunning = false;
						indicatorLayout.IsVisible = false;
					}
				}

			}
		}
		#endregion

		#region Layout Methods
		private RelativeLayout CreateLayout (Xamarin.Forms.Color activityIndicatorColor)
		{
			var relativeLayout = new RelativeLayout ();
			indicatorLayout = new RelativeLayout {
				IsVisible = false
			};

			indicatorLayout.Children.Add (new ContentView {
				BackgroundColor = activityIndicatorColor
			}, Constraint.Constant (0), Constraint.Constant (0), 
				Constraint.RelativeToParent (parent => parent.Width), 
				Constraint.RelativeToParent (parent => parent.Height));

			indicatorLayout.Children.Add (activityIndicator, 
				Constraint.RelativeToParent (parent => parent.Width / 2 - 25), 
				Constraint.RelativeToParent (parent => parent.Height / 2 - 25), 
				Constraint.Constant (50), Constraint.Constant (50));

			relativeLayout.Children.Add (listView, Constraint.Constant (0), Constraint.Constant (0));
			relativeLayout.Children.Add (indicatorLayout, Constraint.Constant (0), Constraint.Constant (0), 
				Constraint.RelativeToParent (parent => parent.Width), 
				Constraint.RelativeToParent (parent => parent.Height));

			return relativeLayout;
		}
		#endregion

		#region Selection Handlers
		private async void OnConnect ()
		{
			ShowWorking();
			var result = await App.WorklightClient.ConnectAsync();
			await HandleResult(result, "Connect Result");
		}

		private async void OnInvokeProcedure ()
		{
			ShowWorking();
			var result = await App.WorklightClient.InvokeAsync();
			await HandleResult(result, "Invoke Result", true);
		}

		private async void OnSendActivity ()
		{
			ShowWorking();
			var result = await App.WorklightClient.SendActivityAsync();
			await HandleResult(result, "Send Activity Result");
		}

		private async void OnSubscribe()
		{

			var result = await App.WorklightClient.SubscribeAsync((res)=>
			{
				Busy = false;
			});


			if (result.Success)
			{
				ShowWorking();
			}
			else
			{
				await HandleResult(result, "Subscribe Result");
			}
		}

		private async void OnUnSubscribe()
		{
			ShowWorking();
			var result = await App.WorklightClient.UnSubscribeAsync();
			await HandleResult(result, "Unsubcribe Result", true);
		}

		private void OnIsSubscribed()
		{
			DisplayAlert("Subcribiption Status", String.Format("{0} subscribed", (App.WorklightClient.IsSubscribed) ? "Is" : "Isn't"),"OK");
		}

		private void OnIsPushEnabled()
		{
			DisplayAlert("Push Status", String.Format("Push {0} supported", (App.WorklightClient.IsSubscribed) ? "Is" : "Isn't"),"OK");
		}

		#endregion

		#region private methods
		private async Task HandleResult(WorklightResult result, String title, bool ShowOnSuccess = false)
		{
			Busy = false;

			if (result.Success)
			{
				if (ShowOnSuccess)
				{
					await Navigation.PushAsync (new ResultPage(result) {
						Title = title,
					});
				}
				else
				{
					await DisplayAlert(title,result.Message, "OK");
				}

			}
			else
			{
				await Navigation.PushAsync (new ResultPage(result) {
					Title = title,
				});
			}
		}

		private async void ShowWorking(int timeout = 15)
		{
			Busy = true;

			await Task.Delay(TimeSpan.FromSeconds(timeout));

			if (Busy)
			{
				Busy = false;
				await DisplayAlert("Timeout", "Call timed out", "OK");

			}

		}

		#endregion
	}
}

