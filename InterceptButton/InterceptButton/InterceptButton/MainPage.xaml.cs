using Android.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InterceptButton
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            CameraImage.Source = "CameraImage.png";
            TakePhotoButton.Clicked += CameraButton_Clicked; //opens camera

            Func<object> func = () =>
            {
                var obj = DependencyService.Get<IBluetoothClicker>().GetVolumeOverride();
                //obj += CameraButton_Clicked;
                return obj;
            };

            MessagingCenter.Subscribe<App, string>(App.Current, "OpenPage", (snd, arg) =>
            {
                Device.BeginInvokeOnMainThread(() => {
                    CameraImage.Source = arg;
                });
            });
        }

        private void CameraButton_Clicked(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}
