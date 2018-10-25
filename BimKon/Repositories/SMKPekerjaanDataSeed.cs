using System;
using System.Collections.ObjectModel;
using System.Linq;
using BimKon.Core.Models;

namespace BimKon.Core.Repositories
{
    public class SMKPekerjaanDataSeed : IPekerjaanDataSeed
    {
        public SMKPekerjaanDataSeed()
        {
            PekerjaanItems = new ObservableCollection<PekerjaanViewModel>();
        }
        public ObservableCollection<PekerjaanViewModel> PekerjaanItems
        {
            get; set;
        }

        public void Seed(string jurusanId)
        {
            PekerjaanItems.Add(new PekerjaanViewModel
            {
                Id = "1",
                Name = "Agribisnis",
                JurusanIds = new string[] { "1-1", "1-2" }
            });
            PekerjaanItems.Add(new PekerjaanViewModel
            {
                Id = "2",
                Name = "Pekerjaan Lainnya",
                JurusanIds = new string[] { "1-1", "1-2" }
            });
            PekerjaanItems.Add(new PekerjaanViewModel
            {
                Id = "3",
                Name = "Peternakan Ayam",
                JurusanIds = new string[] { "1-5" }
            });
            PekerjaanItems.Add(new PekerjaanViewModel
            {
                Id = "4",
                Name = "Karantina Hewan",
                JurusanIds = new string[] { "1-5" }
            });
            PekerjaanItems.Add(new PekerjaanViewModel
            {
                Id = "5",
                Name = "Pembibitan Ternak",
                JurusanIds = new string[] { "1-5" }
            });
            PekerjaanItems.Add(new PekerjaanViewModel
            {
                Id = "6",
                Name = "Penyuluhan Peternakan",
                JurusanIds = new string[] { "1-5" }
            });
            PekerjaanItems.Add(new PekerjaanViewModel
            {
                Id = "7",
                Name = "Industri Pengawasan dan Boga",
                JurusanIds = new string[] { "1-6" }
            });
            PekerjaanItems.Add(new PekerjaanViewModel
            {
                Id = "8",
                Name = "Teknisi Industri Pangan",
                JurusanIds = new string[] { "1-6" }
            });
            PekerjaanItems.Add(new PekerjaanViewModel
            {
                Id = "9",
                Name = "Penyuluhan Pertanian",
                JurusanIds = new string[] { "1-6" }
            });
            PekerjaanItems.Add(new PekerjaanViewModel
            {
                Id = "10",
                Name = "Penelitian Pangan dan Non Pangan",
                JurusanIds = new string[] { "1-6" }
            });

            PekerjaanItems = new ObservableCollection<PekerjaanViewModel>(PekerjaanItems.Where(x => x.JurusanIds.Contains(jurusanId)));
        }
    }
}
