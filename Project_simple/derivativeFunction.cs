using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_simple
{
     class derivativeFunction
    {


        public double function(double x)
        {
            double y;
            y = (x * x);
            return y; 
        }
        public double derivative(double x)
        {
            double h = 0.00001;
            double derY;
            derY = (function(x + h) - function(x)) / h; 
            return derY;
        }

    }
}
