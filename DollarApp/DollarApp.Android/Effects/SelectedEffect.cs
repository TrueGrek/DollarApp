using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DollarApp.Droid.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("LPA")]
[assembly: ExportEffect(typeof(SelectedEffect), "SelectedEffect")]
namespace DollarApp.Droid.Effects
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