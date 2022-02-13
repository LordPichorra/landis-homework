using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadisEndpointModel
{    public class EndPoint
    {
        public int ModelId { get; set; }
        public string SerialNumber { get; set; }
        public int Number { get; set; }
        public string FirmwareVersion { get; set; }
        public int State { get; set; }

        public override bool Equals(object obj)
        {
            return obj is EndPoint point &&
                   SerialNumber == point.SerialNumber;
        }
        public override int GetHashCode()
        {
            return 425928964 + EqualityComparer<string>.Default.GetHashCode(SerialNumber);
        }

        public override string ToString()
        {
            return string.Format("ModelId - {0} " +
                "| SerialNumber - {1} " +
                "| Number - {2}" +
                "| FirmwareVersion - {3}" +
                "| State = {4}", 
                ModelId.ToString(),
                SerialNumber,
                Number.ToString(),
                FirmwareVersion,
                State.ToString());
        }
    }
}

