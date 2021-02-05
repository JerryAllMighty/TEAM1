using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class ProcessVO
    {
        public int Process_Num { get; set; }              // 공정번호
        public string Process_Code { get; set; }          // 공정분류코드
        public string Process_Category { get; set; }      // Code_Name AS Process_Category (Process 테이블에 없는 컬럼)
        public string Process_Name_D { get; set; }        // 상세공정명
        public string Process_Condition { get; set; }     // 공정조건
        public string IsDeleted { get; set; }             // 정보삭제여부
        public int Firstman { get; set; }                 // 최초등록자
        public DateTime Firstdate { get; set; }           // 최초등록일
        public int Lastman { get; set; }                  // 최종등록자
        public DateTime Lastdate { get; set; }            // 최종수정일
    }
}

