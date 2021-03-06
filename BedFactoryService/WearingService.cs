﻿using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class WearingService
    {
        public List<WearingVO> WarehousingState(DateTime fromDate, DateTime toDate)
        {
            WearingDAC dac = new WearingDAC();
            return dac.WarehousingState(fromDate, toDate);
        }

        public int WarehousingCancel(int wearingNum, int cancelCnt)
        {
            WearingDAC dac = new WearingDAC();
            return dac.WarehousingCancel(wearingNum, cancelCnt);
        }

        public List<WearingVO> StockState()
        {
            WearingDAC dac = new WearingDAC();
            return dac.StockState();
        }
        public List<WearingVO> StockStateSearch(int sNum, string mNum)
        {
            WearingDAC dac = new WearingDAC();
            return dac.StockStateSearch(sNum, mNum);
        }

        public List<WearingVO> WOState(DateTime fromDate, DateTime toDate)
        {
            WearingDAC dac = new WearingDAC();
            return dac.WOState(fromDate, toDate);
        }

        public List<WearingVO> WarehousingStart(DateTime fromDate, DateTime toDate)
        {
            WearingDAC dac = new WearingDAC();
            return dac.WarehousingStart(fromDate, toDate);
        }

        public bool BuyWarehousing(int W_Num, int M_Num)
        {
            WearingDAC dac = new WearingDAC();
            return dac.BuyWarehousing(W_Num, M_Num);
        }

        public List<WearingVO> GetAllWearHouse()
        {
            WearingDAC dac = new WearingDAC();
            return dac.GetAllWearHouse();
        }
    }
}
