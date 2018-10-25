using System;
using System.Collections.ObjectModel;
using BimKon.Core.Models;

namespace BimKon.Core.Repositories
{
    public interface IPekerjaanDataSeed
    {
        ObservableCollection<PekerjaanViewModel> PekerjaanItems { get; set; }
        void Seed(string jurusanId);
    }
}
