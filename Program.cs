using System;

namespace SyntaxSugar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sugar());
        }

        public static string Sugar ()
        {
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";

            return response;
        }
    }
}
