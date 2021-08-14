using System;

namespace ExperimentalCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string str = "https://www.reddit.com/r/funny/";
            string[] strSplit = str.Split('/');
            Console.WriteLine(strSplit[strSplit.Length - 2]);*/

            /*string str = "590O1";
            string newStr = string.Empty;
            bool isValid = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]) || char.IsWhiteSpace(str[i]))
                {
                    newStr += str[i];
                }
            }
            if (newStr.Length == 5)
            {
                isValid = true;
            }

            Console.WriteLine(newStr.Length);
            Console.WriteLine(isValid);
            Console.WriteLine(newStr);*/

            /*string str = "R!=:~0o0./c&}9k`60=y";
            string newStr = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    newStr += str[i];
                }
            }
            Console.WriteLine(newStr);*/

            /*string str = "I have never seen a thin person drinking Diet Coke.";
            //char[] vowel = new char[] { 'a', 'e', 'i', 'o', 'u' };
            string newStr = null;
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'a' :
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        newStr += "";
                        break;
                    default:
                        newStr += str[i];
                        break;
                }
            }
            Console.WriteLine(newStr);*/

            /*string str = "eQuINoX";
            int[] upperIndex = new int[str.Length];
            int j = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    upperIndex[j] = i;
                    j++;
                }
            }
            for (int i = 0; i < j; i++)
            {
                if (upperIndex[i] == upperIndex.Length - 1)
                {

                    Console.Write(upperIndex[i]);
                }
                else
                {
                    Console.Write(upperIndex[i] + ", ");
                    
                }
            }*/

            /*string str = "Happy Birthday";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    Console.Write(char.ToLower(str[i]));
                }
                Console.Write(char.ToUpper(str[i]));
            }*/

            /*string str = "There is a bomb.";
            string[] strSplit = str.Split(' ');
            Console.WriteLine(strSplit[strSplit.Length - 1].Trim('.'));


            for (int i = 0; i < strSplit.Length; i++)
            {
                if (strSplit[i].Trim('.') == "bomb")
                {
                    Console.WriteLine(true);
                }
                Console.WriteLine(false);
            }*/

            /*if (str.Contains("bomb"))
            {
                Console.WriteLine("Duck!!!");
            }
            else
            {
                Console.WriteLine("There is no bomb, relax!");
            }*/
            
        }
    }
}
