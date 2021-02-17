using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class ShipmentVO
    {
        public int Ship_Num { get; set; } //출하번호
        public string Ship_Detail { get; set; } //출하구분
        public int Firstman { get; set; } //최초등록자
        public DateTime Firstdate { get; set; } //최초등록일
        public int Lastman { get; set; } //최종등록자
        public DateTime Lastdate { get; set; } //최종수정일
        public string IsDeleted { get; set; } //정보삭제여부
        public int Ship_D_Num { get; set; } //출하상세번호
        public int Str_Num { get; set; } //창고번호
        public string Mat_Num { get; set; } //자재번호
        public int Ship_Cnt { get; set; } //출하수량
        public string Ship_Status { get; set; } //출하상태
        public int WO_D_Num { get; set; } //작업지시상세
        public string Str_Kind { get; set; }    //창고이름

        public DateTime ProductionDate { get; set; } //지시일자
        public int WO_Num { get; set; } //작업지시번호
        public string WP_Name { get; set; } //작업장명
        public string Process_Name_D { get; set; } //상세공정명
        public string Mat_Name { get; set; } //자재명
        public string Mat_Category { get; set; } //자재유형
        public int WO_Order_Cnt { get; set; } //지시량
        public string WO_Status { get; set; } //상태명
    }
}
