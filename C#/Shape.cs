using System;

namespace Shapes
{
    class Operations
    {
        static void Main (String[] args)
        {
            int s = 10;
            int l = 20;
            int b = 5;

            Shapes.Square.square(s);
            Shapes.Rectangle.rectangle(l,b);

        }
       
    }
    class Square
    {
        public static void square(int s)
        {
            int area = s * s;
            Console.WriteLine("Area of Square is " +area);
        }

    }

    class Rectangle 
    {
        public static void rectangle(int l,int b)
        {
            int area = l * b;
            Console.WriteLine("Area of Rectangle is " +area);

        }

    }
}