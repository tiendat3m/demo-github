using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2.Model
{
    public class TRIANGLE : SHAPE
    {
        public double bottomEdge, height;

        public TRIANGLE(double bottomEdge, double height)
        {
            this.bottomEdge = bottomEdge;
            this.height = height;
        }

        public TRIANGLE()
        {
        }

        ~TRIANGLE(){

        }
        public override void input()
        {
            Console.Write("Enter bottomEdge: ");
            bottomEdge = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height: ");
            height = Convert.ToDouble(Console.ReadLine());
        }
        public override void outPut()
        {
            Console.WriteLine("BottomEdge of Triangle: {0} ", bottomEdge);
          
            Console.WriteLine("Height of Triangle: {0}", height);
        }
        public override double area()
        {
            return ((double)bottomEdge * height) / 2;
        }
    }
}
