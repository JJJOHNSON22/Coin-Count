using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //int count = 0;
            //string x = "Hello World";
            //string x1;
            //char c = 'l';
            //foreach(char ch in x)
            //{
            //    if (ch == 'l')
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //int y = "Hello World".LetterCounter('l');
            //double x = (double)y;
            //Console.WriteLine(y); 

            //Console.ReadLine();

            //CoinAdd coin = new CoinAdd();
            //coin.ExactChange();
            Console.WriteLine("Please enter a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            int quarters = number.QuarterCount();
            int dimes = number.DimeCount();
            int nickles = number.NickleCount();
            int pennies = number.PennyCount();
            Console.WriteLine($"{quarters} Quarters - {dimes} Dimes - {nickles} Nickles - {pennies} Pennies");
        }
    }
}
