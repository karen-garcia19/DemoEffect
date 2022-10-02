[assembly: Xamarin.Forms.ExportEffect(typeof(DemoEffect.iOS.DropShadowEffect), nameof(DemoEffect.iOS.DropShadowEffect))]

namespace DemoEffect.iOS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Foundation;
    using ObjCRuntime;
    using UIKit;

    using Xamarin.Forms;
    using Xamarin.Forms.Platform.iOS;

    public class DropShadowEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            UIView myNativeControl = Control;
            if (myNativeControl == null)
                myNativeControl = Container;

            DemoEffect.DropShadowEffect  myEffect = (DemoEffect.DropShadowEffect)Element.Effects.FirstOrDefault(e => e is DemoEffect.DropShadowEffect);
            if(myEffect != null)
            {
                myNativeControl.Layer.MasksToBounds = false;
                myNativeControl.Layer.ShadowColor = UIColor.Black.CGColor;
                myNativeControl.Layer.ShadowOffset = new CoreGraphics.CGSize(-1, 1);
                myNativeControl.Layer.ShadowRadius = 5f;
            }
        }

        protected override void OnDetached()
        {   
        }
    }
}