using System;
using System.Collections.ObjectModel;
using BimKon.Core.Models;

namespace BimKon.Core.Repositories
{
    public class SMADataSeed : IJurusanDataSeed
    {
        public ObservableCollection<JurusanViewModel> JurusanItems
        {
            get; set;
        }
        public SMADataSeed()
        {
            JurusanItems = new ObservableCollection<JurusanViewModel>();
        }
        public void Seed()
        {
            var sekolah = new SekolahViewModel
            {
                Id = 1,
                Name = "SMA"
            };
            var jur1 =
                new JurusanViewModel
                {
                    Id = "1",
                    Name = "MATEMATIKA DAN ILMU ALAM",
                    Sekolah = sekolah
                };
            var jur1_1 =
               new JurusanViewModel
               {
                   Id = "1-1",
                   Name = "Matematika",
                   Parent = jur1,
                   Sekolah = sekolah
               };
            JurusanItems.Add(jur1_1);
            var jur1_2 =
               new JurusanViewModel
               {
                   Id = "1-2",
                   Name = "Fisika",
                   Parent = jur1,
                   Sekolah = sekolah
               };
            JurusanItems.Add(jur1_2);
            var jur1_3 =
               new JurusanViewModel
               {
                   Id = "1-3",
                   Name = "Biologi",
                   Parent = jur1,
                   Sekolah = sekolah
               };
            JurusanItems.Add(jur1_3);
            var jur1_4 =
              new JurusanViewModel
              {
                  Id = "1-4",
                  Name = "Kimia",
                  Parent = jur1,
                  Sekolah = sekolah
              };
            JurusanItems.Add(jur1_4);

            var jur2 =
               new JurusanViewModel
               {
                   Id = "2",
                   Name = "ILMU-ILMU SOSIAL",
                   Sekolah = sekolah
               };
            var jur2_1 =
               new JurusanViewModel
               {
                   Id = "2-1",
                   Name = "Sejarah",
                   Parent = jur2,
                   Sekolah = sekolah
               };
            JurusanItems.Add(jur2_1);
            var jur2_2 =
               new JurusanViewModel
               {
                   Id = "2-2",
                   Name = "Geografi",
                   Parent = jur2,
                   Sekolah = sekolah
               };
            JurusanItems.Add(jur2_2);
            var jur2_3 =
              new JurusanViewModel
              {
                  Id = "2-3",
                  Name = "Sosiologi",
                  Parent = jur2,
                  Sekolah = sekolah
              };
            JurusanItems.Add(jur2_3);
            var jur2_4 =
             new JurusanViewModel
             {
                 Id = "2-4",
                 Name = "Ekonomi",
                 Parent = jur2,
                 Sekolah = sekolah
             };
            JurusanItems.Add(jur2_4);

            var jur3 =
               new JurusanViewModel
               {
                   Id = "3",
                   Name = "BAHASA DAN BUDAYA",
                   Sekolah = sekolah
               };
            var jur3_1 =
               new JurusanViewModel
               {
                   Id = "3-1",
                   Name = "Bahasa dan Sastra Indonesia",
                   Parent = jur3,
                   Sekolah = sekolah
               };
            JurusanItems.Add(jur3_1);
            var jur3_2 =
               new JurusanViewModel
               {
                   Id = "3-2",
                   Name = "Bahasa dan Sastra Inggris",
                   Parent = jur3,
                   Sekolah = sekolah
               };
            JurusanItems.Add(jur3_2);
            var jur3_3 =
              new JurusanViewModel
              {
                  Id = "3-3",
                  Name = "Bahasa dan Sastra Asing Lainnya",
                  Parent = jur3,
                  Sekolah = sekolah
              };
            JurusanItems.Add(jur3_3);
            var jur3_4 =
              new JurusanViewModel
              {
                  Id = "3-4",
                  Name = "Antropologi",
                  Parent = jur3,
                  Sekolah = sekolah
              };
            JurusanItems.Add(jur3_4);


        }
    }

}
