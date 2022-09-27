using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RF.VehicleTracker.SL
{
    [Serializable]
    public class ServiceResponce : Exception
    {
        public int ResponceId { get; set; }
        public string ResponceMessage{ get; set; }
        public bool IsError { get; set; }
    }
}