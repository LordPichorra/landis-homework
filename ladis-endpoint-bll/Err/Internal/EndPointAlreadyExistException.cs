using LadisEndpointBLL.Err.Code;
using LadisEndpointBLL.Err.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadisEndpointBLL.Err.Internal
{
    public class EndPointAlreadyExistException : EndPointException
    {
        public EndPointAlreadyExistException() :
            base("EndPoint already exist. Please try again!")
        {
            Code = ErrCode.EndPointAlreadyExist;
        }
    }
}
