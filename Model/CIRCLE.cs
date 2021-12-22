using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bai_2.Model
{
    public class CIRCLE:SHAPE
    {
        protected double rad;
         public CIRCLE(int x1, int y1, int rad) 
        {
            this.rad = rad;
        }

        public CIRCLE()
        {
        }

        public override void input()
        {
            Console.Write("Enter Radian: ");
            rad = Convert.ToDouble(Console.ReadLine());
        }
        public override void outPut()
        {
            Console.WriteLine("Radian of circle: {0} ", rad);
        }

          public override double area()
        {
            return Math.PI * this.rad * this.rad;
        }
    }
}