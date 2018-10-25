using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BimKon.Core
{
    public partial class ProfilePage : MasterPage
    {
        public ProfilePage()
        {
            InitializeComponent();

        }

        async void OnClose_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            VersionLabel.Text = $"Versi : {App.Version}";
            DescriptionLabel.Text = "Aplikasi ini dibuat sebagai pembantu pemilihan Sekolah Lanjutan untuk siswa SMP berdasarkan minat mereka";
            DescriptionLabel.Text += "\n";
        }
    }
}
