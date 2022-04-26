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
            var answer2 = "is less than nine";
            var answer3 = " is greater than or equal to nine";
            var response = (answer < 9) ? $"{answer2}" : $"{answer3}";

            return response;
        }




    }
}
