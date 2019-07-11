using System;
using MvvmCross.ViewModels;

namespace Tabs.Core
{
	public class App : MvxApplication
	{
		public App()
		{
		}

		public override void Initialize()
		{
			base.Initialize();

			RegisterAppStart<TabsViewModel>();
		}
	}
}
