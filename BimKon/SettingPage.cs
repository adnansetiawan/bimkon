using System;

using Xamarin.Forms;

namespace BimKon.Core
{
    public class SettingPage : ContentPage
    {
        public SettingPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

