﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class WearingVO
    {
        public int Wearing_Num { get; set; } //입고번호
        public int Str_Num { get; set; } //창고번호
        public string Str_Kind { get; set; } //창고종류
        public string Mat_Num { get; set; } //자재번호
        public string Mat_Name { get; set; } //자재명
        public int Mat_Cnt { get; set; } //자재수량
        public int FirstMan { get; set; } //최초등록자
        public DateTime FirstDate { get; set; } //최초등록일

    }
}