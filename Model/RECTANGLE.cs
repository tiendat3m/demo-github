using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2.Model
{
    public class RECTANGLE: SHAPE
    {
        public double length, width;
       public RECTANGLE(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        ~RECTANGLE()
        {

        }
        public RECTANGLE()
        {

        }
        public override void input()
        {
            Console.Write("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public override void outPut()
        {
            Console.WriteLine("Length of rectangle :{0}",length) ;
            Console.WriteLine("Width of rectangle:{0}",width);
           
        }
        public override double area()
        {
            return (double)length * width;
        }
    }
}
