using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RF.Temperature1.BL
{
    public static class CTemper
    {

        public static double ConvertToFahr(double celsius)
        {
            return 9.0 / 5.0 * celsius + 32;

        }

        //ConvertToCelsius
        //Public, Static, Void,
        //Pram #1, =byval fahr
        //Pram #2, =byref celsius

        // (f -32) * 5.0 / 9.0


        public static void ConvertToCelsius(double fahr, out double celsius)
        {
            celsius = (fahr - 32) * 5.0 / 9.0;
        }

    }
    }
