﻿using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class SalesMasterDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public SalesMasterDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }
        //public List<SalesMasterVO> GetSalesMasterInfo()
        //{
        //    try
        //    {
        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.Connection = conn;
        //            cmd.CommandText = @"";


        //        }
        //    }
        //    catch (Exception err)
        //    {
        //        Log.WriteError(err.Message);
        //        return null;
        //    }

        //}
        public void Dispose()
        {
            conn.Close();
        }
    }
}
