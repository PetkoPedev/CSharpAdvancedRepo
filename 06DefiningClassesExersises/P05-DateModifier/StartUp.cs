using System;
using System.Linq;

namespace P05_DateModifier
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var token = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var date1 = new DateTime(token[0], token[1], token[2]);

            token = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var date2 = new DateTime(token[0], token[1], token[2]);

            var dateModifier = new DateModifier(date1, date2);
            Console.WriteLine(dateModifier.DifferenceInDates());
        }
    }
}
