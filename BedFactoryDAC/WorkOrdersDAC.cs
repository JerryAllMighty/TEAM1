using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class WorkOrdersDAC:ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection Conn;

        public WorkOrdersDAC()
        {
            strConn = this.ConnectionString;
            Conn = new SqlConnection(strConn);
            Conn.Open();
        }

        public void Dispose()
        {
            if (Conn != null)
            {
                this.Dispose();
            }
        }

        public WorkOrdersVO GetWorkOrdersInfo(DateTime dtFrom, DateTime dtTo, int wpName, string matName, string woStatus)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"select WO_Num, P.Process_Name_D, WP.WP_Name, M.Mat_Name, PP.ProductionDate, SM.LastDate
	                           WO_Status, WO_Plan_Cnt, WO_Order_Cnt, WO_Detail, IsShip
                               from tblWorkOrders WO inner join tblWorkplace WP on WO.WO_Num = WP.WP_Num
					           inner join tblProcess P on WO.Process_Num = P.Process_Num
					           inner join tblMaterials M on WO.Mat_Num = M.Mat_Num
					           inner join tblProductionPlan_D PP on WO.ProductionPlan_D_Num = PP.ProductionPlan_D_Num
					           inner join tblSalesMaster SM on WO.SalesMaster_Num = SM.SalesMaster_Num
                       where 1=1 ");

            if (!string.IsNullOrEmpty(dtFrom))
                sb.Append(" and Process_Code = @prcCode");
            if (!string.IsNullOrEmpty(dtTo))
                sb.Append(" and Process_Code = @prcCode");
            if (!string.IsNullOrEmpty(wpName))
                sb.Append(" and Process_Code = @prcCode");
            if (!string.IsNullOrEmpty(matName))
                sb.Append(" and Process_Code = @prcCode");
            if (!string.IsNullOrEmpty(woStatus))
                sb.Append(" and Process_Code = @prcCode");

        }
    }
}
