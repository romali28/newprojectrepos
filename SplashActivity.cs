using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Media;
using Android.OS;
using Android.Util;
using Android.Widget;
using FFImageLoading.Forms.Platform;
using Java.Lang;
using static Android.Provider.MediaStore;

namespace Vaamoz.Droid
{
    [Activity(Label = "Vaamoz", Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashActivity : Activity
    {
        static readonly string TAG = "X:" + typeof(SplashActivity).Name;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            FFImageLoading.Forms.Platform.CachedImageRenderer.Init(enableFastRenderer: false);
            //CachedImageRenderer.InitImageViewHandler();
            Log.Debug(TAG, "SplashActivity.OnCreate");
            System.Threading.Thread.Sleep(500);
            this.StartActivity(typeof(MainActivity));
        }
    }
}