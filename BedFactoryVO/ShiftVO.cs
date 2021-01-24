﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class ShiftVO
    {
        public int RowNum { get; set; } //행 갯수
        public int Shift_Num { get; set; } //Shift번호
        public int Shift_Name { get; set; } //Shift명 (주간, 야간)
        public int WP_Num { get; set; } //작업장번호
        public int Start_Time { get; set; } //시작시간
        public int End_Time { get; set; } //완료시간
        public int Start_Date { get; set; } //적용시작일자
        public int End_Date { get; set; } //적용완료일자
        public int FirstMan { get; set; } //최초등록자
        public int FirstDate { get; set; } //최초등록일
        public int LastMan { get; set; } //최종등록자
        public int LastDate { get; set; } //최종등록일
        public int IsUse { get; set; } //사용유무
    }
}
