using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSymbolOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string");
            var strLine = Console.ReadLine();
            Console.WriteLine("Input a symbol");
            var c = 0;
            var chSym = (char)Console.Read();
            var nLen = strLine.Length;
            for (int i = 0; i < nLen; i++)
            {
                if (strLine[i] == chSym)
                {
                    c++;
                }
            }
            var fltPart = ((float)c / nLen) * 100f;
            Console.WriteLine("The symbol {0} occurs {1} times", chSym, c);
            Console.WriteLine
            (
                "The symbol \"{0}\" occupies {1}% of the string \"{2}\"",
                chSym, fltPart, strLine
            );
            Console.Read();
        }
    }
}
