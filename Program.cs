using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp = Console.ReadLine();
            int x = Int32.Parse(temp);
            int num = (x < 0) ? 1 : 2;
            Console.WriteLine(num);
            //
        }
    }
}
