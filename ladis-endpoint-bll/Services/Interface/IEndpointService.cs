using LadisEndpointModel;
using System.Collections.Generic;

namespace LadisEndpointBLL.Services.Interface
{
    public interface IEndpointService
    {
        EndPoint InsertEndPoint(EndPoint endPoint);
        EndPoint EditEndPoint(EndPoint endPoint);
        bool DeleteEndPoint(EndPoint endPoint);
        List<EndPoint> ListEndPointsAll();
        EndPoint FindEndpoint(EndPoint endPoint);
    }
}
