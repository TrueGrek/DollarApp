using DollarApp.Interface;
using DollarApp.iOS.Dependencies;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(Share))]
namespace DollarApp.iOS.Dependencies
{
    public class Share : IShare
    {
        public async Task Show(string title, string message, string filePath)
        {
            var viewController = GetVisibleViewController();
            var items = new NSObject[]
            {
                NSObject.FromObject(title), 
                NSUrl.FromFilename(filePath)
            };
            var activityController = new UIActivityViewController(items, null);

            if (activityController.PopoverPresentationController != null)
                activityController.PopoverPresentationController.SourceView = viewController.View;

            await viewController.PresentViewControllerAsync(activityController, true);

        }

        private UIViewController GetVisibleViewController()
        {
            var rootViewController = UIApplication.SharedApplication.KeyWindow.RootViewController;

            if (rootViewController.PresentedViewController == null)
                return rootViewController;
            if (rootViewController.PresentedViewController is UINavigationController)
                return ((UINavigationController)rootViewController).TopViewController;
            if (rootViewController.PresentedViewController is UITabBarController)
                return ((UITabBarController)rootViewController).SelectedViewController;


            return rootViewController.PresentedViewController;
        }
    }
}