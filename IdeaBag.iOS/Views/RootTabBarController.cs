using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace IdeaBag.Client.iOS
{
	partial class RootTabBarController : UITabBarController, IUITabBarControllerDelegate
	{

		UIViewController _settingsTab;
		UIViewController _mapTab;
		UIViewController _ideasTab;
		UIViewController _contactsTab;
		UIViewController _notificationsTab;



		public RootTabBarController(){

		//- Set Tab Bar Background Color
			this.TabBar.BackgroundColor = UIColor.FromRGBA(255,0,0,0);
			//this.TabBar.BarTintColor = UIColor.Red;
			this.TabBar.ItemPositioning = UITabBarItemPositioning.Fill;
			//this.TabBar.Center = new CoreGraphics.CGPoint (0, 10);

			//- Settings
			_settingsTab = new IdeaBag.Client.iOS.Views.LoginViewController();
			_settingsTab.TabBarItem = new UITabBarItem("",
				UIImage.FromBundle("settings-tab").ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal),
				UIImage.FromBundle("settings-tab").ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal)
			);

			//- Ideas
			_ideasTab = new UIViewController();
			_ideasTab.View.BackgroundColor = UIColor.White;
			_ideasTab.TabBarItem = new UITabBarItem("",
				UIImage.FromBundle("ideas-tab").ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal),
				UIImage.FromBundle("ideas-tab-selected").ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal)
			);
			_ideasTab.TabBarItem.ImageInsets = new UIEdgeInsets (4, 0, -4, 0);


			//- Notifications
			_notificationsTab = new NotificationsViewController();
			_notificationsTab.TabBarItem = new UITabBarItem("",
				UIImage.FromBundle("notification-tab").ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal),
				UIImage.FromBundle("notification-tab").ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal)
			);


			//- Contacts
			_contactsTab = new UIViewController();
			_contactsTab.TabBarItem = new UITabBarItem("",
				UIImage.FromBundle("friends-tab").ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal),
				UIImage.FromBundle("friends-tab").ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal)
			);
			_contactsTab.View.BackgroundColor = UIColor.White;


			//- Map
			_mapTab = new UIViewController();
			_mapTab.TabBarItem = new UITabBarItem("",
				UIImage.FromBundle("map-tab").ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal),
				UIImage.FromBundle("map-tab").ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal)
			);
			_mapTab.View.BackgroundColor = UIColor.White;

			var tabs = new UIViewController[] {
				_settingsTab, 
				_ideasTab, 
				_notificationsTab,
				_contactsTab,
				_mapTab
			};

			this.ViewControllers = tabs;
		}

		public RootTabBarController (IntPtr handle) : base (handle)
		{
			///  Setup Tabs 

			//- Settings
			_settingsTab = new UIViewController();
			_settingsTab.Title = "Settings";
			_settingsTab.View.BackgroundColor = UIColor.Red;

			//- Ideas
			_ideasTab = new UIViewController();
			_ideasTab.Title = "Ideas";
			_ideasTab.View.BackgroundColor = UIColor.Purple;

			//- Notifications
			_notificationsTab = new UIViewController();
			_notificationsTab.TabBarItem = new UITabBarItem("Notifications",
				UIImage.FromBundle("image-1.imageset").ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal),
				UIImage.FromBundle("image-1.imageset").ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal)
			);
			//_notificationsTab.Title = "Notifications";
			//_notificationsTab.View.BackgroundColor = UIColor.Yellow;

			//- Contacts
			_contactsTab = new UIViewController();
			_contactsTab.Title = "Friends";
			_contactsTab.View.BackgroundColor = UIColor.Green;

			//- Map
			_mapTab = new UIViewController();
			_mapTab.Title = "Mapz";
			_mapTab.View.BackgroundColor = UIColor.Blue;

			var tabs = new UIViewController[] {
				_settingsTab, 
				_ideasTab, 
				_notificationsTab,
				_contactsTab,
				_mapTab
			};

			this.ViewControllers = tabs;
		}
	}
}
