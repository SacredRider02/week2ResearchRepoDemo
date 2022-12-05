using System;

namespace HelloWorld
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 10;//creates integer
            x ++;//increments by 1
            int y = 5;
            Console.WriteLine(x+y);//addition within the printing statement is possible

            for (int i = 1; i <= 10; i++){//for loop, initiate with a new integer, put limitation, put incrementattion decramentation method
                Console.WriteLine(i);
            }
        }
    }
}
