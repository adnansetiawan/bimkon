using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BimKon.Core
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class MasterPage : ContentPage
    {
        public MasterPage()
        {
            NavigationPage.SetBackButtonTitle(this, " ");
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }

}

