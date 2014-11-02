## IBM Worklight Foundation SDK

The IBM Worklight Foundation SDK enables C# developers to build rich native enterprise grade mobile apps for iOS, android and Windows devices by using IBM Worklight server

#### Key Highlights
* Single, secure point of integration, management, deployment supporting the full mobile app lifecycle
* Access your enterprise backend using Worklight Adapters
* Enterprise grade security for your mobile applications  
* Application management and version control
* Leverage rich analytics support of Worklight
* Simplified push notification management service
* Use your own strongly-typed C# objects and async/await patterns.
* Use a unified C#API  for iOS and Android.
* **Do it all using C#.**

###Dive In

A unified API is provided for iOS and Android. You can write most of the IBM Worklight related code will reside in a common shared project to be used in the Android and iOS project. You can write all the asynchronous code using async/await and event listeners to make your app responsive.

The following code is a simplified subset of the code located in the samples. The sample walks through calling into an IBM Worklight adapter returns a feed of news articles and is formatted for pretty printing in common code.

In the Android Activity instantiate the Android specific WorklightClient

```csharp
public class MainActivity : Activity
{
	IWorklightClient client = Worklight.Xamarin.Android.WorklightClient.CreateInstance (this);
}
```

In the iOS UIViewController instantiate the iOS specific WorklightClient

```csharp
public partial class Xtest_iOSViewController : UIViewController
{
	public override void ViewDidLoad ()
	{
		base.ViewDidLoad ();
		WorklightUtils wlUtils = new WorklightUtils ( Worklight.Xamarin.iOS.WorklightClient.CreateInstance ());
	}
}
```

After this you can use the instance of IWorklightClient to write platform agnostic common code . 
You first connect to the Worklight server and register a Challenge handler for authentication. Along the way we can write to the local logging as well as the server based Analytics logging.

```csharp
//all this is common code
public async Task<WorklightResponse> Connect()
{
	string appRealm = "SampleAppRealm";
	ChallengeHandler customCH = new CustomChallengeHandler (appRealm);
	client.RegisterChallengeHandler(customCH);
	WorklightResponse task = await client.Connect ();
	//lets log to the local client (not server)
	client.Logger("Xamarin").Trace ("connection");
	//write to the server the connection status
	client.Analytics.Log ("Connect response : " + task.Success);
	return task;
}
```

Then invoke a procedure 

```csharp
//Common code
WorklightProcedureInvocationData invocationData = new WorklightProcedureInvocationData("SampleHTTPAdapter", "getStories", new object[] {"technology"});
WorklightResponse task = await client.InvokeProcedure(invocationData);
StringBuilder retval = new StringBuilder();
if (task.Success)
{
	JsonArray jsonArray = (JsonArray)task.ResponseJSON["rss"]["channel"]["item"];
	foreach(JsonObject title in jsonArray)
	{
		System.Json.JsonValue titleString ;
		title.TryGetValue("title",out titleString);
		retval.Append(titleString.ToString());
		retval.AppendLine();
	}
}
```

Please see the sample for more details. 

