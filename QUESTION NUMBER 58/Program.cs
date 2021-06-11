using System;

namespace QUESTION_NUMBER_58
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 2;
            b = 3;
            c = 5;

            Console.WriteLine("the result is"+ ++a);
            Console.WriteLine("the result is" + a*b*c);
            Console.WriteLine("the result is" + a++);
            Console.WriteLine("the result is" + b + a);

        }
    }
}
