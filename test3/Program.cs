using System;


namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 1;
            int second = 1;
   
            int input = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            for (int i = 1; input > i; i++)
            {
                result = first + second;
                first = second;
                second = result;
            }
            Console.WriteLine(Math.Abs(result));
        }
    }
}
