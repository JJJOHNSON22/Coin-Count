using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public static class CoinExtension
    {
        public static int QuarterCount(this ref int number)
        {
            int quarter = 25;
            int quarterCount = 0;
            while (number >= quarter)
            {
                number = number - quarter;
                quarterCount++;
            }
            return quarterCount;
        }

        public static int DimeCount(this ref int number)
        {
            int dime = 10;
            int dimeCount = 0;
            while (number >= dime)
            {
                number = number - dime;
                dimeCount++;
            }
            return dimeCount;
        }

        public static int NickleCount(this ref int number)
        {
            int nickle = 5;
            int nickleCount = 0;
            while (number >= nickle)
            {
                number = number - nickle;
                nickleCount++;
            }
            return nickleCount;
        }

        public static int PennyCount(this ref int number)
        {
            int penny = 1;
            int pennyCount = 0;
            while (number >= penny)
            {
                number = number - penny;
                pennyCount++;
            }
            return pennyCount;
        }
    }
}
