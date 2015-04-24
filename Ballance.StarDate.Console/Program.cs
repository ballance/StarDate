using System;

namespace Ballance.StarDate.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a date");
            var stringDate = System.Console.ReadLine();

            var parsedDate = DateTime.Parse(stringDate);

            var convertedToStarDate = parsedDate.ToStarDate();

            System.Console.WriteLine("Equivalent TNG Star Date: {0}", convertedToStarDate);
            System.Console.ReadKey();
        }
    }
}
