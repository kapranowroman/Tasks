using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    class Stage
    {
        private List<Material> MaterialsEstimation;
        private List<Material> MaterialsReal;
        public bool InWork { get; set; }
        private List<Period> TimeReal;
        public int TimeEstimation { get; set; }



        
        public void addMaterial(Material item)
        {
            MaterialsEstimation.Add(item);
        }
        public IReadOnlyCollection<Material>getmaterials()
        {
            return new ReadOnlyCollection<Material>(MaterialsEstimation);

        }
        
        public void addMaterial(Material item)
        {
            MaterialsReal.Add(item);
        }
        public IReadOnlyCollection<Material> getmaterials()
        {
            return new ReadOnlyCollection<Material>(MaterialsReal);

        }


    }
}
