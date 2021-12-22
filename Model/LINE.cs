using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2.Model
{
    class LINE:SHAPE
    {
       public LINE()
        {

        }
         ~LINE()
        {

        }
        public override void input()
        {
            point1 = new POINT().input();
            point2 = new POINT().input();
        }
        public override void outPut()
        {
            Console.WriteLine("Point1: x{0},y{1}", point1.x, point1.y);
            Console.WriteLine("Point2: x{0},y{1}", point2.x, point2.y);
        }
    }
}
