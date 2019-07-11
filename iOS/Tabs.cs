using System;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using Tabs.Core;
using UIKit;

namespace Tabs.iOS
{
	public class Tabs
	{
		[MvxTabPresentation(TabName = "News Feed", TabIconName = "unselected", TabSelectedIconName = "selected", WrapInNavigationController = true)]
		public class NewsFeedViewController : MvxViewController<NewsFeedViewModel>
		{
			public override void ViewDidLoad()
			{
				base.ViewDidLoad();

				View.BackgroundColor = UIColor.Red;
				NavigationItem.Title = "News Feed";
			}
		}

		[MvxTabPresentation(TabName = "Requests", TabIconName = "unselected", TabSelectedIconName = "selected", WrapInNavigationController = true)]
		public class RequestsViewController : MvxViewController<RequestsViewModel>
		{
			public override void ViewDidLoad()
			{
				base.ViewDidLoad();

				NavigationItem.Title = "Requests";
				View.BackgroundColor = UIColor.Blue;
			}
		}

		[MvxTabPresentation(TabName = "Messages", TabIconName = "unselected", TabSelectedIconName = "selected", WrapInNavigationController = true)]
		public class MessagesViewController : MvxViewController<MessagesViewModel>
		{
			public override void ViewDidLoad()
			{
				base.ViewDidLoad();

				NavigationItem.Title = "Messages";
				View.BackgroundColor = UIColor.Green;
			}
		}

		[MvxTabPresentation(TabName = "Notifications", TabIconName = "unselected", TabSelectedIconName = "selected")]
		public class NotificationsViewController : MvxViewController<NotificationsViewModel>
		{
			public override void ViewDidLoad()
			{
				base.ViewDidLoad();

				NavigationItem.Title = "Notifications";
				View.BackgroundColor = UIColor.Purple;
			}
		}

		[MvxTabPresentation(TabName = "More", TabIconName = "unselected", TabSelectedIconName = "selected")]
		public class MoreViewController : MvxViewController<MoreViewModel>
		{
			public override void ViewDidLoad()
			{
				base.ViewDidLoad();

				Title = "More";
				View.BackgroundColor = UIColor.Yellow;
			}
		}
	}
}
