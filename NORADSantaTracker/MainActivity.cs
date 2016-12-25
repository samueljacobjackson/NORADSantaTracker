using Android.App;
using Android.OS;
using Android.Webkit;

namespace NORADSantaTracker
{
    [Activity(Label = "Santa Tracker", MainLauncher = true, Theme = "@android:style/Theme.NoTitleBar", ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]
    public class MainActivity : Activity
    {
        WebView webView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            SetContentView(Resource.Layout.Main);
           // Window.SetFlags(Android.Views.WindowManagerFlags.KeepScreenOn, Android.Views.WindowManagerFlags.TurnScreenOn);
            
            webView = FindViewById<WebView>(Resource.Id.webview);
            webView.Settings.JavaScriptEnabled = true;
            webView.LoadUrl("http://www.noradsanta.org/overlay/tracking/map/index.html");
        }
    }
}