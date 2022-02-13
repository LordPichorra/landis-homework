using LadisEndpointBLL.Err.Code;
using System;

namespace LadisEndpointBLL.Err.Core
{
    public class EndPointException : Exception
    {
        public ErrCode Code { get; set; }
        public EndPointException(string message) : base(message)
        {
        }        
    }
}
