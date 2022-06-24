using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalCodes
{
    internal class ShiftedSolvedDraft1
    {
        /*string[] bigrams = new string[] {"ay", "be", "ta", "cu"};
            string[] words = new string[] { "maybe", "beta", "abet", "course" };
            bool[] flagsTrue = new bool[bigrams.Length];
            bool[] flagsFalse = new bool[bigrams.Length];
            bool flag = false;

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine("----------\n" + words[i] + "\n----------");
                for (int j = 0; j < bigrams.Length; j++)
                {
                    Console.Write(bigrams[j] + ": ");

                    if (words[i].Contains(bigrams[j]))
                    {
                        flagsTrue[j] = true;
                        Console.WriteLine(flagsTrue[j]);
                    }
                    else
                    {
                        flagsFalse[j] = false;
                        Console.WriteLine(flagsFalse[j]);
                    }
                }
            }

            for (int i = 0; i < flagsTrue.Length; i++)
            {
                if (flagsTrue[i] == true)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
                
            }

            Console.WriteLine("----------\nR: " + flag + "\n----------");*/

        /*int num = 123;
        string numStr = num.ToString();
        for (int i = numStr.Length-1; i >= 0; i--)
        {
            numStr += numStr[i];
        }
        Console.WriteLine(numStr);*/

        /*string str = "Wh*r* d*d my v*w*ls g*?";
        string newStr = string.Empty;
        string vow = "eeioeo";
        int j = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '*')
            {
                newStr += vow[j];
                j++;
            }
            else
            {
                newStr += str[i];
            }

        }
        Console.WriteLine(newStr);*/

        /*string hexCode = "#CD5C5Z";
        bool flag = false;

        if (hexCode[0] == '#' && hexCode.Length <= 7)
        {
            flag = true;
            for (int i = 0; i < hexCode.Length-1; i++)
            {
                if (hexCode[i+1] >= Convert.ToInt32('0') && hexCode[i+1] <= Convert.ToInt32('9') || hexCode[i+1] >= 'A' && hexCode[i+1] <= 'F')
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
        }
        else
        {
            flag = false;
        }

        Console.WriteLine(hexCode + ": " + flag);*/

        /*string str = "Marigold daffodils streaming happily.";
        string[] strSplit = str.Split(' ');
        bool flag = false;
        string test = "";
        string test2 = "";

        for (int i = 0; i < strSplit.Length - 1; i++)
        {
            test2 += strSplit[i + 1][0]; // start from second word to last [get first char]
            test += (strSplit[i][strSplit[i].Length - 1]); // start from first word to before last word [get last char]

            if (strSplit[i + 1][0] == strSplit[i][strSplit[i].Length - 1])
            {
                flag = (true);
                Console.WriteLine(flag);
            }
            else
            {
                flag = (false);
                Console.WriteLine(flag);
                break;
            }
        }

        Console.WriteLine(test + "==" + test2);
        Console.WriteLine(flag);*/
    }
}
