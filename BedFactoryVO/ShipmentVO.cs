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
        public int Ship_Detail { get; set; } //출하구분
        public int Firstman { get; set; } //최초등록자
        public int Firstdate { get; set; } //최초등록일
        public int Lastman { get; set; } //최종등록자
        public int Lastdate { get; set; } //최종수정일
        public int IsDeleted { get; set; } //정보삭제여부
        public int Ship_D_Num { get; set; } //출하상세번호
        public int Str_Num { get; set; } //창고번호
        public int Mat_Num { get; set; } //자재번호
        public int Ship_Cnt { get; set; } //출하수량
        public int Ship_Status { get; set; } //출하상태
        public int WO_D_Num { get; set; } //작업지시상세

    }
}
