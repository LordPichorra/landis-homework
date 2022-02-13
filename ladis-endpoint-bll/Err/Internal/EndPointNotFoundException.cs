using LadisEndpointBLL.Err.Code;
using LadisEndpointBLL.Err.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadisEndpointBLL.Err.Internal
{
    public class EndPointNotFoundException : EndPointException
    {
        public EndPointNotFoundException() :
            base("EndPoint not found. Please try again!")
        {
            Code = ErrCode.EndPointNotFound;
        }
    }
}
