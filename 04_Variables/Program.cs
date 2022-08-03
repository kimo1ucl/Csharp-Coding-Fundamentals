using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Declaration
            int x;
            int y;
            
            //initialization
            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
            */

            /*
            Console.WriteLine("What is you name?");
            Console.WriteLine("What is your first name?");
            string myFirstName;
            myFirstName = Console.ReadLine();

            string myLastName;
            Console.WriteLine("What is your last name?");
            myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            Console.ReadLine();
            */
            
            Console.WriteLine("What is you name?");
            Console.WriteLine("What is your first name?");
            string myFirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            Console.ReadLine();
        }
    }
}
