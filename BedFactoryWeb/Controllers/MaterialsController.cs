using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BedFactoryVO;
using BedFactoryDAC;

namespace BedFactoryWeb.Controllers
{
    [RoutePrefix("api/Materials")]
    public class MaterialsController : ApiController
    {
        ILog log = LogManager.GetLogger(typeof(MaterialsController));

        [Route("GetAllMaterials")]    //api/Materials/GetAllMaterials
        public IHttpActionResult GetAllMaterials()
        {
            APIMessage<List<MaterialsVO>> msg = new APIMessage<List<MaterialsVO>>();

            MaterialsDAC uDac = new MaterialsDAC(log, Global.strConn);
            msg.Data = uDac.GetAllMaterials();
            msg.ResultCode = (msg.Data == null) ? "F" : "S";
            msg.ResultMessage = (msg.Data == null) ? "조회된 목록이 없습니다." : "OK";

            return Ok(msg);
        }
    }
}
