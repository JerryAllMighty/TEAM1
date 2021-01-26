using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class APIMessage
    {
        public string ResultCode { get; set; }  //S : 성공    F : 실패
        public string ResultMessage { get; set; }
    }

    /// <summary>
    /// 특정VO를 활용하여 API연결
    /// </summary>
    /// <typeparam name="T">VO타입</typeparam>
    public class APIMessage<T>
    {
        public string ResultCode { get; set; }
        public string ResultMessage { get; set; }
        public T Data { get; set; }
    }
}
