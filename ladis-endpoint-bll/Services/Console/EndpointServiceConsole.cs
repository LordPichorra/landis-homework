using LadisEndpointBLL.Err.Internal;
using LadisEndpointBLL.Services.Interface;
using LadisEndpointModel;
using System.Collections.Generic;
using System.Linq;

namespace LadisEndpointBLL.Services.Console
{
    public class EndpointServiceConsole : IEndpointService
    {       
        private List<EndPoint> EndPoints { get; set; }
        public EndpointServiceConsole()
        {           
            EndPoints = new List<EndPoint>();
        }
        public EndPoint InsertEndPoint(EndPoint endPoint)
        {
            int index = EndPoints.FindLastIndex(x => x.Equals(endPoint));
            if (index == -1)
                EndPoints.Add(endPoint);
            else
                throw new EndPointAlreadyExistException();
            
            return endPoint;
        }
        public EndPoint EditEndPoint(EndPoint endPoint)
        {
            int index = EndPoints.FindLastIndex(x => x.Equals(endPoint));
            if (index != -1)            
                EndPoints[index] = endPoint;            
            else            
                throw new EndPointNotFoundException();
            return endPoint;
        }
        public bool DeleteEndPoint(EndPoint endPoint)
        {
            var obj = FindEndpoint(endPoint);
            if (obj == null)
                throw new EndPointNotFoundException();
            else
                EndPoints.Remove(endPoint);

            return true;
        }
        public List<EndPoint> ListEndPointsAll()
        {    
            return EndPoints;
        }
        public EndPoint FindEndpoint(EndPoint endPoint)
        {
            endPoint = (from x in EndPoints
                       where x.SerialNumber.Equals(endPoint.SerialNumber)
                       select x).FirstOrDefault();

            if(endPoint == null)
                throw new EndPointNotFoundException();
            else
                return endPoint;
        }
    }
}
