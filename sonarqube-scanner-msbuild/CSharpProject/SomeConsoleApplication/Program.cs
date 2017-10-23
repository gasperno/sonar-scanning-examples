using System;
namespace SomeConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            var iAmTrue = true;
			var i=0;
            if (iAmTrue)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.ReadKey();
        }

        public static bool AlwaysReturnsTrue()
        {
            return true;
        }

        public static object Passthrough(object obj)
        {
            return obj;
        }
    }
}
