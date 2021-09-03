using System;
using System.Text.RegularExpressions;

namespace ExperimentalCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex("(potato)");
            string str = "appleapplepotatopotato";

            Match match = pattern.Match(str);
            Console.WriteLine(match.Length);
            for (int i = 0; i < match.Groups.Count; i++)
            {
                Console.WriteLine(match.Groups[i]);
            }

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
        }
    }
}