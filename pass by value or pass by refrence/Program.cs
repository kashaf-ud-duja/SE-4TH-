using System;

namespace pass_by_value_or_pass_by_refrence
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a:{0},b:{1}", a, b));

            var array1 = new int[3] { 1, 2, 3 };
            array2[0] = 0;
                Console.WriteLine(string.Format("array1[0]:{0},array2[0]:{1}",array1[0],Array2[0]));
        }
    }
}
