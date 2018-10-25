using System;
using System.Collections.ObjectModel;
using BimKon.Core.Models;

namespace BimKon.Core.Repositories
{
    public class SMKDataSeed : IJurusanDataSeed
    {
        public ObservableCollection<JurusanViewModel> JurusanItems
        {
            get; set;
        }
        public SMKDataSeed()
        {
            JurusanItems = new ObservableCollection<JurusanViewModel>();
        }
        public void Seed()
        {
            var sekolah = new SekolahViewModel
            {
                Id = 1,
                Name = "SMK"
            };
            var jur1 =
                new JurusanViewModel
                {
                    Id = "1",
                    Name = "AGRO BISNIS DAN AGRO TEKNOLOGI",
                    Sekolah = sekolah
                };
            var jur1_1 =
               new JurusanViewModel
               {
                   Id = "1-1",
                   Name = "Agrobisnis Tanaman",
                   Parent = jur1,
                   Sekolah = sekolah
               };
            JurusanItems.Add(jur1_1);
            var jur1_2 =
               new JurusanViewModel
               {
                   Id = "1-2",
                   Name = "Sumber Daya Perairan",
                   Parent = jur1,
                   Sekolah = sekolah
               };
            JurusanItems.Add(jur1_2);
            var jur1_3 =
               new JurusanViewModel
               {
                   Id = "1-3",
                   Name = "Agribisnis Perikanan",
                   Parent = jur1,
                   Sekolah = sekolah
               };
            JurusanItems.Add(jur1_3);
            var jur1_4 =
              new JurusanViewModel
              {
                  Id = "1-4",
                  Name = "Kehutanan",
                  Parent = jur1,
                  Sekolah = sekolah
              };
            JurusanItems.Add(jur1_4);
            var jur1_5 =
              new JurusanViewModel
              {
                  Id = "1-5",
                  Name = "Agrisbisnis Ternak Unggas",
                  Parent = jur1,
                  Sekolah = sekolah
              };
            JurusanItems.Add(jur1_5);
            var jur1_6 =
             new JurusanViewModel
             {
                 Id = "1-6",
                 Name = "Pengawasan Mutu",
                 Parent = jur1,
                 Sekolah = sekolah
             };
            JurusanItems.Add(jur1_6);
            var jur2 =
               new JurusanViewModel
               {
                   Id = "2",
                   Name = "BISNIS MANAJEMEN",
                   Sekolah = sekolah
               };
            var jur2_1 =
               new JurusanViewModel
               {
                   Id = "2-1",
                   Name = "Akuntansi",
                   Parent = jur2,
                   Sekolah = sekolah
               };
            JurusanItems.Add(jur2_1);
            var jur2_2 =
               new JurusanViewModel
               {
                   Id = "2-2",
                   Name = "Perbankan",
                   Parent = jur2,
                   Sekolah = sekolah
               };
            JurusanItems.Add(jur2_2);
            var jur2_3 =
              new JurusanViewModel
              {
                  Id = "2-3",
                  Name = "Pemasaran",
                  Parent = jur2,
                  Sekolah = sekolah
              };
            JurusanItems.Add(jur2_3);
            var jur2_4 =
             new JurusanViewModel
             {
                 Id = "2-4",
                 Name = "Administrasi Perkantoran",
                 Parent = jur2,
                 Sekolah = sekolah
             };
            JurusanItems.Add(jur2_4);

            var jur3 =
               new JurusanViewModel
               {
                   Id = "3",
                   Name = "TEKNOLOGI INFORMASI",
                   Sekolah = sekolah
               };
            var jur3_1 =
               new JurusanViewModel
               {
                   Id = "3-1",
                   Name = "Rekayasa Perangkat Lunak",
                   Parent = jur3,
                   Sekolah = sekolah
               };
            JurusanItems.Add(jur3_1);
            var jur3_2 =
               new JurusanViewModel
               {
                   Id = "3-2",
                   Name = "Teknik Komputer dan Jaringan",
                   Parent = jur3,
                   Sekolah = sekolah
               };
            JurusanItems.Add(jur3_2);
            var jur3_3 =
              new JurusanViewModel
              {
                  Id = "3-3",
                  Name = "Multimedia",
                  Parent = jur3,
                  Sekolah = sekolah
              };
            JurusanItems.Add(jur3_3);
            var jur4 =
                new JurusanViewModel
                {
                    Id = "4",
                    Name = "TEKNOLOGI DAN REKAYASA",
                    Sekolah = sekolah
                };
            var jur4_1 =
               new JurusanViewModel
               {
                   Id = "4-1",
                   Name = "Sepeda Motor",
                   Parent = jur4,
                   Sekolah = sekolah
               };
            JurusanItems.Add(jur4_1);
            var jur4_2 =
               new JurusanViewModel
               {
                   Id = "4-2",
                   Name = "Pengelasan",
                   Parent = jur4,
                   Sekolah = sekolah
               };
            JurusanItems.Add(jur4_2);
            var jur4_3 =
              new JurusanViewModel
              {
                  Id = "4-3",
                  Name = "Konstruksi",
                  Parent = jur4,
                  Sekolah = sekolah
              };
            JurusanItems.Add(jur4_3);

        }
    }

}
