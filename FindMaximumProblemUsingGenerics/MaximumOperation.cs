using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumProblemUsingGenerics
{
    public class MaximumOperation<T> where T : IComparable
    {
        public T a,b,c,d;
        public MaximumOperation(T a,T b,T c,T d)
        {
            this.a= a; 
            this.b = b; 
            this.c= c;
            this.d= d;
        }
        public void FindMaximum()
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0 && a.CompareTo(d)>0)
                Console.WriteLine("{0} is Maximum",a);
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0 && b.CompareTo(d)>0)
                Console.WriteLine("{0} is Maximum",b);
            if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0 && c.CompareTo(d)>0)
                Console.WriteLine("{0} is Maximum",c);
            if(d.CompareTo(a) > 0 && d.CompareTo(b) > 0 &&d.CompareTo(c)>0)
                Console.WriteLine("{0} is Maximum",d);
        }
    }
}
