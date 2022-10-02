[assembly: Xamarin.Forms.ExportEffect(typeof(DemoEffect.Droid.DropShadowEffect), nameof(DemoEffect.Droid.DropShadowEffect))]

namespace DemoEffect.Droid
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Android.App;
    using Android.Content;
    using Android.OS;
    using Android.Runtime;
    using Android.Views;
    using Android.Widget;
    
    using Xamarin.Forms.Platform.Android;

    public class DropShadowEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            Android.Views.View myNativeControl = Control;
            if (myNativeControl == null)
                myNativeControl = Container as Android.Views.View;


            var myEffect = Element.Effects.FirstOrDefault(e => e is DemoEffect.DropShadowEffect);
            if(myEffect != null)
                myNativeControl.Elevation = 25.0f;
               
        }

        protected override void OnDetached()
        {
        }

    }
}