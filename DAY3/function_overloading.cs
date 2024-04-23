using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Program
    {
        static int PlusMethod(int x, int y)
        {
            return x+y;
        }
        static double PlusMethod(double x, double y) 
        {
            return x+y;
        }
        static float PlusMethod(float x, float y)
        {
            return x+y;
        }
        static void Main(string[] args) 
        {

            int myNum1 = PlusMethod(2311, 44221);
            double myNum2 = PlusMethod(22112.2d, 33442.54d);
            float myNum3 = PlusMethod(3343.2f, 332.43f);

            Console.WriteLine("This is Int: " + myNum1);
            Console.WriteLine("This is Double : "+ myNum2);
            Console.WriteLine("This is Float : "+ myNum3);
        
        }
    }
}
