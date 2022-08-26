using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emppp
{
    internal class testradius
    {
        public static void Main()
        {
            Circle ob = new Circle(45);
            double result = ob.area();
            Console.WriteLine($"Area of circle={result}");
                
        }
    }
}
