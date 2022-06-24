using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalCodes
{
    internal class ShifteDraft1
    {
        public void ShiftedCode1()
        {
            /*int num = 123;
            string numStr = num.ToString();
            for (int i = numStr.Length-1; i >= 0; i--)
            {
                numStr += numStr[i];
            }
            Console.WriteLine(numStr);*/

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


            #region initializer
            string str = "hola amigo!";
            string strI = "hola amigo!";
            string strR = string.Empty;
            int num = 5;
            #endregion
            #region soln.1 static
            for (int i = 0; i < num; i++)
            {
                strR += "a";
            }

            if (num >= 0)
            {
                str = "Ed" + strR + "bit";
            }
            else
            {
                str = "";
            }

            Console.WriteLine(str);
            #endregion
            #region soln.2 more likely dynamic
            for (int i = 0; i < strI.Length; i++)
            {
                if (strI[i] == 'a')
                {
                    for (int j = 0; j < num; j++)
                    {
                        strR += strI[i];
                    }
                    break;
                }

            }
            if (num < 0)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine(strI.Replace("a", strR));
            }
            #endregion
        }
    }
}
