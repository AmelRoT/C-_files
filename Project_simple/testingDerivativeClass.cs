using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_simple
{
     class testingDerivativeClass
    {

        public static void Main(String[] args) // Main has to be capital ....
        {
            double x_at_3 = 5,store;
            derivativeFunction ob1 = new derivativeFunction(); 
            Console.WriteLine("Derivative of x^2 is : ");
            store = ob1.derivative(x_at_3);
            Console.WriteLine(store);
        }

    }

}
