using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumProblemUsingGenerics
{
    public class MaximumOperation
    {
        public void MaximumInteger(int a, int b, int c)
        {
            if(a.CompareTo(b) >0 && a.CompareTo(c) >0)
                Console.WriteLine("{0} is Maximum",a);
            if(b.CompareTo(a)>0 && b.CompareTo(c) >0)
                Console.WriteLine("{0} is Maximum",b);
            if(c.CompareTo(a)>0 && c.CompareTo(b)>0)
                Console.WriteLine("{0} is Maximum",c);
        }
        public void MaximumFloats(float a, float b, float c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
                Console.WriteLine("{0} is Maximum", a);
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
                Console.WriteLine("{0} is Maximum", b);
            if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0)
                Console.WriteLine("{0} is Maximum", c);
        }
    }
}
