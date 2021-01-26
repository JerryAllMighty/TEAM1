using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class UnitCostVO
    {
        public int RowNum { get; set; } //로우 넘버
        public int UnitCost_Num { get; set; } //단가 번호
        public int Com_Num { get; set; } //거래터 번호
        public string Com_Name { get; set; } //거래처명
        public string Mat_Num { get; set; } //자재 번호
        public string Mat_Name { get; set; } //자재명
        public int Now_UnitCost { get; set; } //현재 단가
        public int Before_UnitCost { get; set; } //이전 단가
        public DateTime Start_Date { get; set; } //시작일
        public DateTime End_Date { get; set; } //종료일
        public int FirstMan { get; set; } //최초등록자
        public DateTime FirstDate { get; set; } //최초등록일
        public int LastMan { get; set; } //최종등록자
        public DateTime LastDate { get; set; } //최종등록일
    }
}
