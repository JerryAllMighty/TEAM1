﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class BalzooVO
    {
        public string Bz_D_Num { get; set; } //발주상세번호
        public string Bz_Num { get; set; } //발주번호
        public string Com_Num { get; set; } //거래처 번호
        public string Com_Name { get; set; } //거래처명
        public string Mat_Num { get; set; } //자재번호
        public string Mat_Name { get; set; } //자재명
        public string Bz_Cnt { get; set; } //발주 수량
        public string Bz_D_Status { get; set; } //처리현황
        public string ExpectedDate { get; set; } //예상납기일
        public string Bz_IsCancel { get; set; } //취소여부
    }
}