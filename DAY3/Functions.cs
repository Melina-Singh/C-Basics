using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                          
namespace Functions
{
    class Program
    {
        static void NayaMethod()
        {
            string[] Fruits = { "Grapes", "Banana", "Watermelon", "Jackfruit" };
            Console.WriteLine(string.Join("  ", Fruits ) + " Pomegranate");
            Console.WriteLine(string.Join(" ", Fruits) + " Lichi");

            for ( int i = 0;i<Fruits.Length;i++ ) 
            {
                Console.WriteLine("So this is " + Fruits[i]);
            }
        }
        static void MyMethod()
        {
            Console.WriteLine("This is th method in here and i am gonna call it 3 times😆");
        }

        static void yelo(string fname) //one parameter fname
        {
            Console.WriteLine(fname);
        }

        static void Multiple(string fname, int age) //multiple parameter
        {
            Console.WriteLine("My name is " + fname + " I am " + age + " years old");
        }

        static void Defaultp(string country = "Nepal")
        {
            Console.WriteLine(country); 
            /*if we call this method without an argument
            it will use default value that is Nepal*/
        }

        static int MyM(int x, int y) //return function
        {
            return x + y;
        }

        static void NamedArgs(string child1, string child2, string child3)
        {
            Console.WriteLine("The Youngest Child is : " + child2);
        }

        static void Main(string[] args)
        {
            MyMethod();
            MyMethod();
            MyMethod();

            NayaMethod();

            yelo("RAdhika");
            yelo("Anamika");
            Multiple("Radhika", 22);
            Multiple("Sara", 21);

              
            Defaultp();  // here uses default value 
            Defaultp("USA");
            Defaultp("fRANCE");
            Defaultp("Belgium");

            int z = MyM(44, 255);
            Console.WriteLine("Yo chai Return wala method ho "+ z);

            Console.WriteLine(MyM(2, 3));
            NamedArgs(child1: "Balram", child2: "Krish", child3: "Mata");

            //Console.ReadLine();
        }
    }
}
