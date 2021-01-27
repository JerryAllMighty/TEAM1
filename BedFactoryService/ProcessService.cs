﻿using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class ProcessService
    {
        public List<ProcessVO> GetProcessInfo(string prcCategory, string prcName)
        {
            ProcessDAC dac = new ProcessDAC();
            return dac.GetProcessInfo(prcCategory, prcName);
        }

        public bool InsertProcessInfo(ProcessVO vo)
        {
            ProcessDAC dac = new ProcessDAC();
            return dac.InsertProcessInfo(vo);
        }

        public bool UpdateProcessInfo(ProcessVO vo, string prcCategory)
        {
            ProcessDAC dac = new ProcessDAC();
            return dac.UpdateProcessInfo(vo, prcCategory);
        }
    }
}