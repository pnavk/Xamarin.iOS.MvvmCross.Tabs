using System;
using System.Threading.Tasks;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Tabs.Core
{
	public class TabsViewModel : MvxViewModel
	{
		private readonly IMvxNavigationService _navigationService;

		public TabsViewModel(IMvxNavigationService navigationService)
		{
			_navigationService = navigationService;
		}

		public Task SetupTabs()
		{
			return Task.WhenAll(
				_navigationService.Navigate(typeof(NewsFeedViewModel)),
				_navigationService.Navigate(typeof(RequestsViewModel)),
				_navigationService.Navigate(typeof(MessagesViewModel)),
				_navigationService.Navigate(typeof(NotificationsViewModel)),
				_navigationService.Navigate(typeof(MoreViewModel)
			));
		}
	}

	public class NewsFeedViewModel : MvxViewModel
	{
	}
	public class RequestsViewModel : MvxViewModel
	{
	}
	public class MessagesViewModel : MvxViewModel
	{
	}
	public class NotificationsViewModel : MvxViewModel
	{
	}
	public class MoreViewModel : MvxViewModel
	{
	}
}
