using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._27_OtherControls
{
    public class GirlModel
    {
        public String Name { get; set; }
        public String Image { get; set; }
    }

    public class GirlManager {
        public static ObservableCollection<GirlModel> GetAllGirls() {
            ObservableCollection<GirlModel> models = new ObservableCollection<GirlModel> {
                new GirlModel { Name = "苍井空" ,Image="/Assets/meinv01.png"},
                new GirlModel { Name = "美嘉子" ,Image="/Assets/meinv02.png"},
                new GirlModel { Name = "小泽" ,Image="/Assets/meinv03.jpg"},
            };
            return models;
        } 
    }
}
