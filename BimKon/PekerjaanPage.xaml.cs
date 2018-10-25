using System;
using System.Collections.Generic;
using BimKon.Core.Models;
using Xamarin.Forms;

namespace BimKon.Core
{
    public partial class PekerjaanPage : MasterPage
    {
        private PekerjaanPageViewModel _viewModel;
        private JurusanViewModel _fromJurusan;
        public PekerjaanPage(JurusanViewModel fromJurusan)
        {
            InitializeComponent();
            _fromJurusan = fromJurusan;
            PekerjaanListView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                if (e.SelectedItem == null) return;



                ((ListView)sender).SelectedItem = null;
            };

        }
        protected override void OnAppearing()
        {
            Title = $"{_fromJurusan?.Name}";
            JurusanTitle.Text = $"Lingkup Pekerjaan : {_fromJurusan?.Name}";
            if (_fromJurusan != null)
            {
                _viewModel.Init.Execute(_fromJurusan);
            }
            PekerjaanListView.ItemsSource = _viewModel.PekerjaanItems;
        }
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (!(BindingContext is PekerjaanPageViewModel vm))
            {
                return;
            }
            _viewModel = vm;
            _viewModel.Navigation = Navigation;
        }
    }
}
