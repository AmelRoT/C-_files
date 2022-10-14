using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectOne
{
     class Class1
    {
        public int x1;
            
        public double addition(int x1,int x2)
        {
            int x3 = x1 + x2;
            return x3;
        }

        public double subtraction(int x1,int x2)
        {
            int sub1 = x1 - x2;
            return sub1; 
        }

        public double multiplication(int x1, int x2)
        {
            int multi = x1 * x2;
            return multi;
        }
        public double division(double x1, double x2)
        {
            double div1;
            string v1; 
            if(x2 == 0)
            {
                while (true)
                {
                    Console.WriteLine("Enter the second number again because you can NOT divide with 0");
                    v1 = Console.ReadLine();
                    x2 = Convert.ToDouble(v1); 
                    if(x2 != 0)
                    {
                        break; 
                    }
                }
            }
            div1 = x1 / x2;
            return div1; 
        }

    }
}
