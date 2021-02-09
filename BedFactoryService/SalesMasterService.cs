using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class SalesMasterService
    {
        public List<SalesMasterVO> GetSalesMaster(SalesMasterVO salesmasterinfo)
        {
            SalesMasterDAC dac = new SalesMasterDAC();
            return dac.GetSalesMaster(salesmasterinfo);
        }

        public List<SalesMasterVO> GetSalesMasterBySalesMasterNum(string salesmasternum)
        {
            SalesMasterDAC dac = new SalesMasterDAC();
            return dac.GetSalesMasterBySalesMasterNum(salesmasternum);
        }

        public bool InsertSalesMaster(SalesMasterVO salesmasterinfo)
        {
            SalesMasterDAC dac = new SalesMasterDAC();
            return dac.InsertSalesMaster(salesmasterinfo);
        }

    }
}
