using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RF.GravitationalPull.BL
{ 

    public static class CPullCalc
    {
        //Calculates the gravitational pull of two objects.
        public static void Calculate(double m1, double m2, double dist, out double F)
        {

            // Gravitational constant.
            double G = 6.674e-11;

            // Force = G * Mass of object 1 * Mass of object 2 / distance squared.
            F = G * m1 * m2 / (dist * dist);
        }

    }
}
