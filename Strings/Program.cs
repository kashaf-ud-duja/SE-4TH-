using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstname = "mosh";
            var lastname = "hamdani";
            var fullname = firstname + " " + lastname;

            var myfullname = string.Format("my name is {0} {1}", firstname, lastname);

            var names = new string[3] { "john", "smith", "mary" };
            var formattednames = string.Join(",", names);

            var text = @"hi john
look into the following path
C:\Users\lenovo\Desktop\New folder";
            Console.WriteLine(text);
        }
    }
}
