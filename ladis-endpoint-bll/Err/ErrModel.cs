using LadisEndpointBLL.Err.Code;
using LadisEndpointBLL.Err.Core;
using LadisEndpointBLL.Err.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadisEndpointBLL.Err
{
    public class ErrModel
    {

        private int Cod { get; set; }
        private string Description { get; set; }

        public ErrModel()
        {
        }

        public ErrModel(Exception e)
        {
            Cod = (int)ErrCode.GenericError;
            Description = e.Message;
          
        }
        public ErrModel(EndPointException e)
        {
            Cod = (int)e.Code;
            Description = e.Message;
        
        }     
        public ErrModel(int cod, string description)
        {
            Cod = cod;
            Description = description;
       
        }
    }
}
