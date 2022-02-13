using LadisEndpointBLL.Services.Interface;
using LadisEndpointModel;
using System.Collections.Generic;
using Microsoft.Extensions.Caching.Memory;
using System.Linq;

namespace LadisEndpointBLL.Services.Console
{
    public class EndpointServiceConsole : IEndpointService
    {
        private IMemoryCache Cache { get; set; }
        private List<EndPoint> EndPoints { get; set; }
        public EndpointServiceConsole()
        {
            Cache = new MemoryCache(new MemoryCacheOptions());
            EndPoints = new List<EndPoint>();
        }     

        public EndPoint InsertEndPoint(EndPoint endPoint)
        {
            EndPoints.Add(endPoint);
            //object result = Cache.Set(endPoint, endPoint);
            return endPoint;
        }
        public EndPoint EditEndPoint(EndPoint endPoint)
        {
            int index = EndPoints.FindLastIndex(x => x == endPoint);
            if (index != -1)
            {
                EndPoints[index] = endPoint;
            }          
            return endPoint;
        }
        public bool DeleteEndPoint(EndPoint endPoint)
        {
            EndPoints.Remove(endPoint);
            return true;
        }
        public List<EndPoint> ListEndPointsAll()
        {    
            return EndPoints;
        }
        public EndPoint FindEndpoint(EndPoint endPoint)
        {
            endPoint = EndPoints.Where(x => x.SerialNumber == endPoint.SerialNumber).FirstOrDefault();

            return endPoint;
        }

    }
}
