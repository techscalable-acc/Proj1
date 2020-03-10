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
<<<<<<< HEAD
            Console.WriteLine("Added at VS console!");
=======
            Console.WriteLine("Added line 2 at git hub web console!");
>>>>>>> a5e242460f9c8d369df95af57da4033a09fe6bef

            var calculate = new Calculate();
            int sum = calculate.addition(4, 5);
            Console.WriteLine(sum);

        }
    }
}
