using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RF.Temperature.SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITempService" in both code and config file together.
    [ServiceContract]
    public interface ITempService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        double ConvertToFahrenheit(double celsius);

        [OperationContract]
        double ConvertToCelsius(double fahrenheit);
    }
}
