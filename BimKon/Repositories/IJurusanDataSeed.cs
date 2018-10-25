using System;
using System.Collections.ObjectModel;
using BimKon.Core.Models;

namespace BimKon.Core.Repositories
{
    public interface IJurusanDataSeed
    {
        ObservableCollection<JurusanViewModel> JurusanItems { get; set; }
        void Seed();
    }
}
