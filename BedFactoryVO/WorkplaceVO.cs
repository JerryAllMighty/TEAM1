using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class WorkplaceVO
    {
        public int WP_Num { get; set; }                  // 작업장번호
        public int Process_Num { get; set; }             // 공정번호
        public string WP_Name { get; set; }              // 작업업장명
        public string Process_Name_Detail { get; set; }  // 상세공정명
        public string IsDeleted { get; set; }            // 정보삭제여부
        public string WP_Note { get; set; }              // 특이사항
        public string WP_Other { get; set; }             // 비고
        public int Firstman { get; set; }                // 최초등록자
        public DateTime Firstdate { get; set; }          // 최초등록일
        public int Lastman { get; set; }                 // 최종등록자
        public DateTime Lastdate { get; set; }           // 최종수정일  
    }
}
