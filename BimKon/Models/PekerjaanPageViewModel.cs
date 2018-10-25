using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using BimKon.Core.Repositories;
using Xamarin.Forms;

namespace BimKon.Core.Models
{
    public class PekerjaanPageViewModel : BaseViewModel
    {
        private IPekerjaanDataSeed _pekerjaanDataSeed;
        public PekerjaanPageViewModel()
        {
            _pekerjaanItems = new ObservableCollection<PekerjaanViewModel>();
        }
        private ObservableCollection<PekerjaanViewModel> _pekerjaanItems;
        public ObservableCollection<PekerjaanViewModel> PekerjaanItems
        {
            get => _pekerjaanItems;
            set => SetProperty(ref _pekerjaanItems, value, nameof(PekerjaanItems));
        }
        private ICommand _init;
        public ICommand Init
        {
            get
            {

                _init = _init ?? new Command<JurusanViewModel>((jurusan) =>
                {
                    if (jurusan?.Sekolah?.Name.ToLower() == Enums.SchoolType.SMK.ToString().ToLower())
                    {
                        _pekerjaanDataSeed = new SMKPekerjaanDataSeed();
                        _pekerjaanDataSeed.Seed(jurusan.Id);
                        PekerjaanItems = _pekerjaanDataSeed.PekerjaanItems;
                    }
                });
                return _init;

            }
        }
    }
}
