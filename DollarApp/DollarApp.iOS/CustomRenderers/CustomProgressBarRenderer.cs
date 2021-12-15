using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using DollarApp.iOS.CustomRenderers;
using Xamarin.Forms;
using CoreGraphics;

//string switch old progressbar on new
[assembly: ExportRenderer(typeof(ProgressBar), typeof(CustomProgressBarRenderer))]
namespace DollarApp.iOS.CustomRenderers
{
    public class CustomProgressBarRenderer : ProgressBarRenderer
    {
        //customing renderer progress bar
        protected override void OnElementChanged(ElementChangedEventArgs<ProgressBar> e)
        {
            base.OnElementChanged(e);

            if (double.IsNaN(e.NewElement.Progress))
                Control.ProgressTintColor = Color.FromHex("#00B9AE").ToUIColor();
            else if (e.NewElement.Progress < 0.3)
                Control.ProgressTintColor = Color.FromHex("#008DD5").ToUIColor();
            else if (e.NewElement.Progress < 0.5)
                Control.ProgressTintColor = Color.FromHex("#2D76BA").ToUIColor();
            else if (e.NewElement.Progress < 0.7)
                Control.ProgressTintColor = Color.FromHex("#5A5F9F").ToUIColor();
            else if (e.NewElement.Progress < 0.9)
                Control.ProgressTintColor = Color.FromHex("#B3316A").ToUIColor();
            else
                Control.ProgressTintColor = Color.FromHex("#E01A3F").ToUIColor();

            LayoutSubviews();
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            float x = 1.0f;
            float y = 4.0f;

            CGAffineTransform transform = CGAffineTransform.MakeScale(x, y);
            Transform = transform;
        }
        
    }
}
