using LadisEndpointModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadisEndpointBLL.Services.Interface
{
    public interface IEndpointService
    {
        EndPoint InsertEndPoint(EndPoint endPoint);
        EndPoint EditEndPoint(EndPoint endPoint);
        EndPoint DeleteEndPoint(EndPoint endPoint);
        List<EndPoint> ListEndPointsAll();
        EndPoint FindEndpoint(EndPoint endPoint);
    }
}
