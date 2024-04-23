using System;


/*  
    1. In static class instance or object cannt be created and neither
    inherited
    
    2. static classes are used as containers for static members like 
    methods, constructors and others
    
    3. all the members needs to be static only 
    even if one member is also not static there will be compiling error
    
    4. no second person can make instance(onject) or inherit from the static field.     
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
