﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using BimKon.Core;
using FFImageLoading.Forms.Droid;

namespace BimKon.Droid
{
    [Activity(Label = "BimKon", Icon = "@mipmap/icon", Theme = "@style/splashscreen", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            base.SetTheme(Resource.Style.MainTheme);

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
            CachedImageRenderer.Init(true);
            this.SupportActionBar.DisplayOptions = (int)ActionBarDisplayOptions.HomeAsUp;
            this.Window.ClearFlags(WindowManagerFlags.Fullscreen);


        }
    }
}