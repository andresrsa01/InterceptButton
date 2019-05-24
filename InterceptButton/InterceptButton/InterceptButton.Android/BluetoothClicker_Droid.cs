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
using InterceptButton.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(BluetoothClicker_Droid))]
namespace InterceptButton.Droid
{
    public class BluetoothClicker_Droid : IBluetoothClicker
    {

        public BluetoothClicker_Droid()
        {
        }

        public object GetVolumeOverride()
        {
            //CameraButton_Clicked = true;

            return true;

        }
    }
}
