﻿using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class OrderService
    {
        public List<OrderVO> GetOrders()
        {
            OrderDAC dac = new OrderDAC();
            return dac.GetOrders();
        }
    }
}
