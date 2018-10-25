using System;
using System.Collections.Generic;
using System.Linq;
using BimKon.Core.Models;
using Xamarin.Forms;
using static BimKon.Core.Enums;

namespace BimKon.Core
{
    public partial class SekolahOverviewPage : MasterPage
    {
        private SekolahOverviewPageViewModel _viewModel;
        private readonly SchoolType _schoolType;
        public SekolahOverviewPage(SchoolType schoolType)
        {
            InitializeComponent();
            _schoolType = schoolType;
            _viewModel.SchoolType = _schoolType;
            if (ToolbarItems.Count == 0)
            {
                ToolbarItems.Add(new ToolbarItem(string.Empty, "ic_tutorial_white_toolbar", async () =>
                {
                    await Navigation.PushModalAsync(new ProfilePage());

                }));
            }
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (!(BindingContext is SekolahOverviewPageViewModel vm))
            {
                return;
            }
            _viewModel = vm;
            _viewModel.Navigation = Navigation;
        }

        async void Handle_ItemSelected(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var item = ((ListView)sender).SelectedItem as JurusanViewModel;
            await Navigation.PushAsync(new PekerjaanPage(item), true);
        }

        private void RefreshListViewData(string filterBy = null)
        {

            IEnumerable<Grouping<string, JurusanViewModel>> grouped = null;
            if (string.IsNullOrEmpty(filterBy) || filterBy.Length < 3)
            {
                grouped = _viewModel.JurusanItems
                                      .OrderBy(j => j.Id)
                .GroupBy(
                                          j => j.ParentName,
                                          j => j,
                                          (key, j) => new Grouping<string, JurusanViewModel>(key, j));
            }
            else
            {

                grouped = _viewModel.JurusanItems.Where(x => x.ParentName.ToLower().Contains(filterBy.ToLower())
                                                        || x.Name.ToLower().Contains(filterBy.ToLower()))
                                     .OrderBy(j => j.Id)
               .GroupBy(
                                         j => j.ParentName,
                                         j => j,
                                         (key, j) => new Grouping<string, JurusanViewModel>(key, j));

            }


            JurusanListView.ItemsSource = new List<Grouping<string, JurusanViewModel>>(grouped);
            JurusanListView.IsGroupingEnabled = true;
            //JurusanListView.SelectedItem = null;
        }
        protected override void OnAppearing()
        {

            _viewModel.Init?.Execute(null);
            RefreshListViewData();


        }
        void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

            RefreshListViewData(SearchText.Text);

        }
    }
}
