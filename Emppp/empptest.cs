using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emppp
{
    internal class empptest
    {
        public static void Main()
        {
            Emp e = new Emp(22834, "Suruchi", new DateOnly(2022, 8, 1));
            Console.WriteLine($"Years of Experience {e.GetYearsofExp()}");
        }

    }
}
