using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DollarApp.Droid.Effects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        Android.Graphics.Color selectedColor;
        public SelectedEffect()
        {
            
        }
        protected override void OnAttached()
        {
            selectedColor = new Android.Graphics.Color(255, 231, 219);
        }
        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            try
            {
                if (args.PropertyName == "IsFocused")
                {
                    if (((ColorDrawable)Control.Background).Color != selectedColor)
                    {
                        Control.SetBackgroundColor(selectedColor);
                    }
                    else
                    {
                        Control.SetBackgroundColor(Android.Graphics.Color.White);
                    }
                }
            }
            catch (InvalidCastException)
            {
                Control.SetBackgroundColor(selectedColor);
            }
            
        }

        protected override void OnDetached()
        {
            
        }
    }
}