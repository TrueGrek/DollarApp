using DollarApp.iOS.Effects;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("LPA")]
[assembly: ExportEffect(typeof(SelectedEffect), "SelectedEffect")]
namespace DollarApp.iOS.Effects
{
    public class SelectedEffect : PlatformEffect
    {
        public SelectedEffect()
        {

        }
        protected override void OnAttached()
        {
           
        }

        protected override void OnDetached()
        {
            
        }
    }
}