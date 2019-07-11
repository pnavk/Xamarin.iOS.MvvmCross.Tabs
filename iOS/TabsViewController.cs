using System;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using Tabs.Core;

namespace Tabs.iOS
{
	[MvxRootPresentationAttribute(WrapInNavigationController = false)]
	public class TabsViewController : MvxTabBarViewController<TabsViewModel>
	{
		private bool _tabsInitialized;

		public TabsViewController()
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
		}

		public override async void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);

			if (!_tabsInitialized) {
				await ViewModel.SetupTabs();
				_tabsInitialized = true;
			}
		}
	}
}
