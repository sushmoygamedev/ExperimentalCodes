using System;
using System.Text.RegularExpressions;

namespace ExperimentalCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 1000;
            int z = 1010;
            int year = 0;
            int betweenYear = 0;

            for (int i = 0; i <= z; i++)
            {
                year = y + i;

                for (int j = 10; j <= 21; j++)
                {
                    betweenYear = j * 100;

                    if (year > betweenYear - 1 && year <= betweenYear)
                    {
                        if (year == betweenYear)
                        {
                            Console.WriteLine(year + ": " + (year / 100));
                        }
                        else
                        {
                            Console.WriteLine(year + ": " + (year / 100 + 1));
                        }
                    }
                    /*Console.WriteLine(betweenYear - 1);
                    Console.WriteLine(betweenYear);
                    Console.WriteLine();*/
                }

                /*if (year > 1099 && year <= 1199)
                {
                    if (year == 1100)
                    {
                        Console.WriteLine(year + ": " + (year / 100));
                    }
                    else
                    {
                        Console.WriteLine(year + ": " + (year / 100 + 1));
                    }
                }*/
            }

            /*Regex pattern = new Regex("(potato)");
            string str = "appleapplepotatopotato";

            Match match = pattern.Match(str);
            Console.WriteLine(match.Length);
            for (int i = 0; i < match.Groups.Count; i++)
            {
                Console.WriteLine(match.Groups[i]);
            }*/

            /*MatchCollection matchCol = pattern.Matches(str);
            Console.WriteLine(matchCol.Count);*/



            /*if (pattern.IsMatch(str))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }*/

            //Match match = pattern.Match(str);
            /*foreach (Match item in match.Groups)
            {
                Console.WriteLine(item);
            }*/

            //MatchCollection matchCol = pattern.Matches(str);

            /*foreach(Match match in matchCol)
            {
                Console.WriteLine(match);
            }*/

            /*for (int i = 0; i < matchCol.Count; i++)
            {
                Console.WriteLine(i);
            }*/

            /*Console.WriteLine("Input Year Between 100 to MAX");
            Console.Write("Input Start Year: ");
            string yearStartInput = Console.ReadLine();
            Console.Write("Input End Year: ");
            string yearEndInput = Console.ReadLine();

            int yearStart = Convert.ToInt32(yearStartInput) / 100;
            int yearEnd = Convert.ToInt32(yearEndInput) / 100;
            const int yearT = 100;

            for (int i = yearStart * yearT; i <= yearEnd * yearT; i++)
            {
                if (i % 100 == 00 || i % 1000 == 000)
                {
                    System.Console.WriteLine(i + ": " + i / 100 + "th Century");
                }
                else
                {
                    System.Console.WriteLine(i + ": " + (i / 100 + 1) + "th Century");
                }
            }*/
        }
    }
}