using System;
using System.Collections.ObjectModel;

namespace Triggers
{
    public class MainViewModel
    {
        public ObservableCollection<InfoModel> InfoList { get; set; } = new ObservableCollection<InfoModel>();
        public MainViewModel()
        {
            LoadInfo();
        }

        private void LoadInfo()
        {
            var i1 = new InfoModel() {
                Name = "x.x",
                Amount = 12.2
            };
            var i2 = new InfoModel()
            {
                Name = "x.x",
                Amount = 22.2
            };
            InfoList.Clear();
            InfoList.Add(i1);
            InfoList.Add(i2);
        }
    }
}
