using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public static class Helpers
    {
        public static int LetterCounter(this string word, char x)
        {
            int count = 0;
            foreach (char ch in word)
            {
                if (ch == x)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
