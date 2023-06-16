namespace FindMaximumProblemUsingGenerics
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag=true;
            while(flag)
            {
                Console.WriteLine("Choose Option to Perform\n1.Find Maximum Integers\n2.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                MaximumOperation operation = new MaximumOperation();
                switch(option)
                {
                    case 1:
                        operation.Maximum(39,23,35);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}
