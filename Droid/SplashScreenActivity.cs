using Android.App;
using MvvmCross.Droid.Support.V7.AppCompat;
using Tabs.Core;

namespace Tabs.Droid
{
	[Activity(Theme = "@style/Theme.AppCompat", Label = "SplashScreen", MainLauncher = true, NoHistory = true)]
	public class SplashScreen : MvxSplashScreenAppCompatActivity<MvxAppCompatSetup<App>, App>
	{
		public SplashScreen() : base(Resource.Layout.SplashScreen)
		{
		}

		public SplashScreen(int resourceId = 0) : base(Resource.Layout.SplashScreen)
		{
		}
	}
}
