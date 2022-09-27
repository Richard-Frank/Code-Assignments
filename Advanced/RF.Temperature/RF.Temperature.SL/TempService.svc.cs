using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RF.Temperature1.BL;

namespace RF.Temperature.SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TempService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TempService.svc or TempService.svc.cs at the Solution Explorer and start debugging.
    public class TempService : ITempService
    {
        public double ConvertToCelsius(double fahrenheit)
        {
            double celsius = 0;

            CTemper.ConvertToCelsius(fahrenheit, out celsius);
            return celsius;
        }

        public double ConvertToFahrenheit(double celsius)
        {
            return CTemper.ConvertToFahr(celsius);
        }

        public void DoWork()
        {
            //Does nothing.
            throw new NotImplementedException();
        }
    }
}
