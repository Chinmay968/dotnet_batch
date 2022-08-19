using System;

namespace math
 {
     class Operations
     {
         static void Main(string[] args)
         {
            math.Addition.Add();
            math.Subtraction.Sub();
            math.Multiplication.Mul();
            math.Division.Div();
    
         }
     }
    class Addition
    {
        public static void Add()
        {
            int num1=15;
            int num2=5;
            int resultAdd;
            resultAdd=num1+num2;
            Console.WriteLine("Addition of two numbers : "+ resultAdd);
        }
    }
    class Subtraction
    {
        public static void Sub()
        {
            int num1=15;
            int num2=5;
            int resultSub;
            resultSub=num1-num2;
            Console.WriteLine("Subtraction of two numbers : "+ resultSub);
        }
    }
    class Multiplication
    {
        public static void Mul()
        {
            int num1=15;
            int num2=5;
            int resultMul;
            resultMul=num1*num2;
            Console.WriteLine("Multiplication of two numbers : "+ resultMul);
        }
    }
    class Division
    {
        public static void Div()
        {
            int num1=15;
            int num2=5;
            int resultDiv;
            resultDiv=num1/num2;
            Console.WriteLine("Division of two numbers : "+ resultDiv);
        }
    }
 }