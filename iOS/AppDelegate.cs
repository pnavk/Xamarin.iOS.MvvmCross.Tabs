using Foundation;
using MvvmCross.Platforms.Ios.Core;
using Tabs.Core;
using UIKit;

namespace Tabs.iOS
{
	[Register("AppDelegate")]
	public class AppDelegate : MvxApplicationDelegate<MvxIosSetup<App>, App>
	{
	}
}

