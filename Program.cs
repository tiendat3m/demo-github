using Bai_2.Model;
using System;

namespace Bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            RECTANGLE rectangle = new RECTANGLE();

            // Tinh toan
            rectangle.input();
            rectangle.outPut();
            Console.Write("Area of rectangle: ");
            Console.WriteLine(rectangle.area());


            CIRCLE circle = new CIRCLE();
            circle.input();
            circle.outPut();
            Console.Write("Area of circle: ");
            Console.WriteLine(circle.area());

            TRIANGLE triangle = new TRIANGLE();
            triangle.input();
            triangle.outPut();
            Console.WriteLine("Area of triangle: ");
            Console.Write(triangle.area());
        }
    }
}
