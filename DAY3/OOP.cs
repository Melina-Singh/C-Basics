using System;
using System.Net.Http.Headers;

namespace OOPs
{    
    // this is the example of the constructor.  

    public class Person
    {
        public string name;
        public int age;
        private double gpa;

        public Person(string fname, int myage, double mygpa)
        {
            name = fname;
            age = myage;
            SetGpa(mygpa); // Set GPA using the setter method
        }

        public string GetName()
        {
            return name;
        }
       
        public int GetAge()
        {
            return age;
        }

        public double GetGpa() //yabata get gpa
        {
            return gpa;
        }
        public void SetGpa(double mygpa) //yabata setgpa
        {
            if (mygpa >= 1 && mygpa <= 4) { 
                gpa= mygpa;
            }
            else
            {
                Console.WriteLine("INVALID NUMBER!! Must be from 0 - 4");
            }
        }

        public void GetDetails()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gpa : "+ GetGpa());
        }
    }
    class Program  //yaha sey main suru hotahey
    {
       static void Main(string[] args)
        {
            Person P = new Person("Raghupati Raghav", 22, 3.4);
            Person P1 = new Person("Priyanka Chopra", 23, 3.22);
            Person P3 = new Person("Vicky Kaushal", 22, 5);

            P.GetDetails();
            P1.GetDetails();
            P3.GetDetails();

            Console.ReadLine();
        }
    }
}
