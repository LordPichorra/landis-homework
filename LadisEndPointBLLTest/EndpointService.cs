using LadisEndpointBLL.Err.Core;
using LadisEndpointBLL.Err.Internal;
using LadisEndpointBLL.Services.Console;
using LadisEndpointBLL.Services.Interface;
using LadisEndpointModel;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace LadisEndPointBLLTest
{
   
    public class EndpointServiceTest 
    {
        public EndPoint EndPoint { get; set; }
        public EndPoint EndPointErr { get; set; }
        public EndpointServiceConsole instance = new();

        public EndpointServiceTest()
        {
            EndPoint = new EndPoint()
            {
                SerialNumber = "ASD123456",
                FirmwareVersion = "Version 1.0",
                ModelId = 16,
                Number = 1,
                State = 1
            };
            EndPointErr = new EndPoint()
            {
                SerialNumber = "asdasd",
                FirmwareVersion = "Version 1.1",
                ModelId = 12,
                Number = 13,
                State = 3
            };
            instance.InsertEndPoint(EndPoint);
        }

        [Fact]
        public void DeleteEndPointTest()
        {         
            var remove = instance.DeleteEndPoint(EndPoint);
            Assert.True(remove);
        }
        [Fact]
        public void EditEndPointTest()
        {          
            EndPoint.State = 2;
            var editEndpoint = instance.EditEndPoint(EndPoint);
            Assert.Equal(2, editEndpoint.State);
        }
        [Fact]
        public void FindEndpointTest()
        {
            var findEndpoint = instance.FindEndpoint(EndPoint);
            Assert.Equal(findEndpoint, EndPoint);
        }
        [Fact]
        public void FindEndpointNotFoundTest()
        {
            Assert.Throws<EndPointNotFoundException>(() => instance.FindEndpoint(EndPointErr));
        }
    }
}