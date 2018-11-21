using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHand
{
    class Program
    {
        static void Main(string[] args)
        {
            string restart;

            do
            {
                string input;


                do
                {

                    Console.ForegroundColor = ConsoleColor.White;
                    input = Console.ReadLine();

                }
                while (!Validate.Valid(input));

                var hand = new Hand(input);
                var result = hand.GetHandName();

                Console.WriteLine(result);

                //----------------------------------------------------------------

                Console.Write("Do you wish to calculate another? (YES/NO) ");
                restart = Console.ReadLine().ToUpper();
                while ((restart != "YES") && (restart != "NO"))   //????
                {
                    Console.WriteLine("Error");
                    Console.WriteLine("Do you wish to calculate another? (YES/NO) ");
                    restart = Console.ReadLine().ToUpper();
                }
            }

            while (restart == "YES");

        }

    }
}

