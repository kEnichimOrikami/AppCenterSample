using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace AppCenterSample
{
    public partial class App : Application
    {
        const string uwpKey = "c7cf3ca6-9d41-4f10-8394-36e6bafbff56";
        const string iosKey = "65e278f2-90a1-4001-a72d-1f09889444c3";
        const string androidKey = "aa118b57-66b8-4da8-989d-96c6c2543640";

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            AppCenter.Start($"uwp={uwpKey};android={androidKey};ios={iosKey};", 
                            typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
