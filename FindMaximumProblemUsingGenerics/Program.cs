namespace FindMaximumProblemUsingGenerics
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag=true;
            while(flag)
            {
                Console.WriteLine("Choose Option to Perform\n1.Find Maximum Integers\n2.Find Maximum Floats\n3.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                MaximumOperation operation = new MaximumOperation();
                switch(option)
                {
                    case 1:
                        operation.MaximumInteger(39,23,35);
                        break;
                        case 2:
                        operation.MaximumFloats(2.3f, 56.3f, 34.4f);
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}
