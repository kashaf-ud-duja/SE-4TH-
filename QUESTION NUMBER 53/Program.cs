using System;

namespace QUESTION_NUMBER_53
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20, y = 35;
            x = y++ + x++;
            y = y++ + ++x;

            Console.WriteLine("the result is"+"x="+x+"y="+y);

            int a = 10, b = 15;
            a = a++;
            b = ++b;
            Console.WriteLine("the result is" + "a=" + a + "b=" + b);

            int c = 10;
            int d = 0;
            d = c--;
            Console.WriteLine("the result is" + "d=" + d );

            int e = 10;
            Console.WriteLine("the result is" + "e=" + e++);

            int i = 5, j = 6, k = 7, n = 3;
            Console.WriteLine("the result is"+ (i+j*k-k%n));
            Console.WriteLine("the result is" + i/j);

            int f = 6;
            Console.WriteLine("the result is" + " "+ "f="+f);
            f = f + 3;
            Console.WriteLine("the result is" + " " + "f=" + f);
            f -= 5;
            Console.WriteLine("the result is" + " " + "f=" + f);
            f++;
            Console.WriteLine("the result is" + " " + "f=" + f);
        }
    }
}
