using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BedFactoryVO;
using BedFactoryDAC;

namespace BedFactoryService
{
    public class MaterialsService
    {
        public string NewMaterials(MaterialsVO vo)
        {
            MaterialsDAC dac = new MaterialsDAC();
            return dac.NewMaterials(vo);
        }

        public bool UpdateMaterilas(MaterialsVO vo)
        {
            MaterialsDAC dac = new MaterialsDAC();
            return dac.UpdateMaterilas(vo);
        }

        public bool DeleteMaterilas(string id)
        {
            MaterialsDAC dac = new MaterialsDAC();
            return dac.DeleteMaterilas(id);
        }
    }
}
