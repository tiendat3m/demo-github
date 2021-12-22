using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2.Model
{
   public abstract class SHAPE 
    {
        public POINT point1;
        public POINT point2;
        public SHAPE(POINT point1, POINT point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }
        public SHAPE()
        {

        }
        ~SHAPE()
        {

        }
        public virtual void input()
        {

            point1 = new POINT().input();
            point2 = new POINT().input();
        }
        public virtual void outPut()
        {
            Console.WriteLine("Point1: x{0},y{1}", point1.x, point1.y);
            Console.WriteLine("Point2: x{0},y{1}", point2.x, point2.y);
        }
        public virtual double area()
        {
            return 0.0;
        }
    }
}
