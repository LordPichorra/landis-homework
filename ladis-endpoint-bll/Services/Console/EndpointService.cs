using LadisEndpointBLL.Services.Interface;
using LadisEndpointModel;
using System.Collections.Generic;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Primitives;
using System;
using System.Threading;


namespace LadisEndpointBLL.Services.Console
{
    public class EndpointServiceConsole : IEndpointService
    {
        public EndpointServiceConsole()
        {
            Cache = new MemoryCache(new MemoryCacheOptions());
        }
        public IMemoryCache Cache { get; private set; }

        public EndPoint InsertEndPoint(EndPoint endPoint)
        {
            object result = Cache.Set(endPoint, endPoint);
            return (EndPoint)result;
        }
        public EndPoint EditEndPoint(EndPoint endPoint)
        {
            object result = Cache.Set(endPoint, endPoint);
            return (EndPoint)result;
        }
        public EndPoint DeleteEndPoint(EndPoint endPoint)
        {
            return endPoint;
        }
        public List<EndPoint> ListEndPointsAll()
        {
            List<EndPoint> endPoints = new List<EndPoint>();

            return endPoints;
        }
        public EndPoint FindEndpoint(EndPoint endPoint)
        {
            object result = Cache.Get(endPoint);
            return (EndPoint)result;
        }

    }
}
