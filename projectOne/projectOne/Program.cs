


using System.Data;
using System.Net.Sockets;

namespace projectOne {

    class Program
    {
         static void Main(string[] args)
        {
            Class1 obj1 = new Class1();
            obj1.x1 = 100;
            Console.WriteLine(obj1.x1);
            //  obj1.fun1(200);
            //  int x_store = obj1.addition(10, 20);
            //   Console.WriteLine(x_store); 
            double store_div;
            store_div = obj1.division(3, 0);
            Console.WriteLine(store_div); 
                
        }
    }
 }