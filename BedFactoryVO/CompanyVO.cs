using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class CompanyVO
    {
        public int Com_Num { get; set; }            // 업체 번호
        public string Com_Code { get; set; }        // 업체 코드
        public string Com_Type { get; set; }        // 업체 구분 Code_Name AS Com_Type (Compnay 테이블에 없는 컬럼)
        public string Com_Name { get; set; }        // 업체 이름
        public string Com_Addr { get; set; }        // 업체 주소
        public string Com_Represent { get; set; }   // 업체 대표자
        public string Com_Phone { get; set; }       // 업체 전화번호
        public int Com_Manager { get; set; }        // 업체 담당직원
        public string Com_Info { get; set; }        // 업체 정보
        public string IsUse { get; set; }           // 사용여부
        public int FirstMan { get; set; }           // 최초등록자
        public DateTime Firstdate { get; set; }     // 최초등록일
        public int LastMan { get; set; }            // 최종등록자
        public DateTime Lastdate { get; set; }      // 최종수정일
    }
}
