## More Information

1. [IBM Worklight Foundation home page](http://www.ibm.com/developerworks/mobile/worklight/index.html)
2. [IBM Worklight Foundation Knowledge Center](http://www-01.ibm.com/support/knowledgecenter/SSZH4A_6.2.0/)
3.  The C# API guide is bundled inside the component
4.  The sample Xamarin solution for Android and iOS is bundled in the component

## The IBM Worklight Add-in for Xamarin Studio

A Add-in is provided for the Xamarin Studio for IBM Worklight integration. This add-in prepares the development environment by

 1.  Creating the WL Server instance for the installation
 2.  Creating a Worklight project for the Xamarin solution that is active
 3.  Creating a Android Native App configuration and a iOS App configuration in the project
 4.  You can Start/stop the server as well as open the Worklight console in the browser

## Pre-requisites for a New Solution

 1.  You need an instance of the IBM Worklight Server on the development machine.  Install Worklight CLI (Command line Interface) from the [ IBM Worklight download page](http://www.ibm.com/developerworks/mobile/worklight/download/cli.html)
 2.  Create a new Xamarin Solution
 3.  Add a Android and/or iOS Project in the solution
 4.  Add this Component to the project 
 5.  Install the IBM Worklight Add-in 
  1.  Right click on the IBM Worklight Component and click on Open containing folder
  2.  Add the Add-in (.mpack file) via the Add-in panel from the component\addin folder
 6. Click on Menu>Tools>IBM Worklight>Start Server - this creates the Worklight setup
 7. The Worklight SDK needs a property file that contains information on how to connect to the Worklight Server. This information is pre populated (like the IP address of the server, application name etc) in the Worklight project the add-in created. Add them to the Xamarin Application projects.
  1. Android: Add  < Solution folder>\worklight\< SolutionName>\apps\android< SolutionName>\wlclient.properties to the Xamarin Android "Assets" folder and set the build action to 'AndroidAsset'. (e.g: \Xtest\worklight\Xtest\apps\androidXtest\wlclient.properties)
  2. iOS: Add < Solution folder>\worklight\< SolutionName>\apps\iOS< SolutionName>\worklight.plist to the Xamarin iOS "resources" folder and set the build action to 'bundleResource' (e.g: \Xtest\worklight\Xtest\apps\iOSXtest\worklight.plist)

**Note:** 

When you add the Worklight Xamarin Component to your project, the following DLLs get referenced in the project

1. Android project: add  Worklight.Android.dll and Worklight.Xamarin.Android.dll
2.  iOS project: add Worklight.iOS.dll and Worklight.Xamarin.iOS.dll

## Sample Application Quickstart

###Pre-requisites
 

1.  You need a instance of the IBM Worklight Server on the development machine.  Install Worklight CLI (Command line Interface) from the [ IBM Worklight download page](http://www.ibm.com/developerworks/mobile/worklight/download/cli.html)
2.  Install the add-in

###Open the samples in Xamarin Studio:

1. Open Xamarin Studio.
2. Select "File > Open"
3. Browse to the location of your unzipped "Xamarin Worklight component" directory and open the "/samples" folder
4. Select the "Xtest.sln" file and click "Open"

###Prepare the Worklight Server

1.  From the Add-in - click on "Start Server" - this will run for a while the first time
2.  Click on "Open Console" and login using username: admin and password: admin
3.  You should see the 2 apps and a SampleHTTPAdapter in the console
4.  Run the app in the simulator/real device


###Configure and run the iOS Sample

1. Right-click the "Xtest.iOS" project and select "Set As Startup Project"
2. Expand the "Xtest.iOS" project and double-click the file "worklight.plist" to open it in the property value editor.
3. In the property value editor find the entry for "host" and update its value to the "Server host" value.
4. Run the sample project by clicking Xamarin menu item "Run > Start Debugging"

##Additional Info

###Known Issues

 Add-in
 
 1. Depending on the developer environment, some times you can get a "Error: Process Timed out" message when you Start or Stop the server from the add-in.  to check if the server is running
  1. Open a command prompt or shell window
  2. Type ``` wl status ```
  3. You should see ``` Server worklight is running. Server worklight is listening on port 10080.```

Worklight CLI

1. On startup of the CLI you may get a error "Cannot find module generator-worklight.". You should upgrade the worklight CLI with teh patch or install the latest version of the CLI. [See Stackoverflow](http://stackoverflow.com/questions/26136870/is-worklight-cli-installer-broken) for a detailed discussion.

###Appendix I

Sample Commands for  Worklight CLI.

    wl create-server
    wl create <solutionName>
From within the  &lt;solutionName&gt;  directory

    wl add api <solutionName>Android -e android
    wl add api <solutionName>iOS -e ios
    wl start
    wl build
    wl deploy
    wl stop
    wl status

For a full list of the CLI commands see [the reference documentation](http://www-01.ibm.com/support/knowledgecenter/SSZH4A_6.2.0/com.ibm.worklight.dev.doc/dev/r_wl_cli_commands.html)

###Appendix II

Setting up a Xamarin development environment with Worklight Studio.

 1. Install Worklight studio from the [IBM website](http://www.ibm.com/developerworks/mobile/worklight/download/studio.html)
 2. Go to the "Servers" tab and Start the server
 3. File>New>Worklight Project . Project Template = Android;
 4. File>New>Worklight Native API; Environment = iOS
 5. Right click on the App >Run As> deploy Native API
 6. Copy the wlclient.properties and worklight.plist

