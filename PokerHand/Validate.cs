using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHand
{
    class Validate
    {
        public static bool Valid(string input)

        {

            if (!String.IsNullOrEmpty(input) && input.Split(',').Length >= 5)
            {
                return validateCard(input);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Input should be more than 5 cards!!");
            return false;
        }

        public static bool validateCard(string input)
        {
            var temp = input.Split(',');

            Regex pattern = new Regex("^([SsDdCcHh][1-9]|[SsDdCcHh]1[01234])$");

            foreach (var item in temp)
            {
                if (!pattern.IsMatch(item))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{item} is not valid");
                    return false;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            return true;

        }
    }
}
