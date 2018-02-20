using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIAMOND
{
    class Program
    {
        static void Main()
        {
            char s, c;
            int j, i, n, d, f, z, p;

            Console.Write("Enter the letter:   ");


        Find:                                                         //check for correct input
            try
            {
                s = Convert.ToChar(Console.ReadLine());

                if (((int)s < (int)('A')) | ((int)s > (int)('Z')))
                {
                    Console.WriteLine("You entered an incorrect character, please try again!");
                    Console.Write("Enter the letter:   ");

                    goto Find;
                }
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("You entered a string, not a character, please try again! " + e.Message);
                Console.Write("Enter the letter:   ");

                goto Find;

            }


            c = 'A';
            n = (int)s - (int)c;
            j = n;
            p = n;
            n = n + n;

            for (i = 0; i <= n; i++)                           //strat drawing a diamond
            {
                for (d = 1; d <= j; d++)                    // draw spaces
                {
                    Console.Write(" ");
                }

                Console.Write(c);
                if (c != 'A')                             // draw spaces between letters
                {
                    z = ((int)c - (int)'A') * 2 - 1;
                    for (f = 1; f <= z; f++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(c);
                }
                for (d = 1; d <= j; d++)                         // draw spaces
                {
                    Console.Write(" ");
                }
                Console.WriteLine();

                if (i < p)                                         // here we check that we draw first half of diamond
                {                                                // and need to draw a second half of diamond 
                    j--;
                    c = (char)((int)c + 1);
                }
                else
                {
                    j++;
                    c = (char)((int)c - 1);
                }
            }

            Console.ReadKey();
        }
    }
}

