using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platforms.Android.Views;
using Tabs.Core;

namespace Tabs.Droid
{
	[Activity(Theme = "@style/Theme.AppCompat", Label = "Tabs!")]
	public class TabsActivity : MvxAppCompatActivity<TabsViewModel>
	{
		public TabLayout TabLayout { get; set; }

		protected override async void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			SetContentView(Resource.Layout.Main);

			TabLayout = FindViewById<TabLayout>(Resource.Id.tabs);

			//await ViewModel.SetupTabs();
			//TabLayout.GetTabAt(0).Select();
		}
	}
}
