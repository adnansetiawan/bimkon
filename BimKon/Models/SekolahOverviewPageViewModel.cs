using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using BimKon.Core.Repositories;
using Xamarin.Forms;
using static BimKon.Core.Enums;

namespace BimKon.Core.Models
{
    public class SekolahOverviewPageViewModel : BaseViewModel
    {
        private IJurusanDataSeed _jurusanDataSeed;
        public SekolahOverviewPageViewModel()
        {
            JurusanItems = new ObservableCollection<JurusanViewModel>();


        }
        public SchoolType SchoolType
        {
            get; set;
        }
        private ObservableCollection<JurusanViewModel> _jurusanItems;
        public ObservableCollection<JurusanViewModel> JurusanItems
        {
            get => _jurusanItems;
            set => SetProperty(ref _jurusanItems, value, nameof(JurusanItems));
        }
        private ICommand _init;
        public ICommand Init
        {
            get
            {

                _init = _init ?? new Command(() =>
                {
                    if (JurusanItems.Count == 0)
                    {
                        switch (SchoolType)
                        {
                            case SchoolType.SMK:
                                _jurusanDataSeed = new SMKDataSeed();
                                break;
                            case SchoolType.SMA:
                                _jurusanDataSeed = new SMADataSeed();
                                break;

                        }
                        if (_jurusanDataSeed != null)
                        {
                            _jurusanDataSeed.Seed();
                            JurusanItems = _jurusanDataSeed.JurusanItems;
                        }
                    }

                });
                return _init;
            }
        }
    }
}
