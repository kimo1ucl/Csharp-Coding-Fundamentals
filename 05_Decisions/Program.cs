using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            //assigning
            string userValue = Console.ReadLine();


            //Decision
            /*
            if (userValue == "1")
            {
                string message = "You won a new car!";
                Console.WriteLine(message);
            }
            else if (userValue == "2")
            {
                string message = "You won a new boat!";
                Console.WriteLine(message);
            }
            else if (userValue == "3")
            {
                string message = "You won a new cat!";
                Console.WriteLine(message);
            }
            else
            {
                string message = "Sorry, we didn't understand that...";
                Console.WriteLine(message);
            }
            */

            //Decision refactored,
            //same variable message + ("bucket") used for all decision evaluations
            /*
            string message = "";

            if (userValue == "1")
            {
                message = "You won a new car!";
            }
            else if (userValue == "2")
            {
                message = "You won a new boat!";
            }
            else if (userValue == "3")
            {
                message = "You won a new cat!";
            }
            else
            {
                message = "Sorry, we didn't understand that...";
                message += "You loose";
                Console.WriteLine(message);
            }
            Console.WriteLine(message);
            Console.ReadLine();
            */

            //single condition
            string message = (userValue == "1") ? "boat" : "strand of lint";
            Console.WriteLine("You entered: {0}, therefor you won a {1}.",userValue, message);
            Console.ReadLine();

        }
    }
}
