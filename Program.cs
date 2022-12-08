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
            
            string a = "Hello World";//creates string
            string b = "!";

            a += b;//add string
            Console.WriteLine(a.IndexOf("o"));//gives us index value of the inserted argument, "o" in this case
            Console.WriteLine(a.ToUpper());//Makes all letters upper case
            Console.WriteLine(a.Substring(3, 4));//gives substring starting from index of first value for second value of letters
        }
    }
}
