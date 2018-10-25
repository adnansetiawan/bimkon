using System;
namespace BimKon.Core.Models
{
    public class JurusanViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ParentName
        {
            get
            {
                return Parent.Name;
            }
        }

        public JurusanViewModel Parent { get; set; }
        public SekolahViewModel Sekolah { get; set; }
    }
}
