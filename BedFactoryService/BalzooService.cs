using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class BalzooService
    {
        /// <summary>
        /// 발주 PK를 가져오는 함수
        /// </summary>
        /// <returns></returns>
        public int GetBalzooNum()
        {
            BalzooDAC dac = new BalzooDAC();
            return dac.GetBalzooNum();
        }
        /// <summary>
        /// 계획 생성시 재고가 부족해 자동 발주를 넣을 때 사용
        /// </summary>
        /// <returns></returns>
        public bool InsertMasterBalzoo(int Com_Num, int FirstMan)
        {
            BalzooDAC dac = new BalzooDAC();
            return dac.InsertMasterBalzoo(Com_Num, FirstMan);
        }
        /// <summary>
        /// 발주 상세 테이블을 생성
        /// </summary>
        /// <returns></returns>
        public bool InsertDetailBalzoo(string Bz_D_Num, int Bz_Num, string Mat_Num, int BzCnt, string Status, string expecteddate, string isCancel)
        {
            BalzooDAC dac = new BalzooDAC();
            return dac.InsertDetailBalzoo(Bz_D_Num, Bz_Num, Mat_Num, BzCnt, Status, expecteddate, isCancel);
        }


        public List<BalzooVO> BalzooSelect(DateTime fromDate, DateTime toDate)
        {
            BalzooDAC dac = new BalzooDAC();
            return dac.BalzooSelect(fromDate, toDate);
        }

        public List<BalzooVO> WarehousingWait(DateTime fromDate, DateTime toDate)
        {
            BalzooDAC dac = new BalzooDAC();
            return dac.WarehousingWait(fromDate, toDate);
        }

        public bool StateIsWait(WearingVO vo)
        {
            BalzooDAC dac = new BalzooDAC();
            return dac.StateIsWait(vo);
        }

        public List<BalzooVO> BalzooAndM_Use(int dNum)
        {
            BalzooDAC dac = new BalzooDAC();
            return dac.BalzooAndM_Use(dNum);
        }

        public List<BalzooVO> SearchPlanNum()
        {
            BalzooDAC dac = new BalzooDAC();
            return dac.SearchPlanNum();
        }

        public List<BalzooVO> BalzooCompany()
        {
            BalzooDAC dac = new BalzooDAC();
            return dac.BalzooCompany();
        }

        public bool BalzooInsert(List<BalzooVO> list, int comNum, int id)
        {
            BalzooDAC dac = new BalzooDAC();
            return dac.BalzooInsert(list, comNum, id);
        }

        public bool BalzooDateUpdate(List<string> list, DateTime date)
        {
            BalzooDAC dac = new BalzooDAC();
            return dac.BalzooDateUpdate(list, date);
        }

        public bool BalzooCancel(List<string> list)
        {
            BalzooDAC dac = new BalzooDAC();
            return dac.BalzooCancel(list);
        }
    }
}
