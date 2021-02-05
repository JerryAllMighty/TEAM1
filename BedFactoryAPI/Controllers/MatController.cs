using BedFactoryAPI;
using BedFactoryDAC;
using BedFactoryVO;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPITest.Controllers
{
    [RoutePrefix("api/Mat")]
    public class MatController : ApiController
    {
        [Route("GetAllMaterials")]    //api/Mat/GetAllMaterials
        public IHttpActionResult GetAllMaterials()
        {
            
            APIMessage<List<MaterialsVO>> msg = new APIMessage<List<MaterialsVO>>();

            MaterialsDAC uDac = new MaterialsDAC(Global.strConn);
            msg.Data = uDac.GetAllMaterials();
            msg.ResultCode = (msg.Data == null) ? "F" : "S";
            msg.ResultMessage = (msg.Data == null) ? "조회된 목록이 없습니다." : "OK";

            return Ok(msg);
        }
    }
}
