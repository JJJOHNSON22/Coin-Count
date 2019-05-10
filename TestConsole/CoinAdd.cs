using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class CoinAdd
    {
        public int quarter = 25;
        public int dime = 10;
        public int nickel = 5;
        public int penny = 1;

        public void ExactChange()
        {
            Random rand = new Random();
            int number = rand.Next(1, 99);
            int quarterCount = 0;
            int dimeCount = 0;
            int nickelCount = 0;
            int pennyCount = 0;
            Console.WriteLine($"Random number is {number}");
            while (number >= quarter)
            {
                number = number - quarter;
                quarterCount++;
            }
            Console.WriteLine($"{quarterCount} Quarter");
            while (number >= dime)
            {
                number = number - dime;
                dimeCount++;
            }
            Console.WriteLine($"{dimeCount} Dime");
            while (number >= nickel)
            {
                number = number - nickel;
                nickelCount++;
            }
            Console.WriteLine($"{nickelCount} Nickel");
            while (number >= penny)
            {
                number = number - penny;
                pennyCount++;
            }
            Console.WriteLine($"{pennyCount} Penny");
            Console.ReadLine();
        }
    }
}
