using System.IO;
using System;

namespace FindMaximumProblemUsingGenerics
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag=true;
            while(flag)
            {
                Console.WriteLine("Choose Option to Perform\n1.Find Maximum Integers\n2.Find Maximum Floats\n3.Find Maximum String\n4.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        MaximumOperation<int> max1 = new MaximumOperation<int> (32,43,23,45);
                        max1.FindMaximum();
                        break;
                        case 2:
                        MaximumOperation<float> max2 = new MaximumOperation<float>(12.4f, 23.4f, 33.2f,65.2f);
                        max2.FindMaximum();
                        break;
                        case 3:
                        MaximumOperation<string> max3 = new MaximumOperation<string>("Banana","Apple","Peach","Power");
                        max3.FindMaximum();
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}
