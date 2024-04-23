using System;


/*  
     in static class instance or object cannt be created and neither
    inherited
    static classes are used as containers for static members like 
    methods, constructors and others

    all the members needs to be static only 
    even if one member is also not static there will be compiling error

koi arko manche chai mero static  clss ko object banauna naskne vayo
nata inherit nai garna sakne vayo
     
     */

public static class MathHelper
{
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        double result1 = MathHelper.Add(5, 3); // Calling static method Add directly on the class
        double result2 = MathHelper.Subtract(10, 4); // Calling static method Subtract directly on the class


        Console.WriteLine("Addition result: " + result1); // Output: 8
        Console.WriteLine("Subtraction result: " + result2); // Output: 6
    }
}
