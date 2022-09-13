using methodsExercise2;
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace MethodsExercise2
{
    public class MathOperatorMethods
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Method.Add(1,2));
            Console.WriteLine(Method.Subtract(1,2)); 
            Console.WriteLine(Method.Multiply(1,2));
            Console.WriteLine(Method.Divide(1,2));
            Console.WriteLine(Method.Modulus(1,2));
        }
    }
}

