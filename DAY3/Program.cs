// See https://aka.ms/new-console-template for more information
using System;

namespace Loops
{
    class LOOPES
    {
        static void Main(string[] args)
        {
            //Loops  we use this when we know who many iterations we should make
            //forloops
            /*
             for(start; condition; steps){
             Do something }
             */

            int n = 2;
         for(int i = 0; i<=20 ; i++)
            {
                int f = n * i; 
                Console.WriteLine(f);
            }

            //while loop  when we dont know how many iterations we have to make
            int m = 3;
            while(m<=30)
            {
                Console.WriteLine("Hello World ");
                m+=3;
            }

            int p = 2;
            int e = 0;
            while(e<=20)
            {
                int  u = p * e; 
                Console.WriteLine(u);
                e++;
            }

            /*
             do while
            do{
            //code
            while(condition); 
             */

            int k = 0;
            do
            {
                Console.WriteLine("Do while" + k);
                k++;
            } while(k<=30);

            
        }

    }
}