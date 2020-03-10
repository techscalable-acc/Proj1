using System;

namespace project1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("First Change!");
            Console.WriteLine("Second Change!");
            Console.WriteLine("Added at git hub web console!");

            var calculate = new Calculate();
            int sum = calculate.addition(4, 5);
            Console.WriteLine(sum);

        }
    }
}
